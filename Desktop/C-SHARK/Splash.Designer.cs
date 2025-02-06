namespace C_SHARK
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            AppLogo = new PictureBox();
            AppName = new Label();
            AppTeam = new Label();
            AppVersion = new Label();
            SplashHolder = new Panel();
            Timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)AppLogo).BeginInit();
            SplashHolder.SuspendLayout();
            SuspendLayout();
            // 
            // AppLogo
            // 
            AppLogo.Anchor = AnchorStyles.None;
            AppLogo.BackColor = Color.FromArgb(214, 185, 115);
            AppLogo.BackgroundImage = Properties.Resources.logo;
            AppLogo.BackgroundImageLayout = ImageLayout.Zoom;
            AppLogo.Location = new Point(348, 248);
            AppLogo.Name = "AppLogo";
            AppLogo.Size = new Size(100, 100);
            AppLogo.TabIndex = 0;
            AppLogo.TabStop = false;
            // 
            // AppName
            // 
            AppName.Font = new Font("Ubuntu", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            AppName.ForeColor = Color.White;
            AppName.Location = new Point(302, 351);
            AppName.Name = "AppName";
            AppName.Size = new Size(193, 50);
            AppName.TabIndex = 1;
            AppName.Text = "C-SHARK";
            AppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AppTeam
            // 
            AppTeam.Font = new Font("Century Gothic", 12F);
            AppTeam.ForeColor = Color.White;
            AppTeam.Location = new Point(270, 401);
            AppTeam.Name = "AppTeam";
            AppTeam.Size = new Size(256, 62);
            AppTeam.TabIndex = 2;
            AppTeam.Text = "b‿daarr Cyber Team ®";
            AppTeam.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AppVersion
            // 
            AppVersion.Font = new Font("Consolas", 7.8F);
            AppVersion.ForeColor = Color.FromArgb(128, 128, 255);
            AppVersion.Location = new Point(591, 562);
            AppVersion.Name = "AppVersion";
            AppVersion.Size = new Size(195, 27);
            AppVersion.TabIndex = 3;
            AppVersion.Text = "[Desktop] V-2025.03.01.0";
            AppVersion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SplashHolder
            // 
            SplashHolder.BorderStyle = BorderStyle.Fixed3D;
            SplashHolder.Controls.Add(AppLogo);
            SplashHolder.Controls.Add(AppVersion);
            SplashHolder.Controls.Add(AppName);
            SplashHolder.Controls.Add(AppTeam);
            SplashHolder.Dock = DockStyle.Fill;
            SplashHolder.Location = new Point(0, 0);
            SplashHolder.Name = "SplashHolder";
            SplashHolder.Size = new Size(800, 600);
            SplashHolder.TabIndex = 4;
            // 
            // Timer
            // 
            Timer.Interval = 3000;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 28);
            ClientSize = new Size(800, 600);
            Controls.Add(SplashHolder);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Splash";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)AppLogo).EndInit();
            SplashHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox AppLogo;
        private Label AppName;
        private Label AppTeam;
        private Label AppVersion;
        private Panel SplashHolder;
        private System.Windows.Forms.Timer Timer;
    }
}