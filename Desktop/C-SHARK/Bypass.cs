using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_SHARK
{
    public partial class Bypass : Form
    {
        public Bypass()
        {
            InitializeComponent();
        }

        private void Bypass_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Do you want to exit? \nIn case of exit, the services will be disabled!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (msg == DialogResult.OK)
            {
                // Method To Disconnect
                // Method to stop networkPanel Process
                //File.AppendAllText(global.appLog(), global.logMessageAE);
                Application.Exit();
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            AllTabs.SelectedTab = Homes;
        }

        private void Notification_Click(object sender, EventArgs e)
        {
            AllTabs.SelectedTab = Notifications;
        }

        private void Log_Click(object sender, EventArgs e)
        {
            AllTabs.SelectedTab = Logs;
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            AllTabs.SelectedTab = Settings;
        }

        private bool info_hovering = true;
        private void Info_Click(object sender, EventArgs e)
        {
            info_hovering = false;
            AllTabs.SelectedTab = Information;
            Info.Cursor = Cursors.Default;
        }

        private void Info_MouseEnter(object sender, EventArgs e)
        {
            if (info_hovering)
            {
                Info.BackgroundImage = Properties.Bypass.mini_info;
            }
        }

        private void Info_MouseLeave(object sender, EventArgs e)
        {
            if (info_hovering)
            {
                Info.BackgroundImage = Properties.Bypass.info;
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {

        }
    }
}
