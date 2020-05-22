using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace UCSY_Social
{
    public partial class Registraion : Form
    {
        UserDAO user_dao = new UserDAO();
        SessionDAO sess_dao = new SessionDAO();
        public Registraion()
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
                Main main = new Main();
                main.Show();
                this.Hide();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        /* end : escape key event */

        /* start : input label style */
        private void login_email_input_Enter(object sender, EventArgs e)
        {
            login_email_input.Focus();
            login_email_label.Location = new Point(50, 110);
            login_email_label.Font = new Font("Rubik", 8);
        }
        private void login_email_input_Leave(object sender, EventArgs e)
        {
            if(login_email_input.TextLength == 0)
            {
                login_email_label.Location = new Point(54, 124);
                login_email_label.Font = new Font("Rubik", 9);
            }
        }
        private void login_password_input_Enter(object sender, EventArgs e)
        {
            login_password_input.Focus();
            login_password_label.Location = new Point(50, 160);
            login_password_label.Font = new Font("Rubik", 8);
        }
        private void login_password_input_Leave(object sender, EventArgs e)
        {
            if (login_password_input.TextLength == 0)
            {
                login_password_label.Location = new Point(54, 174);
                login_password_label.Font = new Font("Rubik", 9);
            }
        }
        private void reg_name_input_Enter(object sender, EventArgs e)
        {
            reg_name_input.Focus();
            reg_name_label.Location = new Point(50, 100);
            reg_name_label.Font = new Font("Rubik", 8);
        }
        private void reg_name_input_Leave(object sender, EventArgs e)
        {
            if (reg_name_input.TextLength == 0)
            {
                reg_name_label.Location = new Point(54, 114);
                reg_name_label.Font = new Font("Rubik", 9);
            }
        }
        private void reg_email_input_Enter(object sender, EventArgs e)
        {
            reg_email_input.Focus();
            reg_email_label.Location = new Point(50, 150);
            reg_email_label.Font = new Font("Rubik", 8);
        }
        private void reg_email_input_Leave(object sender, EventArgs e)
        {
            if (reg_email_input.TextLength == 0)
            {
                reg_email_label.Location = new Point(54, 164);
                reg_email_label.Font = new Font("Rubik", 9);
            }
        }
        private void reg_password_input_Enter(object sender, EventArgs e)
        {
            reg_password_input.Focus();
            reg_password_label.Location = new Point(50, 200);
            reg_password_label.Font = new Font("Rubik", 8);
        }
        private void reg_password_input_Leave(object sender, EventArgs e)
        {
            if (reg_password_input.TextLength == 0)
            {
                reg_password_label.Location = new Point(54, 214);
                reg_password_label.Font = new Font("Rubik", 9);
            }
        }
        private void reg_confirm_input_Enter(object sender, EventArgs e)
        {
            reg_confirm_input.Focus();
            reg_confirm_label.Location = new Point(50, 250);
            reg_confirm_label.Font = new Font("Rubik", 8);
        }
        private void reg_confirm_input_Leave(object sender, EventArgs e)
        {
            if (reg_confirm_input.TextLength == 0)
            {
                reg_confirm_label.Location = new Point(54, 264);
                reg_confirm_label.Font = new Font("Rubik", 9);
            }
        }
        private void reg_link_Click(object sender, EventArgs e)
        {
            reg_panel_cover.Visible = false;
            login_panel_cover.Visible = true;
        }
        private void login_link_Click(object sender, EventArgs e)
        {
            reg_panel_cover.Visible = true;
            login_panel_cover.Visible = false;
        }
        private void forgot_link_Click(object sender, EventArgs e)
        {
            Forgot forgot = new Forgot();
            forgot.Show();
            this.Hide();
        }
        private void close_btn_Click(object sender, EventArgs e) 
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
        /* end : input label style */

        /* start : login validation */
        private void login_email_input_TextChanged(object sender, EventArgs e)
        {
            login_email_info.Text = "";
            login_status.Text = "";
        }
        private void login_password_input_TextChanged(object sender, EventArgs e)
        {
            login_password_info.Text = "";
            login_status.Text = "";
        }
        private void login_submit_Click(object sender, EventArgs e)
        {
            string input_email = login_email_input.Text.Replace(" ", "").ToLower(), 
                input_password = login_password_input.Text.Replace(" ", "").ToLower();
            Boolean login_flag = false;

            if (input_email.Length != 0 || input_password.Length != 0)
            {
                string password = user_dao.getPassword(input_email);
                if (password != "")
                {
                    if (password.Equals(input_password))
                    {
                        login_flag = true;
                    }
                    else
                    {
                        login_password_info.Text = "Incorrect Password!";
                        login_flag = false;
                    }
                }
                else
                {
                    login_email_info.Text = "Email doesn't Exist!";
                    login_email_input.Focus();
                }
            }
            else
            {
                login_status.Text = "Please Fill all the Fields To Continue!";
                login_email_input.Focus();
            }

            if (login_flag)
            {
                if(login_save_account.Checked == true)
                {
                    /* start : change session */
                    Session s = new Session("login", 1, 1, input_email);
                    sess_dao.update(s);
                    /* end : change session */
                }
                else
                {
                    /* start : change session */
                    Session s = new Session("login", 1, 0, input_email);
                    sess_dao.update(s);
                    /* end : change session */
                }
                Main main = new Main();
                main.Show();
                this.Hide();
            }
        }
        /* end : login validation */

        /* start : register validation */
        Boolean reg_name_flag = false, reg_email_flag = false, reg_password_flag = false;
        string[] reg_user = new string[3];
        Boolean save_session = false;
        private void reg_name_input_TextChanged(object sender, EventArgs e) 
        {
            string name = reg_name_input.Text;
            if (name.Length >= 3)
            {
                reg_name_info.Text = "";
                reg_name_flag = true;
                reg_user[0] = name;
            }else
            {
                reg_name_info.Text = "Required at least 3 Character!";
                reg_name_flag = false;
            }
        }
        private void reg_email_input_TextChanged(object sender, EventArgs e)
        {
            string input_email = reg_email_input.Text.Replace(" ", "").ToLower();
            string dao_email = user_dao.getEmail(input_email);
            string email_pattern = @"^[\w.+\-]+@ucsy\.edu\.mm$";

            if (input_email.Length >= 11)
            {
                if (dao_email != "")
                {
                    reg_email_info.Text = "Email Already Taken!";
                    reg_email_flag = false;
                }
                else if (!Regex.IsMatch(input_email, email_pattern))
                {
                    reg_email_info.Text = "Invalid Email Extension!";
                    reg_email_flag = false;
                }
                else
                {
                    reg_email_info.Text = "";
                    reg_user[1] = input_email;
                    reg_email_flag = true;
                }
            }
            else
            {
                reg_email_info.Text = "Invalid Email!";
                reg_email_flag = false;
            }
        }
        private void reg_password_input_TextChanged(object sender, EventArgs e)
        {
            if (reg_password_input.TextLength >= 8) 
                reg_password_info.Text = "";
            else
                reg_password_info.Text = "Required at least 8 Characters!";
        }
        private void Registraion_Load(object sender, EventArgs e)
        {
            login_email_input.Focus();
        }
        private void Registraion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void reg_confirm_input_TextChanged(object sender, EventArgs e)
        {
            string pass = reg_password_input.Text, conpass = reg_confirm_input.Text;
            if(conpass == pass)
            {
                reg_confirm_info.Text = "";
                reg_password_flag = true;
                reg_user[2] = conpass;
            }
            else
            {
                reg_confirm_info.Text = "Password do not Match!";
                reg_password_flag = false;
            }
        }
        private void reg_submit_Click(object sender, EventArgs e)
        {
            if (reg_save_session.Checked == true) save_session = true;
            if (reg_name_flag && reg_email_flag && reg_password_flag)
            {
                Setup setup = new Setup(reg_user, save_session);
                setup.Show();
                this.Hide();
                reg_status.Text = "";
            }
            else if (!reg_name_flag)
            {
                reg_name_info.Text = "Invalid UserName!";
                reg_name_input.Focus();
            }
            else if (!reg_email_flag)
            {
                reg_email_info.Text = "Invalid Email!";
                reg_email_input.Focus();
            }
            else if (!reg_password_flag)
            {
                reg_confirm_info.Text = "Invalid Password!";
                if (reg_password_input.TextLength < 8) reg_password_input.Focus();
                else reg_confirm_input.Focus();
            }
            else
            {
                reg_status.Text = "Invalid Request!";
            }
        }
        /* end : register validation */
    }
}