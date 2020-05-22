using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace UCSY_Social
{
    public partial class Setup : Form
    {
        UserDAO user_dao = new UserDAO();
        SessionDAO sess_dao = new SessionDAO();
        public string[] reg_user;
        Boolean reg_save_session;
        public Setup(string[] arr, Boolean session)
        {
            InitializeComponent();
            this.reg_user = arr;
            this.reg_save_session = session;
        }

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
        /* end : escape key event */

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

        /* start : input label */
        private void reg_bio_input_Enter(object sender, EventArgs e)
        {
            reg_bio_input.Focus();
            reg_bio_label.Location = new Point(5, 120);
            reg_bio_label.Font = new Font("Rubik", 8);
        }
        private void reg_bio_input_Leave(object sender, EventArgs e)
        {
            if(reg_bio_input.TextLength == 0)
            {
                reg_bio_label.Location = new Point(9, 134);
                reg_bio_label.Font = new Font("Rubik", 9);
            }
        }
        private void sq_one_input_Enter(object sender, EventArgs e)
        {
            sq_one_input.Focus();
            sq_one_label.Location = new Point(5, 20);
            sq_one_label.Font = new Font("Rubik", 8);
        }
        private void sq_one_input_Leave(object sender, EventArgs e)
        {
            if (sq_one_input.TextLength == 0)
            {
                sq_one_label.Location = new Point(9, 34);
                sq_one_label.Font = new Font("Rubik", 9);
            }
        }
        private void sq_two_input_Enter(object sender, EventArgs e)
        {
            sq_two_input.Focus();
            sq_two_label.Location = new Point(5, 70);
            sq_two_label.Font = new Font("Rubik", 8);
        }
        private void sq_two_input_Leave(object sender, EventArgs e)
        {
            if (sq_two_input.TextLength == 0)
            {
                sq_two_label.Location = new Point(9, 84);
                sq_two_label.Font = new Font("Rubik", 9);
            }
        }
        private void sq_three_input_Enter(object sender, EventArgs e)
        {
            sq_three_input.Focus();
            sq_three_label.Location = new Point(5, 120);
            sq_three_label.Font = new Font("Rubik", 8);
        }
        private void sq_three_input_Leave(object sender, EventArgs e)
        {
            if (sq_three_input.TextLength == 0)
            {
                sq_three_label.Location = new Point(9, 134);
                sq_three_label.Font = new Font("Rubik", 9);
            }
        }
        /* end : input label */

        private void Setup_Load(object sender, EventArgs e) => reg_date_input.Focus();
        private void Setup_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void back_btn_Click(object sender, EventArgs e)
        {
            Registraion reg = new Registraion();
            reg.Show();
            this.Hide();
        }
        private void setup_submit_Click(object sender, EventArgs e) 
        {
            string gender, bio = reg_bio_input.Text, one = sq_one_input.Text.Replace(" ","").ToLower(), 
                two = sq_two_input.Text.Replace(" ", "").ToLower(), three = sq_three_input.Text.Replace(" ", "").ToLower();
            DateTime dob = reg_date_input.Value.Date;
            if (reg_gender_male.Checked == true)
                gender = "Male";
            else if (reg_gender_female.Checked == true)
                gender = "Female";
            else
                gender = "";

            if(gender.Length != 0 && bio.Length != 0 && one.Length != 0 && two.Length != 0 && three.Length != 0)
            {
                setup_stats.Text = "";
                User u = new User(reg_user[0], reg_user[1], reg_user[2], gender, dob, bio, one, two, three);
                user_dao.save(u);

                if (reg_save_session)
                {
                    /* start : change session */
                    Session s = new Session("login", 1, 1, reg_user[1]);
                    sess_dao.update(s);
                    /* end : change session */
                }
                else
                {
                    /* start : change temp session */
                    Session s = new Session("login", 1, 0, reg_user[1]);
                    sess_dao.update(s);
                    /* end : change temp session */
                }
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                setup_stats.Text = "Fill all the Fields!";
            }
        }
    }
}