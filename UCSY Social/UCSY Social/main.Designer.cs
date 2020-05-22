namespace UCSY_Social
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.window_panel = new System.Windows.Forms.Panel();
            this.title_window = new System.Windows.Forms.Label();
            this.window_size = new System.Windows.Forms.PictureBox();
            this.window_close = new System.Windows.Forms.PictureBox();
            this.nav_panel = new System.Windows.Forms.Panel();
            this.chat_button = new System.Windows.Forms.Panel();
            this.chat_button_ascent = new System.Windows.Forms.Panel();
            this.chat_label = new System.Windows.Forms.Label();
            this.chat_icon = new System.Windows.Forms.PictureBox();
            this.profile_button = new System.Windows.Forms.Panel();
            this.profile_button_ascent = new System.Windows.Forms.Panel();
            this.profile_label = new System.Windows.Forms.Label();
            this.profile_icon = new System.Windows.Forms.PictureBox();
            this.info_button = new System.Windows.Forms.Panel();
            this.info_button_ascent = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.feeds_button = new System.Windows.Forms.Panel();
            this.feeds_button_ascent = new System.Windows.Forms.Panel();
            this.feeds_label = new System.Windows.Forms.Label();
            this.feeds_icon = new System.Windows.Forms.PictureBox();
            this.home_button = new System.Windows.Forms.Panel();
            this.home_button_ascent = new System.Windows.Forms.Panel();
            this.home_label = new System.Windows.Forms.Label();
            this.home_icon = new System.Windows.Forms.PictureBox();
            this.menu_button = new System.Windows.Forms.Panel();
            this.menu_button_ascent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.main_panel = new System.Windows.Forms.Panel();
            this.home1 = new UCSY_Social.home();
            this.feeds1 = new UCSY_Social.Feeds();
            this.chat1 = new UCSY_Social.Chat();
            this.profile1 = new UCSY_Social.Profile();
            this.info1 = new UCSY_Social.Info();
            this.window_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.window_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_close)).BeginInit();
            this.nav_panel.SuspendLayout();
            this.chat_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chat_icon)).BeginInit();
            this.profile_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_icon)).BeginInit();
            this.info_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.feeds_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feeds_icon)).BeginInit();
            this.home_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_icon)).BeginInit();
            this.menu_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // window_panel
            // 
            this.window_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(123)))));
            this.window_panel.Controls.Add(this.title_window);
            this.window_panel.Controls.Add(this.window_size);
            this.window_panel.Controls.Add(this.window_close);
            this.window_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.window_panel.Location = new System.Drawing.Point(0, 0);
            this.window_panel.Name = "window_panel";
            this.window_panel.Size = new System.Drawing.Size(1024, 30);
            this.window_panel.TabIndex = 0;
            this.window_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.window_panel_MouseClick);
            this.window_panel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.window_panel_MouseDoubleClick);
            this.window_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.window_panel_MouseDown);
            this.window_panel.MouseLeave += new System.EventHandler(this.window_panel_MouseLeave);
            // 
            // title_window
            // 
            this.title_window.Font = new System.Drawing.Font("Oxanium Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_window.ForeColor = System.Drawing.Color.White;
            this.title_window.Location = new System.Drawing.Point(31, 0);
            this.title_window.Name = "title_window";
            this.title_window.Size = new System.Drawing.Size(200, 30);
            this.title_window.TabIndex = 2;
            this.title_window.Text = "UCSY Social";
            this.title_window.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title_window.MouseDown += new System.Windows.Forms.MouseEventHandler(this.window_panel_MouseDown);
            this.title_window.MouseLeave += new System.EventHandler(this.window_panel_MouseLeave);
            // 
            // window_size
            // 
            this.window_size.Cursor = System.Windows.Forms.Cursors.Hand;
            this.window_size.Image = ((System.Drawing.Image)(resources.GetObject("window_size.Image")));
            this.window_size.Location = new System.Drawing.Point(3, 3);
            this.window_size.Name = "window_size";
            this.window_size.Size = new System.Drawing.Size(24, 24);
            this.window_size.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.window_size.TabIndex = 1;
            this.window_size.TabStop = false;
            this.window_size.Click += new System.EventHandler(this.window_size_Click);
            this.window_size.MouseEnter += new System.EventHandler(this.window_size_MouseEnter);
            this.window_size.MouseLeave += new System.EventHandler(this.window_size_MouseLeave);
            // 
            // window_close
            // 
            this.window_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.window_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.window_close.Image = global::UCSY_Social.Properties.Resources.exit;
            this.window_close.Location = new System.Drawing.Point(997, 3);
            this.window_close.Name = "window_close";
            this.window_close.Size = new System.Drawing.Size(24, 24);
            this.window_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.window_close.TabIndex = 0;
            this.window_close.TabStop = false;
            this.window_close.Click += new System.EventHandler(this.window_close_Click);
            this.window_close.MouseEnter += new System.EventHandler(this.window_close_MouseEnter);
            this.window_close.MouseLeave += new System.EventHandler(this.window_close_MouseLeave);
            // 
            // nav_panel
            // 
            this.nav_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nav_panel.Controls.Add(this.chat_button);
            this.nav_panel.Controls.Add(this.profile_button);
            this.nav_panel.Controls.Add(this.info_button);
            this.nav_panel.Controls.Add(this.feeds_button);
            this.nav_panel.Controls.Add(this.home_button);
            this.nav_panel.Controls.Add(this.menu_button);
            this.nav_panel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nav_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.nav_panel.Location = new System.Drawing.Point(0, 30);
            this.nav_panel.Name = "nav_panel";
            this.nav_panel.Size = new System.Drawing.Size(50, 610);
            this.nav_panel.TabIndex = 1;
            // 
            // chat_button
            // 
            this.chat_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chat_button.Controls.Add(this.chat_button_ascent);
            this.chat_button.Controls.Add(this.chat_label);
            this.chat_button.Controls.Add(this.chat_icon);
            this.chat_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chat_button.Location = new System.Drawing.Point(0, 150);
            this.chat_button.Name = "chat_button";
            this.chat_button.Size = new System.Drawing.Size(50, 50);
            this.chat_button.TabIndex = 6;
            this.chat_button.Click += new System.EventHandler(this.chat_button_Click);
            this.chat_button.MouseEnter += new System.EventHandler(this.chat_button_MouseEnter);
            this.chat_button.MouseLeave += new System.EventHandler(this.chat_button_MouseLeave);
            // 
            // chat_button_ascent
            // 
            this.chat_button_ascent.Location = new System.Drawing.Point(48, 5);
            this.chat_button_ascent.Name = "chat_button_ascent";
            this.chat_button_ascent.Size = new System.Drawing.Size(3, 40);
            this.chat_button_ascent.TabIndex = 4;
            // 
            // chat_label
            // 
            this.chat_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chat_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chat_label.Font = new System.Drawing.Font("Oxanium SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chat_label.Location = new System.Drawing.Point(47, 10);
            this.chat_label.Name = "chat_label";
            this.chat_label.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.chat_label.Size = new System.Drawing.Size(0, 30);
            this.chat_label.TabIndex = 2;
            this.chat_label.Text = "Chats";
            this.chat_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chat_label.Click += new System.EventHandler(this.chat_button_Click);
            this.chat_label.MouseEnter += new System.EventHandler(this.chat_button_MouseEnter);
            this.chat_label.MouseLeave += new System.EventHandler(this.chat_button_MouseLeave);
            // 
            // chat_icon
            // 
            this.chat_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chat_icon.Image = global::UCSY_Social.Properties.Resources.chat;
            this.chat_icon.Location = new System.Drawing.Point(8, 8);
            this.chat_icon.Name = "chat_icon";
            this.chat_icon.Size = new System.Drawing.Size(34, 34);
            this.chat_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chat_icon.TabIndex = 1;
            this.chat_icon.TabStop = false;
            this.chat_icon.Click += new System.EventHandler(this.chat_button_Click);
            this.chat_icon.MouseEnter += new System.EventHandler(this.chat_button_MouseEnter);
            this.chat_icon.MouseLeave += new System.EventHandler(this.chat_button_MouseLeave);
            // 
            // profile_button
            // 
            this.profile_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profile_button.Controls.Add(this.profile_button_ascent);
            this.profile_button.Controls.Add(this.profile_label);
            this.profile_button.Controls.Add(this.profile_icon);
            this.profile_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile_button.Location = new System.Drawing.Point(0, 510);
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(50, 50);
            this.profile_button.TabIndex = 5;
            this.profile_button.Click += new System.EventHandler(this.profile_button_Click);
            this.profile_button.MouseEnter += new System.EventHandler(this.profile_button_MouseEnter);
            this.profile_button.MouseLeave += new System.EventHandler(this.profile_button_MouseLeave);
            // 
            // profile_button_ascent
            // 
            this.profile_button_ascent.Location = new System.Drawing.Point(48, 5);
            this.profile_button_ascent.Name = "profile_button_ascent";
            this.profile_button_ascent.Size = new System.Drawing.Size(3, 40);
            this.profile_button_ascent.TabIndex = 4;
            // 
            // profile_label
            // 
            this.profile_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.profile_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile_label.Font = new System.Drawing.Font("Oxanium SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_label.Location = new System.Drawing.Point(47, 10);
            this.profile_label.Name = "profile_label";
            this.profile_label.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.profile_label.Size = new System.Drawing.Size(0, 30);
            this.profile_label.TabIndex = 2;
            this.profile_label.Text = "Profile";
            this.profile_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.profile_label.Click += new System.EventHandler(this.profile_button_Click);
            this.profile_label.MouseEnter += new System.EventHandler(this.profile_button_MouseEnter);
            this.profile_label.MouseLeave += new System.EventHandler(this.profile_button_MouseLeave);
            // 
            // profile_icon
            // 
            this.profile_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile_icon.Image = global::UCSY_Social.Properties.Resources.profile;
            this.profile_icon.Location = new System.Drawing.Point(8, 8);
            this.profile_icon.Name = "profile_icon";
            this.profile_icon.Size = new System.Drawing.Size(34, 34);
            this.profile_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile_icon.TabIndex = 1;
            this.profile_icon.TabStop = false;
            this.profile_icon.Click += new System.EventHandler(this.profile_button_Click);
            this.profile_icon.MouseEnter += new System.EventHandler(this.profile_button_MouseEnter);
            this.profile_icon.MouseLeave += new System.EventHandler(this.profile_button_MouseLeave);
            // 
            // info_button
            // 
            this.info_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.info_button.Controls.Add(this.info_button_ascent);
            this.info_button.Controls.Add(this.label4);
            this.info_button.Controls.Add(this.pictureBox6);
            this.info_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info_button.Location = new System.Drawing.Point(0, 560);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(50, 50);
            this.info_button.TabIndex = 5;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            this.info_button.MouseEnter += new System.EventHandler(this.info_button_MouseEnter);
            this.info_button.MouseLeave += new System.EventHandler(this.info_button_MouseLeave);
            // 
            // info_button_ascent
            // 
            this.info_button_ascent.Location = new System.Drawing.Point(48, 5);
            this.info_button_ascent.Name = "info_button_ascent";
            this.info_button_ascent.Size = new System.Drawing.Size(3, 40);
            this.info_button_ascent.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Oxanium SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 10);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label4.Size = new System.Drawing.Size(0, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Infos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.info_button_Click);
            this.label4.MouseEnter += new System.EventHandler(this.info_button_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.info_button_MouseLeave);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::UCSY_Social.Properties.Resources.info;
            this.pictureBox6.Location = new System.Drawing.Point(8, 8);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 34);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.info_button_Click);
            this.pictureBox6.MouseEnter += new System.EventHandler(this.info_button_MouseEnter);
            this.pictureBox6.MouseLeave += new System.EventHandler(this.info_button_MouseLeave);
            // 
            // feeds_button
            // 
            this.feeds_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.feeds_button.Controls.Add(this.feeds_button_ascent);
            this.feeds_button.Controls.Add(this.feeds_label);
            this.feeds_button.Controls.Add(this.feeds_icon);
            this.feeds_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.feeds_button.Location = new System.Drawing.Point(0, 100);
            this.feeds_button.Name = "feeds_button";
            this.feeds_button.Size = new System.Drawing.Size(50, 50);
            this.feeds_button.TabIndex = 4;
            this.feeds_button.Click += new System.EventHandler(this.feeds_button_Click);
            this.feeds_button.MouseEnter += new System.EventHandler(this.feeds_button_MouseEnter);
            this.feeds_button.MouseLeave += new System.EventHandler(this.feeds_button_MouseLeave);
            // 
            // feeds_button_ascent
            // 
            this.feeds_button_ascent.Location = new System.Drawing.Point(48, 5);
            this.feeds_button_ascent.Name = "feeds_button_ascent";
            this.feeds_button_ascent.Size = new System.Drawing.Size(3, 40);
            this.feeds_button_ascent.TabIndex = 4;
            // 
            // feeds_label
            // 
            this.feeds_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.feeds_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.feeds_label.Font = new System.Drawing.Font("Oxanium SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeds_label.Location = new System.Drawing.Point(47, 10);
            this.feeds_label.Name = "feeds_label";
            this.feeds_label.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.feeds_label.Size = new System.Drawing.Size(0, 30);
            this.feeds_label.TabIndex = 2;
            this.feeds_label.Text = "Feeds";
            this.feeds_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.feeds_label.Click += new System.EventHandler(this.feeds_button_Click);
            this.feeds_label.MouseEnter += new System.EventHandler(this.feeds_button_MouseEnter);
            this.feeds_label.MouseLeave += new System.EventHandler(this.feeds_button_MouseLeave);
            // 
            // feeds_icon
            // 
            this.feeds_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.feeds_icon.Image = global::UCSY_Social.Properties.Resources.news;
            this.feeds_icon.Location = new System.Drawing.Point(8, 8);
            this.feeds_icon.Name = "feeds_icon";
            this.feeds_icon.Size = new System.Drawing.Size(34, 34);
            this.feeds_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.feeds_icon.TabIndex = 1;
            this.feeds_icon.TabStop = false;
            this.feeds_icon.Click += new System.EventHandler(this.feeds_button_Click);
            this.feeds_icon.MouseEnter += new System.EventHandler(this.feeds_button_MouseEnter);
            this.feeds_icon.MouseLeave += new System.EventHandler(this.feeds_button_MouseLeave);
            // 
            // home_button
            // 
            this.home_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.home_button.Controls.Add(this.home_button_ascent);
            this.home_button.Controls.Add(this.home_label);
            this.home_button.Controls.Add(this.home_icon);
            this.home_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_button.Location = new System.Drawing.Point(0, 50);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(50, 50);
            this.home_button.TabIndex = 3;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            this.home_button.MouseEnter += new System.EventHandler(this.home_button_MouseEnter);
            this.home_button.MouseLeave += new System.EventHandler(this.home_button_MouseLeave);
            // 
            // home_button_ascent
            // 
            this.home_button_ascent.Location = new System.Drawing.Point(48, 5);
            this.home_button_ascent.Name = "home_button_ascent";
            this.home_button_ascent.Size = new System.Drawing.Size(3, 40);
            this.home_button_ascent.TabIndex = 4;
            // 
            // home_label
            // 
            this.home_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.home_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_label.Font = new System.Drawing.Font("Oxanium SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_label.Location = new System.Drawing.Point(47, 10);
            this.home_label.Name = "home_label";
            this.home_label.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.home_label.Size = new System.Drawing.Size(0, 30);
            this.home_label.TabIndex = 2;
            this.home_label.Text = "HOME";
            this.home_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.home_label.Click += new System.EventHandler(this.home_button_Click);
            this.home_label.MouseEnter += new System.EventHandler(this.home_button_MouseEnter);
            this.home_label.MouseLeave += new System.EventHandler(this.home_button_MouseLeave);
            // 
            // home_icon
            // 
            this.home_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_icon.Image = global::UCSY_Social.Properties.Resources.home;
            this.home_icon.Location = new System.Drawing.Point(8, 8);
            this.home_icon.Name = "home_icon";
            this.home_icon.Size = new System.Drawing.Size(34, 34);
            this.home_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.home_icon.TabIndex = 1;
            this.home_icon.TabStop = false;
            this.home_icon.Click += new System.EventHandler(this.home_button_Click);
            this.home_icon.MouseEnter += new System.EventHandler(this.home_button_MouseEnter);
            this.home_icon.MouseLeave += new System.EventHandler(this.home_button_MouseLeave);
            // 
            // menu_button
            // 
            this.menu_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu_button.Controls.Add(this.menu_button_ascent);
            this.menu_button.Controls.Add(this.label1);
            this.menu_button.Controls.Add(this.pictureBox3);
            this.menu_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_button.Location = new System.Drawing.Point(0, 0);
            this.menu_button.Name = "menu_button";
            this.menu_button.Size = new System.Drawing.Size(50, 50);
            this.menu_button.TabIndex = 0;
            this.menu_button.Click += new System.EventHandler(this.menu_button_Click);
            this.menu_button.MouseEnter += new System.EventHandler(this.menu_button_MouseEnter);
            this.menu_button.MouseLeave += new System.EventHandler(this.menu_button_MouseLeave);
            // 
            // menu_button_ascent
            // 
            this.menu_button_ascent.Location = new System.Drawing.Point(48, 5);
            this.menu_button_ascent.Name = "menu_button_ascent";
            this.menu_button_ascent.Size = new System.Drawing.Size(3, 40);
            this.menu_button_ascent.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Oxanium SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "MENU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.menu_button_Click);
            this.label1.MouseEnter += new System.EventHandler(this.menu_button_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.menu_button_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::UCSY_Social.Properties.Resources.menu;
            this.pictureBox3.Location = new System.Drawing.Point(10, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.menu_button_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.menu_button_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.menu_button_MouseLeave);
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Controls.Add(this.home1);
            this.main_panel.Controls.Add(this.feeds1);
            this.main_panel.Controls.Add(this.chat1);
            this.main_panel.Controls.Add(this.profile1);
            this.main_panel.Controls.Add(this.info1);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(50, 30);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(974, 610);
            this.main_panel.TabIndex = 2;
            // 
            // home1
            // 
            this.home1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home1.BackgroundImage")));
            this.home1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(974, 610);
            this.home1.TabIndex = 4;
            // 
            // feeds1
            // 
            this.feeds1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("feeds1.BackgroundImage")));
            this.feeds1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.feeds1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feeds1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeds1.Location = new System.Drawing.Point(0, 0);
            this.feeds1.Name = "feeds1";
            this.feeds1.Size = new System.Drawing.Size(974, 610);
            this.feeds1.TabIndex = 3;
            // 
            // chat1
            // 
            this.chat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.chat1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chat1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chat1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chat1.Location = new System.Drawing.Point(0, 0);
            this.chat1.Name = "chat1";
            this.chat1.Size = new System.Drawing.Size(974, 610);
            this.chat1.TabIndex = 2;
            // 
            // profile1
            // 
            this.profile1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profile1.BackgroundImage")));
            this.profile1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profile1.Font = new System.Drawing.Font("Roboto Mono", 9F);
            this.profile1.Location = new System.Drawing.Point(0, 0);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(974, 610);
            this.profile1.TabIndex = 1;
            // 
            // info1
            // 
            this.info1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("info1.BackgroundImage")));
            this.info1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.info1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info1.Location = new System.Drawing.Point(0, 0);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(974, 610);
            this.info1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.nav_panel);
            this.Controls.Add(this.window_panel);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 640);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UCSY Social";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.window_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.window_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_close)).EndInit();
            this.nav_panel.ResumeLayout(false);
            this.chat_button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chat_icon)).EndInit();
            this.profile_button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profile_icon)).EndInit();
            this.info_button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.feeds_button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.feeds_icon)).EndInit();
            this.home_button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.home_icon)).EndInit();
            this.menu_button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.main_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel window_panel;
        private System.Windows.Forms.Panel nav_panel;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.PictureBox window_close;
        private System.Windows.Forms.PictureBox window_size;
        private System.Windows.Forms.Panel menu_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel profile_button;
        private System.Windows.Forms.Label profile_label;
        private System.Windows.Forms.PictureBox profile_icon;
        private System.Windows.Forms.Panel info_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel feeds_button;
        private System.Windows.Forms.Label feeds_label;
        private System.Windows.Forms.PictureBox feeds_icon;
        private System.Windows.Forms.Panel home_button;
        private System.Windows.Forms.Label home_label;
        private System.Windows.Forms.PictureBox home_icon;
        private System.Windows.Forms.Panel chat_button;
        private System.Windows.Forms.Label chat_label;
        private System.Windows.Forms.PictureBox chat_icon;
        private System.Windows.Forms.Panel menu_button_ascent;
        private System.Windows.Forms.Panel home_button_ascent;
        private System.Windows.Forms.Panel chat_button_ascent;
        private System.Windows.Forms.Panel feeds_button_ascent;
        private System.Windows.Forms.Panel profile_button_ascent;
        private System.Windows.Forms.Panel info_button_ascent;
        private System.Windows.Forms.Label title_window;
        private home home1;
        private Feeds feeds1;
        private Chat chat1;
        private Profile profile1;
        private Info info1;
    }
}

