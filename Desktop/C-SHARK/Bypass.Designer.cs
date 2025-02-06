namespace C_SHARK
{
    partial class Bypass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bypass));
            Exit = new PictureBox();
            AppTeam = new Label();
            AppVersion = new Label();
            AppName = new Label();
            AppLogo = new PictureBox();
            BypassHolder = new Panel();
            AllTabs = new TabControl();
            Settings = new TabPage();
            Notifications = new TabPage();
            Homes = new TabPage();
            Command = new PictureBox();
            Logs = new TabPage();
            Information = new TabPage();
            EmailTitle = new Label();
            EmailLogo = new PictureBox();
            TelegramTitle = new Label();
            TelegramLogo = new PictureBox();
            GitHubTitle = new Label();
            GitHubLogo = new PictureBox();
            YouTubeTitle = new Label();
            YouTubeLogo = new PictureBox();
            WebsiteTitle = new Label();
            WebsiteLogo = new PictureBox();
            License = new RichTextBox();
            Log = new PictureBox();
            Notification = new PictureBox();
            Info = new PictureBox();
            Setting = new PictureBox();
            Home = new PictureBox();
            Minimize = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AppLogo).BeginInit();
            BypassHolder.SuspendLayout();
            AllTabs.SuspendLayout();
            Homes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Command).BeginInit();
            Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmailLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TelegramLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GitHubLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)YouTubeLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WebsiteLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Log).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Notification).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Info).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Setting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Home).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).BeginInit();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.BackgroundImage = Properties.Resources.exit;
            Exit.BackgroundImageLayout = ImageLayout.Zoom;
            Exit.Cursor = Cursors.Hand;
            Exit.Location = new Point(755, 11);
            Exit.Name = "Exit";
            Exit.Size = new Size(32, 32);
            Exit.TabIndex = 11;
            Exit.TabStop = false;
            Exit.Click += Exit_Click;
            // 
            // AppTeam
            // 
            AppTeam.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AppTeam.ForeColor = Color.Black;
            AppTeam.Location = new Point(83, 33);
            AppTeam.Name = "AppTeam";
            AppTeam.Size = new Size(234, 22);
            AppTeam.TabIndex = 10;
            AppTeam.Text = "b‿daarr Cyber Team ®";
            AppTeam.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AppVersion
            // 
            AppVersion.Font = new Font("Consolas", 7.8F);
            AppVersion.ForeColor = Color.Black;
            AppVersion.Location = new Point(83, 57);
            AppVersion.Name = "AppVersion";
            AppVersion.Size = new Size(157, 20);
            AppVersion.TabIndex = 9;
            AppVersion.Text = "Desktop 2025.02.03";
            AppVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AppName
            // 
            AppName.Font = new Font("Ubuntu", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            AppName.ForeColor = Color.Black;
            AppName.Location = new Point(83, 11);
            AppName.Name = "AppName";
            AppName.Size = new Size(110, 22);
            AppName.TabIndex = 8;
            AppName.Text = "C-SHARK";
            AppName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AppLogo
            // 
            AppLogo.BackColor = Color.FromArgb(214, 185, 115);
            AppLogo.BackgroundImage = Properties.Resources.logo;
            AppLogo.BackgroundImageLayout = ImageLayout.Zoom;
            AppLogo.Location = new Point(11, 11);
            AppLogo.Name = "AppLogo";
            AppLogo.Size = new Size(66, 66);
            AppLogo.TabIndex = 7;
            AppLogo.TabStop = false;
            // 
            // BypassHolder
            // 
            BypassHolder.BackColor = Color.White;
            BypassHolder.BorderStyle = BorderStyle.FixedSingle;
            BypassHolder.Controls.Add(AllTabs);
            BypassHolder.Controls.Add(Log);
            BypassHolder.Controls.Add(Notification);
            BypassHolder.Controls.Add(Info);
            BypassHolder.Controls.Add(Setting);
            BypassHolder.Controls.Add(Home);
            BypassHolder.Controls.Add(Minimize);
            BypassHolder.Controls.Add(Exit);
            BypassHolder.Controls.Add(AppTeam);
            BypassHolder.Controls.Add(AppVersion);
            BypassHolder.Controls.Add(AppLogo);
            BypassHolder.Controls.Add(AppName);
            BypassHolder.Dock = DockStyle.Fill;
            BypassHolder.Location = new Point(0, 0);
            BypassHolder.Name = "BypassHolder";
            BypassHolder.Size = new Size(800, 600);
            BypassHolder.TabIndex = 12;
            // 
            // AllTabs
            // 
            AllTabs.Controls.Add(Settings);
            AllTabs.Controls.Add(Notifications);
            AllTabs.Controls.Add(Homes);
            AllTabs.Controls.Add(Logs);
            AllTabs.Controls.Add(Information);
            AllTabs.Location = new Point(11, 83);
            AllTabs.Name = "AllTabs";
            AllTabs.SelectedIndex = 0;
            AllTabs.Size = new Size(776, 448);
            AllTabs.TabIndex = 20;
            // 
            // Settings
            // 
            Settings.Location = new Point(4, 29);
            Settings.Name = "Settings";
            Settings.Padding = new Padding(3);
            Settings.Size = new Size(768, 415);
            Settings.TabIndex = 0;
            Settings.UseVisualStyleBackColor = true;
            // 
            // Notifications
            // 
            Notifications.Location = new Point(4, 29);
            Notifications.Name = "Notifications";
            Notifications.Padding = new Padding(3);
            Notifications.Size = new Size(768, 415);
            Notifications.TabIndex = 1;
            Notifications.UseVisualStyleBackColor = true;
            // 
            // Homes
            // 
            Homes.Controls.Add(Command);
            Homes.Location = new Point(4, 29);
            Homes.Name = "Homes";
            Homes.Padding = new Padding(3);
            Homes.Size = new Size(768, 415);
            Homes.TabIndex = 2;
            Homes.UseVisualStyleBackColor = true;
            // 
            // Command
            // 
            Command.BackColor = Color.White;
            Command.BackgroundImageLayout = ImageLayout.Zoom;
            Command.Cursor = Cursors.Hand;
            Command.Location = new Point(334, 292);
            Command.Name = "Command";
            Command.Size = new Size(100, 100);
            Command.TabIndex = 21;
            Command.TabStop = false;
            // 
            // Logs
            // 
            Logs.Location = new Point(4, 29);
            Logs.Name = "Logs";
            Logs.Padding = new Padding(3);
            Logs.Size = new Size(768, 415);
            Logs.TabIndex = 3;
            Logs.UseVisualStyleBackColor = true;
            // 
            // Information
            // 
            Information.Controls.Add(EmailTitle);
            Information.Controls.Add(EmailLogo);
            Information.Controls.Add(TelegramTitle);
            Information.Controls.Add(TelegramLogo);
            Information.Controls.Add(GitHubTitle);
            Information.Controls.Add(GitHubLogo);
            Information.Controls.Add(YouTubeTitle);
            Information.Controls.Add(YouTubeLogo);
            Information.Controls.Add(WebsiteTitle);
            Information.Controls.Add(WebsiteLogo);
            Information.Controls.Add(License);
            Information.Location = new Point(4, 29);
            Information.Name = "Information";
            Information.Padding = new Padding(3);
            Information.Size = new Size(768, 415);
            Information.TabIndex = 4;
            Information.UseVisualStyleBackColor = true;
            // 
            // EmailTitle
            // 
            EmailTitle.Cursor = Cursors.Hand;
            EmailTitle.Font = new Font("Zain Black", 13.7999992F, FontStyle.Bold);
            EmailTitle.Location = new Point(76, 315);
            EmailTitle.Name = "EmailTitle";
            EmailTitle.Size = new Size(149, 64);
            EmailTitle.TabIndex = 30;
            EmailTitle.Text = "Email";
            EmailTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EmailLogo
            // 
            EmailLogo.BackColor = Color.White;
            EmailLogo.BackgroundImage = Properties.Bypass.email;
            EmailLogo.BackgroundImageLayout = ImageLayout.Zoom;
            EmailLogo.Cursor = Cursors.Hand;
            EmailLogo.Location = new Point(6, 315);
            EmailLogo.Name = "EmailLogo";
            EmailLogo.Size = new Size(64, 64);
            EmailLogo.TabIndex = 29;
            EmailLogo.TabStop = false;
            // 
            // TelegramTitle
            // 
            TelegramTitle.Cursor = Cursors.Hand;
            TelegramTitle.Font = new Font("Zain Black", 13.7999992F, FontStyle.Bold);
            TelegramTitle.Location = new Point(76, 245);
            TelegramTitle.Name = "TelegramTitle";
            TelegramTitle.Size = new Size(149, 64);
            TelegramTitle.TabIndex = 28;
            TelegramTitle.Text = "Telegram";
            TelegramTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TelegramLogo
            // 
            TelegramLogo.BackColor = Color.White;
            TelegramLogo.BackgroundImage = Properties.Bypass.telegram;
            TelegramLogo.BackgroundImageLayout = ImageLayout.Zoom;
            TelegramLogo.Cursor = Cursors.Hand;
            TelegramLogo.Location = new Point(6, 245);
            TelegramLogo.Name = "TelegramLogo";
            TelegramLogo.Size = new Size(64, 64);
            TelegramLogo.TabIndex = 27;
            TelegramLogo.TabStop = false;
            // 
            // GitHubTitle
            // 
            GitHubTitle.Cursor = Cursors.Hand;
            GitHubTitle.Font = new Font("Zain Black", 13.7999992F, FontStyle.Bold);
            GitHubTitle.Location = new Point(76, 175);
            GitHubTitle.Name = "GitHubTitle";
            GitHubTitle.Size = new Size(149, 64);
            GitHubTitle.TabIndex = 26;
            GitHubTitle.Text = "GitHub";
            GitHubTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GitHubLogo
            // 
            GitHubLogo.BackColor = Color.White;
            GitHubLogo.BackgroundImage = Properties.Bypass.github;
            GitHubLogo.BackgroundImageLayout = ImageLayout.Zoom;
            GitHubLogo.Cursor = Cursors.Hand;
            GitHubLogo.Location = new Point(6, 175);
            GitHubLogo.Name = "GitHubLogo";
            GitHubLogo.Size = new Size(64, 64);
            GitHubLogo.TabIndex = 25;
            GitHubLogo.TabStop = false;
            // 
            // YouTubeTitle
            // 
            YouTubeTitle.Cursor = Cursors.Hand;
            YouTubeTitle.Font = new Font("Zain Black", 13.7999992F, FontStyle.Bold);
            YouTubeTitle.Location = new Point(76, 105);
            YouTubeTitle.Name = "YouTubeTitle";
            YouTubeTitle.Size = new Size(149, 64);
            YouTubeTitle.TabIndex = 24;
            YouTubeTitle.Text = "YouTube";
            YouTubeTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // YouTubeLogo
            // 
            YouTubeLogo.BackColor = Color.White;
            YouTubeLogo.BackgroundImage = Properties.Bypass.youtube;
            YouTubeLogo.BackgroundImageLayout = ImageLayout.Zoom;
            YouTubeLogo.Cursor = Cursors.Hand;
            YouTubeLogo.Location = new Point(6, 105);
            YouTubeLogo.Name = "YouTubeLogo";
            YouTubeLogo.Size = new Size(64, 64);
            YouTubeLogo.TabIndex = 23;
            YouTubeLogo.TabStop = false;
            // 
            // WebsiteTitle
            // 
            WebsiteTitle.Cursor = Cursors.Hand;
            WebsiteTitle.Font = new Font("Zain Black", 13.7999992F, FontStyle.Bold);
            WebsiteTitle.Location = new Point(76, 35);
            WebsiteTitle.Name = "WebsiteTitle";
            WebsiteTitle.Size = new Size(149, 64);
            WebsiteTitle.TabIndex = 22;
            WebsiteTitle.Text = "Website";
            WebsiteTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // WebsiteLogo
            // 
            WebsiteLogo.BackColor = Color.White;
            WebsiteLogo.BackgroundImage = Properties.Bypass.website;
            WebsiteLogo.BackgroundImageLayout = ImageLayout.Zoom;
            WebsiteLogo.Cursor = Cursors.Hand;
            WebsiteLogo.Location = new Point(6, 35);
            WebsiteLogo.Name = "WebsiteLogo";
            WebsiteLogo.Size = new Size(64, 64);
            WebsiteLogo.TabIndex = 21;
            WebsiteLogo.TabStop = false;
            // 
            // License
            // 
            License.Font = new Font("Ebrima", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            License.Location = new Point(231, 6);
            License.Name = "License";
            License.Size = new Size(531, 403);
            License.TabIndex = 0;
            License.Text = resources.GetString("License.Text");
            // 
            // Log
            // 
            Log.BackColor = Color.White;
            Log.BackgroundImage = Properties.Bypass.log;
            Log.BackgroundImageLayout = ImageLayout.Zoom;
            Log.Cursor = Cursors.Hand;
            Log.Location = new Point(430, 537);
            Log.Name = "Log";
            Log.Size = new Size(50, 50);
            Log.TabIndex = 16;
            Log.TabStop = false;
            Log.Click += Log_Click;
            // 
            // Notification
            // 
            Notification.BackColor = Color.White;
            Notification.BackgroundImage = Properties.Bypass.notification;
            Notification.BackgroundImageLayout = ImageLayout.Zoom;
            Notification.Cursor = Cursors.Hand;
            Notification.Location = new Point(318, 537);
            Notification.Name = "Notification";
            Notification.Size = new Size(50, 50);
            Notification.TabIndex = 19;
            Notification.TabStop = false;
            Notification.Click += Notification_Click;
            // 
            // Info
            // 
            Info.BackColor = Color.White;
            Info.BackgroundImage = Properties.Bypass.info;
            Info.BackgroundImageLayout = ImageLayout.Zoom;
            Info.Cursor = Cursors.Hand;
            Info.Location = new Point(486, 537);
            Info.Name = "Info";
            Info.Size = new Size(50, 50);
            Info.TabIndex = 18;
            Info.TabStop = false;
            Info.Click += Info_Click;
            Info.MouseEnter += Info_MouseEnter;
            Info.MouseLeave += Info_MouseLeave;
            // 
            // Setting
            // 
            Setting.BackColor = Color.White;
            Setting.BackgroundImage = Properties.Bypass.setting;
            Setting.BackgroundImageLayout = ImageLayout.Zoom;
            Setting.Cursor = Cursors.Hand;
            Setting.Location = new Point(262, 537);
            Setting.Name = "Setting";
            Setting.Size = new Size(50, 50);
            Setting.TabIndex = 13;
            Setting.TabStop = false;
            Setting.Click += Setting_Click;
            // 
            // Home
            // 
            Home.BackColor = Color.White;
            Home.BackgroundImage = Properties.Bypass.home;
            Home.BackgroundImageLayout = ImageLayout.Zoom;
            Home.Cursor = Cursors.Hand;
            Home.Location = new Point(374, 537);
            Home.Name = "Home";
            Home.Size = new Size(50, 50);
            Home.TabIndex = 15;
            Home.TabStop = false;
            Home.Click += Start_Click;
            // 
            // Minimize
            // 
            Minimize.BackgroundImage = Properties.Bypass.minimize;
            Minimize.BackgroundImageLayout = ImageLayout.Zoom;
            Minimize.Cursor = Cursors.Hand;
            Minimize.Location = new Point(717, 11);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(32, 32);
            Minimize.TabIndex = 12;
            Minimize.TabStop = false;
            Minimize.Click += Minimize_Click;
            // 
            // Bypass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(BypassHolder);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Bypass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bypass";
            Load += Bypass_Load;
            ((System.ComponentModel.ISupportInitialize)Exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)AppLogo).EndInit();
            BypassHolder.ResumeLayout(false);
            AllTabs.ResumeLayout(false);
            Homes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Command).EndInit();
            Information.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EmailLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)TelegramLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)GitHubLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)YouTubeLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)WebsiteLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)Log).EndInit();
            ((System.ComponentModel.ISupportInitialize)Notification).EndInit();
            ((System.ComponentModel.ISupportInitialize)Info).EndInit();
            ((System.ComponentModel.ISupportInitialize)Setting).EndInit();
            ((System.ComponentModel.ISupportInitialize)Home).EndInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Exit;
        private Label AppTeam;
        private Label AppVersion;
        private Label AppName;
        private PictureBox AppLogo;
        private Panel BypassHolder;
        private PictureBox Minimize;
        private PictureBox Setting;
        private PictureBox Log;
        private PictureBox Home;
        private PictureBox Notification;
        private PictureBox Info;
        private TabControl AllTabs;
        private TabPage Settings;
        private TabPage Notifications;
        private TabPage Homes;
        private TabPage Logs;
        private TabPage Information;
        private RichTextBox License;
        private Label WebsiteTitle;
        private PictureBox WebsiteLogo;
        private Label YouTubeTitle;
        private PictureBox YouTubeLogo;
        private PictureBox GitHubLogo;
        private Label GitHubTitle;
        private Label TelegramTitle;
        private PictureBox TelegramLogo;
        private Label EmailTitle;
        private PictureBox EmailLogo;
        private PictureBox Command;
    }
}