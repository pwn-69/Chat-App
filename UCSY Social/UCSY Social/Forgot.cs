using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace UCSY_Social
{
    public partial class Forgot : Form
    {
        UserDAO user_dao = new UserDAO();
        public Forgot()
        {
            InitializeComponent();
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
                Registraion registraion = new Registraion();
                registraion.Show();
                this.Hide();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        /* start : escape key event */

        private void q1_input_Enter(object sender, EventArgs e)
        {
            q1_input.Focus();
            q1_label.Location = new Point(34, 83);
            q1_label.Font = new Font("Rubik", 8);
        }
        private void q1_input_Leave(object sender, EventArgs e)
        {
            if (q1_input.TextLength == 0)
            {
                q1_label.Location = new Point(38, 99);
                q1_label.Font = new Font("Rubik", 9);
            }
        }
        private void q2_input_Enter(object sender, EventArgs e)
        {
            q2_input.Focus();
            q2_label.Location = new Point(34, 133);
            q2_label.Font = new Font("Rubik", 9);
        }
        private void q2_input_Leave(object sender, EventArgs e)
        {
            if (q2_input.TextLength == 0)
            {
                q2_label.Location = new Point(38, 149);
                q2_label.Font = new Font("Rubik", 9);
            }
        }
        private void q3_input_Enter(object sender, EventArgs e)
        {
            q3_input.Focus();
            q3_label.Location = new Point(34, 183);
            q3_label.Font = new Font("Rubik", 8);
        }
        private void q3_input_Leave(object sender, EventArgs e)
        {
            if (q3_input.TextLength == 0)
            {
                q3_label.Location = new Point(38, 199);
                q3_label.Font = new Font("Rubik", 9);
            }
        }
        private void email_input_Enter(object sender, EventArgs e)
        {
            email_input.Focus();
            email_label.Location = new Point(34, 233);
            email_label.Font = new Font("Rubik", 8);
        }
        private void email_input_Leave(object sender, EventArgs e)
        {
            if (email_input.TextLength == 0)
            {
                email_label.Location = new Point(38, 249);
                email_label.Font = new Font("Rubik", 9);
            }
        }
        private void q1_input_TextChanged(object sender, EventArgs e)
        {
            q1_info.Text = "";
        }
        private void q2_input_TextChanged(object sender, EventArgs e)
        {
            q2_info.Text = "";
        }
        private void q3_input_TextChanged(object sender, EventArgs e)
        {
            q3_info.Text = "";
        }
        private void email_input_TextChanged(object sender, EventArgs e)
        {
            email_info.Text = "";
        }
        string[] user = new string[4];
        private void submit_Click(object sender, EventArgs e)
        {
            string q1 = q1_input.Text.Replace(" ", "").ToLower(), q2 = q2_input.Text.Replace(" ", "").ToLower(), 
                q3 = q3_input.Text.Replace(" ", "").ToLower(), email = email_input.Text.Replace(" ", "").ToLower();
            if (q1.Length != 0 && q2.Length != 0 && q3.Length != 0 && email.Length != 0)
            {
                User u = user_dao.getUser(email);

                if (u != null)
                {
                    string sq1 = u.one, sq2 = u.two, sq3 = u.three;
                    user[0] = u.name; user[1] = u.email; user[2] = u.password; user[3] = u.bio;

                    if (q1.Equals(sq1) && q2.Equals(sq2) && q3.Equals(sq3))
                    {
                        Update update = new Update(user, "forgot");
                        update.Show();
                        this.Hide();
                    }
                    else if (!q1.Equals(sq1))
                        q1_info.Text = "Incorrect Input Data!";
                    else if (!q2.Equals(sq2))
                        q2_info.Text = "Incorrect Input Data!";
                    else if (!q3.Equals(sq3))
                        q3_info.Text = "Incorrect Input Data!";
                }
                else
                {
                    email_info.Text = "Email doesn't Exit!";
                }
            }
            else if (q1.Length == 0)
                q1_info.Text = "Required";
            else if (q2.Length == 0)
                q2_info.Text = "Required";
            else if (q3.Length == 0)
                q3_info.Text = "Required";
            else if (email.Length == 0)
                email_info.Text = "Required";
        }
    }
}