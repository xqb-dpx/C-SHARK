using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace C_SHARK
{
    public partial class Portal : Form
    {
        public Portal()
        {
            InitializeComponent();
        }

        private string username, keypass;
        public bool checkedin = false;
        private int i = 0;
        private int tmp = 0;
        private bool registered = false;


        private void Portal_Load(object sender, EventArgs e)
        {
            UpdatePortalState(registered);
        }

        private void UpdatePortalState(bool registered)
        {
            if (!registered)
            {
                PortalState.Text = "Sign Up";
                PortalState.ForeColor = Color.FromArgb(192, 0, 192);
                ToggleRegistrationFields(true);
            }
            else
            {
                PortalState.Text = "Sign In";
                PortalState.ForeColor = Color.BlueViolet;
                ToggleRegistrationFields(false);
            }
        }

        private void ToggleRegistrationFields(bool visible)
        {
            RepasswordTitle.Visible = visible;
            Repassword.Visible = visible;
            ComplexityTick.Visible = visible;
            RepasswordLogo.Visible = visible;
            PasswordComplexity.Visible = visible;
        }

        private void GetUsername()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    username = queryObj["SerialNumber"].ToString();
                }
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Do you want to stop the process!?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (msg == DialogResult.OK)
            {
                // Method To Disconnect
                // Method to stop networkPanel Process
                Application.Exit();
            }
        }

        private bool IsSymbol(char c)
        {
            string symbols = "!@#$%^&*()-_+=[]{}|;:'\",.<>?/`~\\";
            return symbols.Contains(c);
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbols = "!@#$%^&*()-_+=[]{}|;:'\",.<>?/`~\\";
            UpdatePasswordComplexity(symbols);
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSymbol(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void UpdatePasswordComplexity(string symbols)
        {
            int upperCase = Password.Text.Count(char.IsUpper);
            int lowerCase = Password.Text.Count(char.IsLower);
            int digit = Password.Text.Count(char.IsDigit);
            int symbol = Password.Text.Count(c => symbols.Contains(c));

            Dictionary<string, string> hint_items = new Dictionary<string, string>
            {
                { "Length", "⭕" },
                { "Upper", "⭕" },
                { "Lower", "⭕" },
                { "Number", "⭕" },
                { "Sign", "⭕" }
            };

            int bar_value = 0;

            if (upperCase >= 3) { bar_value += 25; hint_items["Upper"] = "✔"; }
            if (lowerCase >= 3) { bar_value += 25; hint_items["Lower"] = "✔"; }
            if (digit >= 3) { bar_value += 25; hint_items["Number"] = "✔"; }
            if (symbol >= 1) { bar_value += 25; hint_items["Sign"] = "✔"; }
            if (Password.Text.Length >= 8) { hint_items["Length"] = "✔"; }

            PasswordComplexity.Value = bar_value;
            HintText.Text = $"{hint_items["Length"]} 8 to 16 letters {hint_items["Upper"]} 4 Uppercase letters {hint_items["Lower"]} 4 Lowercase letters\n{hint_items["Number"]} At least 4 number {hint_items["Sign"]} Include sign character like (@, +, #, etc..)";

            if (PasswordComplexity.Value == 100)
            {
                Repassword.Enabled = true;
                ComplexityTick.BackgroundImage = Properties.Resources.accept;
            }
            else
            {
                Repassword.Enabled = false;
                ComplexityTick.BackgroundImage = Properties.Resources.require;
            }
        }

        private void Repassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSymbol(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }

            if (!Repassword.Text.Equals(Password.Text) && e.KeyChar != (char)Keys.Enter)
            {
                DiffrenceAlert.Visible = true;
            }
            else
            {
                DiffrenceAlert.Visible = false;
                PortalState.Text = "Signing Up...";
                Search.Tick += Search_Tick;
                Search.Start();
            }
        }


        private void KeepSign_Click(object sender, EventArgs e)
        {
            checkedin = !checkedin;
            KeepSign.BackgroundImage = checkedin ? Properties.Resources.check : Properties.Resources.uncheck;
        }



        private void Search_Tick(object sender, EventArgs e)
        {
            string[] images = { "001", "002", "003", "004", "005", "006", "007", "008" };

            if (i < images.Length)
            {
                PortalLogo.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(images[i]);
            }

            i++;

            if (i == images.Length)
            {
                i = 0;
            }

            if (registered)
            {
                Search.Stop();
                Bypass bypass = new Bypass();
                bypass.Show();
                this.Close();
            }
            else
            {
                Search.Stop();
                PortalLogo.BackgroundImage = Properties.Resources.error;
                PortalState.Text = "An error occurred!";
                Password.Text = string.Empty;
                Repassword.Text = string.Empty;
                PasswordComplexity.Value = 0;
                Repassword.Enabled = false;
                ComplexityTick.BackgroundImage = Properties.Resources.require;
                Password.Focus();
            }
            tmp++;
        }
    }
}