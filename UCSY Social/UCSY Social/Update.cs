using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace UCSY_Social
{
    public partial class Update : Form
    {
        UserDAO user_dao = new UserDAO();
        SessionDAO sess_dao = new SessionDAO();
        string[] user;
        string from = "";
        public Update(string[] user, string from)
        {
            InitializeComponent();
            this.user = user;
            this.from = from;
        }

        /* start : add box-shadow */
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private bool m_aeroEnabled;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        /* end : add box-shadow */

        /* start : escape key event */
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                if (from.Equals("profile"))
                {
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                }
                else if (from.Equals("forgot"))
                {
                    Forgot forgot = new Forgot();
                    forgot.Show();
                    this.Hide();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        /* end : escape key event */
        private void input_name_Enter(object sender, EventArgs e)
        {
            input_name.Focus();
            label_name.Location = new Point(34, 83);
            label_name.Font = new Font("Rubik", 8);
        }
        private void input_name_Leave(object sender, EventArgs e)
        {
            if (input_name.TextLength == 0)
            {
                label_name.Location = new Point(38, 99);
                label_name.Font = new Font("Rubik", 9);
            }
        }
        private void input_bio_Enter(object sender, EventArgs e)
        {
            input_bio.Focus();
            label_bio.Location = new Point(34, 183);
            label_bio.Font = new Font("Rubik", 8);
        }
        private void input_bio_Leave(object sender, EventArgs e)
        {
            if(input_bio.TextLength == 0)
            {
                label_bio.Location = new Point(38, 199);
                label_bio.Font = new Font("Rubik", 9);
            }
        }
        private void input_password_Enter(object sender, EventArgs e)
        {
            input_password.Focus();
            label_password.Location = new Point(34, 233);
            label_password.Font = new Font("Rubik", 8);
        }
        private void input_password_Leave(object sender, EventArgs e)
        {
            if(input_password.TextLength == 0)
            {
                label_password.Location = new Point(38, 249);
                label_password.Font = new Font("Rubik", 9);
            }
        }
        private void Update_Load(object sender, EventArgs e)
        {
            label_name.Location = new Point(34, 83);
            input_name.Text = user[0];
            input_email.Text = user[1];
            label_bio.Location = new Point(34, 183);
            input_bio.Text = user[3];
            label_password.Location = new Point(34, 233);
            input_password.Text = user[2];
        }
        private void input_name_TextChanged(object sender, EventArgs e)
        {
            if(input_name.TextLength > 1)
            {
                name_info.Text = "";
            }
        }
        private void input_bio_TextChanged(object sender, EventArgs e)
        {
            if(input_bio.TextLength > 1)
            {
                bio_info.Text = "";
            }
        }
        private void input_password_TextChanged(object sender, EventArgs e)
        {
            if(input_password.TextLength > 5)
            {
                password_info.Text = "";
            }
        }
        private void submit_btn_Click(object sender, EventArgs e)
        {
            string name = input_name.Text, email = input_email.Text, pass = input_password.Text, bio = input_bio.Text;
            if (name.Length >= 3 && pass.Length > 7 && bio.Length != 0)
            {
                User u = new User(name, email, pass, bio);
                user_dao.update(u);

                if (from.Equals("profile")) 
                {
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                }
                else if (from.Equals("forgot"))
                {
                    Registraion registraion = new Registraion();
                    registraion.Show();
                    this.Hide();
                }
            }
            else if (name.Length < 3)
                name_info.Text = "Required at least 3 Characters!";
            else if (bio.Length == 0)
                bio_info.Text = "Required!";
            else if (pass.Length < 8)
                password_info.Text = "Required at least 8 Characters!";
        }
        /* end : dropping shadow around window */
    }
}