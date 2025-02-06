namespace C_SHARK
{
    partial class Portal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portal));
            PortalHolder = new Panel();
            DiffrenceAlert = new Label();
            HintText = new Label();
            RepasswordLogo = new PictureBox();
            ComplexityTick = new PictureBox();
            PasswordComplexity = new ProgressBar();
            RepasswordTitle = new Label();
            KeepSignTitle = new Label();
            KeepSign = new PictureBox();
            PasswordTitle = new Label();
            Repassword = new TextBox();
            PasswordLogo = new PictureBox();
            Password = new TextBox();
            PortalState = new Label();
            PortalLogo = new PictureBox();
            Exit = new PictureBox();
            AppCompany = new Label();
            AppVersion = new Label();
            AppName = new Label();
            AppLogo = new PictureBox();
            Search = new System.Windows.Forms.Timer(components);
            PortalHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RepasswordLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ComplexityTick).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KeepSign).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PasswordLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PortalLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AppLogo).BeginInit();
            SuspendLayout();
            // 
            // PortalHolder
            // 
            PortalHolder.BackColor = Color.White;
            PortalHolder.BorderStyle = BorderStyle.FixedSingle;
            PortalHolder.Controls.Add(DiffrenceAlert);
            PortalHolder.Controls.Add(HintText);
            PortalHolder.Controls.Add(RepasswordLogo);
            PortalHolder.Controls.Add(ComplexityTick);
            PortalHolder.Controls.Add(PasswordComplexity);
            PortalHolder.Controls.Add(RepasswordTitle);
            PortalHolder.Controls.Add(KeepSignTitle);
            PortalHolder.Controls.Add(KeepSign);
            PortalHolder.Controls.Add(PasswordTitle);
            PortalHolder.Controls.Add(Repassword);
            PortalHolder.Controls.Add(PasswordLogo);
            PortalHolder.Controls.Add(Password);
            PortalHolder.Controls.Add(PortalState);
            PortalHolder.Controls.Add(PortalLogo);
            PortalHolder.Controls.Add(Exit);
            PortalHolder.Controls.Add(AppCompany);
            PortalHolder.Controls.Add(AppVersion);
            PortalHolder.Controls.Add(AppName);
            PortalHolder.Controls.Add(AppLogo);
            PortalHolder.Dock = DockStyle.Fill;
            PortalHolder.Location = new Point(0, 0);
            PortalHolder.Name = "PortalHolder";
            PortalHolder.Size = new Size(800, 600);
            PortalHolder.TabIndex = 2;
            // 
            // DiffrenceAlert
            // 
            DiffrenceAlert.Font = new Font("Zain", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DiffrenceAlert.ForeColor = Color.DarkRed;
            DiffrenceAlert.Location = new Point(426, 387);
            DiffrenceAlert.Name = "DiffrenceAlert";
            DiffrenceAlert.Size = new Size(153, 35);
            DiffrenceAlert.TabIndex = 23;
            DiffrenceAlert.Text = "is not same yet!";
            DiffrenceAlert.TextAlign = ContentAlignment.BottomRight;
            DiffrenceAlert.Visible = false;
            // 
            // HintText
            // 
            HintText.Font = new Font("Zain", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HintText.ForeColor = Color.Black;
            HintText.Location = new Point(11, 498);
            HintText.Name = "HintText";
            HintText.Size = new Size(776, 92);
            HintText.TabIndex = 22;
            HintText.Text = "⭕ 8 to 16 letters  ⭕ 4 Uppercase letters  ⭕ 4 Lowercase letters \r\n⭕ At least 4 number  ⭕ Include sign character like (@, #, etc..)";
            HintText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RepasswordLogo
            // 
            RepasswordLogo.BackgroundImage = Properties.Portal.link;
            RepasswordLogo.BackgroundImageLayout = ImageLayout.Zoom;
            RepasswordLogo.Location = new Point(217, 387);
            RepasswordLogo.Name = "RepasswordLogo";
            RepasswordLogo.Size = new Size(32, 32);
            RepasswordLogo.TabIndex = 19;
            RepasswordLogo.TabStop = false;
            // 
            // ComplexityTick
            // 
            ComplexityTick.BackColor = Color.FromArgb(224, 224, 224);
            ComplexityTick.BackgroundImage = Properties.Resources.require;
            ComplexityTick.BackgroundImageLayout = ImageLayout.Zoom;
            ComplexityTick.Location = new Point(547, 326);
            ComplexityTick.Name = "ComplexityTick";
            ComplexityTick.Size = new Size(32, 32);
            ComplexityTick.TabIndex = 18;
            ComplexityTick.TabStop = false;
            // 
            // PasswordComplexity
            // 
            PasswordComplexity.BackColor = Color.White;
            PasswordComplexity.ForeColor = Color.White;
            PasswordComplexity.Location = new Point(217, 364);
            PasswordComplexity.Name = "PasswordComplexity";
            PasswordComplexity.Size = new Size(362, 17);
            PasswordComplexity.Style = ProgressBarStyle.Continuous;
            PasswordComplexity.TabIndex = 17;
            // 
            // RepasswordTitle
            // 
            RepasswordTitle.Font = new Font("Ubuntu", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            RepasswordTitle.ForeColor = Color.Black;
            RepasswordTitle.Location = new Point(255, 387);
            RepasswordTitle.Name = "RepasswordTitle";
            RepasswordTitle.Size = new Size(165, 32);
            RepasswordTitle.TabIndex = 15;
            RepasswordTitle.Text = "Confirm Password";
            RepasswordTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // KeepSignTitle
            // 
            KeepSignTitle.Font = new Font("Zain Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KeepSignTitle.ForeColor = Color.Black;
            KeepSignTitle.Location = new Point(255, 463);
            KeepSignTitle.Name = "KeepSignTitle";
            KeepSignTitle.Size = new Size(138, 32);
            KeepSignTitle.TabIndex = 14;
            KeepSignTitle.Text = "Keep me signed in";
            KeepSignTitle.TextAlign = ContentAlignment.BottomLeft;
            // 
            // KeepSign
            // 
            KeepSign.BackgroundImage = Properties.Resources.uncheck;
            KeepSign.BackgroundImageLayout = ImageLayout.Zoom;
            KeepSign.Cursor = Cursors.Hand;
            KeepSign.Location = new Point(217, 463);
            KeepSign.Name = "KeepSign";
            KeepSign.Size = new Size(32, 32);
            KeepSign.TabIndex = 13;
            KeepSign.TabStop = false;
            KeepSign.Click += KeepSign_Click;
            // 
            // PasswordTitle
            // 
            PasswordTitle.Font = new Font("Ubuntu", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            PasswordTitle.ForeColor = Color.Black;
            PasswordTitle.Location = new Point(255, 288);
            PasswordTitle.Name = "PasswordTitle";
            PasswordTitle.Size = new Size(100, 32);
            PasswordTitle.TabIndex = 12;
            PasswordTitle.Text = "Password";
            PasswordTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Repassword
            // 
            Repassword.BackColor = Color.FromArgb(255, 255, 128);
            Repassword.BorderStyle = BorderStyle.None;
            Repassword.Enabled = false;
            Repassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Repassword.Location = new Point(217, 425);
            Repassword.Multiline = true;
            Repassword.Name = "Repassword";
            Repassword.PasswordChar = '●';
            Repassword.Size = new Size(362, 32);
            Repassword.TabIndex = 11;
            Repassword.TextAlign = HorizontalAlignment.Center;
            Repassword.KeyPress += Repassword_KeyPress;
            // 
            // PasswordLogo
            // 
            PasswordLogo.BackgroundImage = Properties.Portal.password;
            PasswordLogo.BackgroundImageLayout = ImageLayout.Zoom;
            PasswordLogo.Location = new Point(217, 288);
            PasswordLogo.Name = "PasswordLogo";
            PasswordLogo.Size = new Size(32, 32);
            PasswordLogo.TabIndex = 10;
            PasswordLogo.TabStop = false;
            // 
            // Password
            // 
            Password.BackColor = Color.FromArgb(224, 224, 224);
            Password.BorderStyle = BorderStyle.None;
            Password.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.Location = new Point(217, 326);
            Password.MaxLength = 16;
            Password.Multiline = true;
            Password.Name = "Password";
            Password.Size = new Size(362, 32);
            Password.TabIndex = 9;
            Password.TextAlign = HorizontalAlignment.Center;
            Password.KeyPress += Password_KeyPress;
            // 
            // PortalState
            // 
            PortalState.Font = new Font("Ubuntu", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            PortalState.ForeColor = Color.FromArgb(192, 0, 192);
            PortalState.Location = new Point(303, 237);
            PortalState.Name = "PortalState";
            PortalState.Size = new Size(191, 32);
            PortalState.TabIndex = 8;
            PortalState.Text = "Sign Up";
            PortalState.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PortalLogo
            // 
            PortalLogo.BackColor = Color.White;
            PortalLogo.BackgroundImage = Properties.Portal.portal;
            PortalLogo.BackgroundImageLayout = ImageLayout.Zoom;
            PortalLogo.Location = new Point(348, 134);
            PortalLogo.Name = "PortalLogo";
            PortalLogo.Size = new Size(100, 100);
            PortalLogo.TabIndex = 7;
            PortalLogo.TabStop = false;
            // 
            // Exit
            // 
            Exit.BackgroundImage = Properties.Resources.exit;
            Exit.BackgroundImageLayout = ImageLayout.Zoom;
            Exit.Cursor = Cursors.Hand;
            Exit.Location = new Point(755, 11);
            Exit.Name = "Exit";
            Exit.Size = new Size(32, 32);
            Exit.TabIndex = 6;
            Exit.TabStop = false;
            Exit.Click += Exit_Click;
            // 
            // AppCompany
            // 
            AppCompany.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AppCompany.ForeColor = Color.Black;
            AppCompany.Location = new Point(80, 32);
            AppCompany.Name = "AppCompany";
            AppCompany.Size = new Size(234, 22);
            AppCompany.TabIndex = 5;
            AppCompany.Text = "b‿daarr Cyber Team ®";
            AppCompany.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AppVersion
            // 
            AppVersion.Font = new Font("Consolas", 7.8F);
            AppVersion.ForeColor = Color.Black;
            AppVersion.Location = new Point(82, 56);
            AppVersion.Name = "AppVersion";
            AppVersion.Size = new Size(157, 20);
            AppVersion.TabIndex = 4;
            AppVersion.Text = "Desktop 2025.02.03";
            AppVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AppName
            // 
            AppName.Font = new Font("Ubuntu", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            AppName.ForeColor = Color.Black;
            AppName.Location = new Point(80, 10);
            AppName.Name = "AppName";
            AppName.Size = new Size(110, 22);
            AppName.TabIndex = 3;
            AppName.Text = "C-SHARK";
            AppName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AppLogo
            // 
            AppLogo.BackColor = Color.FromArgb(214, 185, 115);
            AppLogo.BackgroundImage = Properties.Resources.logo;
            AppLogo.BackgroundImageLayout = ImageLayout.Zoom;
            AppLogo.Location = new Point(10, 10);
            AppLogo.Name = "AppLogo";
            AppLogo.Size = new Size(66, 66);
            AppLogo.TabIndex = 0;
            AppLogo.TabStop = false;
            // 
            // Search
            // 
            Search.Interval = 50;
            Search.Tick += Search_Tick;
            // 
            // Portal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(PortalHolder);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Portal";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Portal_Load;
            PortalHolder.ResumeLayout(false);
            PortalHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RepasswordLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ComplexityTick).EndInit();
            ((System.ComponentModel.ISupportInitialize)KeepSign).EndInit();
            ((System.ComponentModel.ISupportInitialize)PasswordLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)PortalLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)Exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)AppLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PortalHolder;
        private PictureBox Exit;
        private Label AppCompany;
        private Label AppVersion;
        private Label AppName;
        private PictureBox AppLogo;
        private PictureBox PortalLogo;
        private Label PortalState;
        private TextBox Password;
        private PictureBox PasswordLogo;
        private TextBox Repassword;
        private PictureBox KeepSign;
        private Label KeepSignTitle;
        private PictureBox ComplexityTick;
        private ProgressBar PasswordComplexity;
        private PictureBox RepasswordLogo;
        private Label RepasswordTitle;
        private Label PasswordTitle;
        private Label HintText;
        private System.Windows.Forms.Timer Search;
        private Label DiffrenceAlert;
    }
}