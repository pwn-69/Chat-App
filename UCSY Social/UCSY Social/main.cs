using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UCSY_Social
{
    public partial class Main : Form
    {
        SessionDAO sess_dao = new SessionDAO();
        public Main()
        {
            InitializeComponent();
        }

        /* start : add box-shadow */
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x00020000;
                return cp;
            }
        }
        /* end : add box-shadow */

        /* start : escape key event */
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                if (MessageBox.Show("Do You Want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Exit();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        /* end : escape key event */

        /* manipulate with user control */
        private void hideControl()
        {
            home1.Hide();
            feeds1.Hide();
            chat1.Hide();
            profile1.Hide();
            info1.Hide();
        }
        private void showControl(string name)
        {
            switch (name)
            {
                case "home":
                    title_window.Text = "UCSY Social - HOME";
                    home1.Show();
                    feeds1.Hide();
                    chat1.Hide();
                    profile1.Hide();
                    info1.Hide();
                    break;
                case "feeds":
                    title_window.Text = "UCSY Social - Feeds";
                    home1.Hide();
                    feeds1.Show();
                    chat1.Hide();
                    profile1.Hide();
                    info1.Hide();
                    break;
                case "chat":
                    title_window.Text = "UCSY Social - Chat";
                    home1.Hide();
                    feeds1.Hide();
                    chat1.Show();
                    profile1.Hide();
                    info1.Hide();
                    break;
                case "profile":
                    title_window.Text = "UCSY Social - Profile";
                    home1.Hide();
                    feeds1.Hide();
                    chat1.Hide();
                    profile1.Show();
                    info1.Hide();
                    break;
                case "info":
                    title_window.Text = "UCSY Social - Info";
                    home1.Hide();
                    feeds1.Hide();
                    chat1.Hide();
                    profile1.Hide();
                    info1.Show();
                    break;
            }
        }
        private void activeControl(string name)
        {
            switch (name)
            {
                case "home":
                    feeds_button.BackColor = Color.Transparent;
                    feeds_button_ascent.BackColor = Color.Transparent;
                    chat_button.BackColor = Color.Transparent;
                    chat_button_ascent.BackColor = Color.Transparent;
                    profile_button.BackColor = Color.Transparent;
                    profile_button_ascent.BackColor = Color.Transparent;
                    info_button.BackColor = Color.Transparent;
                    info_button_ascent.BackColor = Color.Transparent;
                    break;
                case "feeds":
                    home_button.BackColor = Color.Transparent;
                    home_button_ascent.BackColor = Color.Transparent;
                    chat_button.BackColor = Color.Transparent;
                    chat_button_ascent.BackColor = Color.Transparent;
                    profile_button.BackColor = Color.Transparent;
                    profile_button_ascent.BackColor = Color.Transparent;
                    info_button.BackColor = Color.Transparent;
                    info_button_ascent.BackColor = Color.Transparent;
                    break;
                case "chat":
                    home_button.BackColor = Color.Transparent;
                    home_button_ascent.BackColor = Color.Transparent;
                    feeds_button.BackColor = Color.Transparent;
                    feeds_button_ascent.BackColor = Color.Transparent;
                    profile_button.BackColor = Color.Transparent;
                    profile_button_ascent.BackColor = Color.Transparent;
                    info_button.BackColor = Color.Transparent;
                    info_button_ascent.BackColor = Color.Transparent;
                    break;
                case "profile":
                    home_button.BackColor = Color.Transparent;
                    home_button_ascent.BackColor = Color.Transparent;
                    feeds_button.BackColor = Color.Transparent;
                    feeds_button_ascent.BackColor = Color.Transparent;
                    chat_button.BackColor = Color.Transparent;
                    chat_button_ascent.BackColor = Color.Transparent;
                    info_button.BackColor = Color.Transparent;
                    info_button_ascent.BackColor = Color.Transparent;
                    break;
                case "info":
                    home_button.BackColor = Color.Transparent;
                    home_button_ascent.BackColor = Color.Transparent;
                    feeds_button.BackColor = Color.Transparent;
                    feeds_button_ascent.BackColor = Color.Transparent;
                    chat_button.BackColor = Color.Transparent;
                    chat_button_ascent.BackColor = Color.Transparent;
                    profile_button.BackColor = Color.Transparent;
                    profile_button_ascent.BackColor = Color.Transparent;
                    break;
            }
        }
        /* window panel events */
        private void window_panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                WindowState = FormWindowState.Minimized;
        }
        private void window_panel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WindowState == FormWindowState.Normal)
                    WindowState = FormWindowState.Maximized;
                else
                    WindowState = FormWindowState.Normal;
            }
        }
        private void window_panel_MouseLeave(object sender, EventArgs e)
        {
            this.window_panel.Cursor = Cursors.Arrow;
        }

        /* start : move borderless window */
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void window_panel_MouseDown(object sender, MouseEventArgs e)
        {
            this.window_panel.Cursor = Cursors.SizeAll;
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        /* end : move borderless window */

        /* window size button events */
        private void window_size_MouseEnter(object sender, EventArgs e)
        {
            window_size.BackColor = Color.FromArgb(141, 210, 138);
        }
        private void window_size_MouseLeave(object sender, EventArgs e)
        {
            window_size.BackColor = Color.Transparent;
        }
        private void window_size_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }
        /* window close button events */
        private void window_close_MouseEnter(object sender, EventArgs e)
        {
            window_close.BackColor = Color.Red;
        }
        private void window_close_MouseLeave(object sender, EventArgs e)
        {
            window_close.BackColor = Color.Transparent;
        }
        private void window_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /* form load method */

        /* menu button events */
        private void menu_button_MouseEnter(object sender, EventArgs e)
        {
            menu_button.BackColor = Color.FromArgb(255, 255, 255);
            menu_button_ascent.BackColor = Color.FromArgb(33, 150, 243);
        }
        private void menu_button_MouseLeave(object sender, EventArgs e)
        {
            menu_button.BackColor = Color.Transparent;
            menu_button_ascent.BackColor = Color.FromArgb(240, 240, 240);
        }
        private void menu_button_Click(object sender, EventArgs e)
        {
            if (nav_panel.Width == 50)
            {
                nav_panel.Width = 175;
                menu_button_ascent.Location = new Point(173, 5);
                home_button_ascent.Location = new Point(173, 5);
                feeds_button_ascent.Location = new Point(173, 5);
                chat_button_ascent.Location = new Point(173, 5);
                profile_button_ascent.Location = new Point(173, 5);
                info_button_ascent.Location = new Point(173, 5);
            }
            else if (nav_panel.Width == 175)
            {
                nav_panel.Width = 50;
                menu_button_ascent.Location = new Point(48, 5);
                home_button_ascent.Location = new Point(48, 5);
                feeds_button_ascent.Location = new Point(48, 5);
                chat_button_ascent.Location = new Point(48, 5);
                profile_button_ascent.Location = new Point(48, 5);
                info_button_ascent.Location = new Point(48, 5);
            }
        }
        /* home button events */
        private void home_button_MouseEnter(object sender, EventArgs e)
        {
            home_button.BackColor = Color.FromArgb(255, 255, 255);
            home_button_ascent.BackColor = Color.FromArgb(33, 150, 243);
        }
        private void home_button_MouseLeave(object sender, EventArgs e)
        {
            if (home1.Visible)
            {
                home_button.BackColor = Color.FromArgb(255, 255, 255);
                home_button_ascent.BackColor = Color.FromArgb(33, 150, 243);
            }
            else
            {
                home_button.BackColor = Color.Transparent;
                home_button_ascent.BackColor = Color.FromArgb(240, 240, 240);
            }
        }
        private void home_button_Click(object sender, EventArgs e)
        {
            showControl("home");
            activeControl("home");
        }
        /* feeds button events */
        private void feeds_button_MouseEnter(object sender, EventArgs e)
        {
            feeds_button.BackColor = Color.FromArgb(255, 255, 255);
            feeds_button_ascent.BackColor = Color.FromArgb(33, 150, 243);
        }
        private void feeds_button_MouseLeave(object sender, EventArgs e)
        {
            if (feeds1.Visible)
            {
                feeds_button.BackColor = Color.FromArgb(255, 255, 255);
                feeds_button_ascent.BackColor = Color.FromArgb(33, 150, 243);
            }
            else
            {
                feeds_button.BackColor = Color.Transparent;
                feeds_button_ascent.BackColor = Color.FromArgb(240, 240, 240);
            }
        }
        private void feeds_button_Click(object sender, EventArgs e)
        {
            showControl("feeds");
            activeControl("feeds");
        }
        /* chat button events */
        private void chat_button_MouseEnter(object sender, EventArgs e)
        {
            chat_button.BackColor = Color.FromArgb(255, 255, 255);
            chat_button_ascent.BackColor = Color.FromArgb(33, 150, 243);
        }
        private void chat_button_MouseLeave(object sender, EventArgs e)
        {
            if (chat1.Visible)
            {
                chat_button.BackColor = Color.FromArgb(255, 255, 255);
                chat_button_ascent.BackColor = Color.FromArgb(33, 150, 243);
            }
            else
            {
                chat_button.BackColor = Color.Transparent;
                chat_button_ascent.BackColor = Color.FromArgb(240, 240, 240);
            }
        }
        private void chat_button_Click(object sender, EventArgs e)
        {
            showControl("chat");
            activeControl("chat");
        }
        /* profile button events */
        private void profile_button_MouseEnter(object sender, EventArgs e)
        {
            profile_button.BackColor = Color.FromArgb(255, 255, 255);
            profile_button_ascent.BackColor = Color.FromArgb(33, 150, 243);
        }
        private void profile_button_MouseLeave(object sender, EventArgs e)
        {
            if (profile1.Visible)
            {
                profile_button.BackColor = Color.FromArgb(255, 255, 255);
                profile_button_ascent.BackColor = Color.FromArgb(33, 150, 243);
            }
            else
            {
                profile_button.BackColor = Color.Transparent;
                profile_button_ascent.BackColor = Color.FromArgb(240, 240, 240);
            }
        }
        private void profile_button_Click(object sender, EventArgs e)
        {
            showControl("profile");
            activeControl("profile");
        }
        /* info button events */
        private void info_button_MouseEnter(object sender, EventArgs e)
        {
            info_button.BackColor = Color.FromArgb(255, 255, 255);
            info_button_ascent.BackColor = Color.FromArgb(33, 150, 243);
        }
        private void info_button_MouseLeave(object sender, EventArgs e)
        {
            if (info1.Visible)
            {
                info_button.BackColor = Color.FromArgb(255, 255, 255);
                info_button_ascent.BackColor = Color.FromArgb(33, 150, 243);
            }
            else
            {
                info_button.BackColor = Color.Transparent;
                info_button_ascent.BackColor = Color.FromArgb(240, 240, 240);
            }
        }
        private void info_button_Click(object sender, EventArgs e)
        {
            showControl("info");
            activeControl("info");
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Session s = sess_dao.getSession("login");
            if (s.login_status.Equals(1) || s.save_login_status.Equals(1))
            {
                home_button.BackColor = Color.Transparent;
                home_button_ascent.BackColor = Color.Transparent;
                home_icon.Enabled = false;
                home_label.Enabled = false;
                home_button.Enabled = false;
                feeds_button.BackColor = Color.FromArgb(255, 255, 255);
                feeds_button_ascent.BackColor = Color.FromArgb(33, 150, 243);
                showControl("feeds");
                feeds_icon.Enabled = true;
                feeds_label.Enabled = true;
                feeds_button.Enabled = true;
                chat_icon.Enabled = true;
                chat_label.Enabled = true;
                chat_button.Enabled = true;
                profile_icon.Enabled = true;
                profile_label.Enabled = true;
                profile_button.Enabled = true;
            }
            else
            {
                home_button.BackColor = Color.FromArgb(255, 255, 255);
                home_button_ascent.BackColor = Color.FromArgb(33, 150, 243);
                feeds_icon.Enabled = false;
                feeds_label.Enabled = false;
                feeds_button.Enabled = false;
                chat_icon.Enabled = false;
                chat_label.Enabled = false;
                chat_button.Enabled = false;
                profile_icon.Enabled = false;
                profile_label.Enabled = false;
                profile_button.Enabled = false;
                hideControl();
                showControl("home");
            }
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session s = sess_dao.getSession("login");
            if (s.save_login_status.Equals(0)) sess_dao.clear();
        }
    }
}