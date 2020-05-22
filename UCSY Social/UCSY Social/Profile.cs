using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCSY_Social
{
    public partial class Profile : UserControl
    {
        UserDAO user_dao = new UserDAO();
        SessionDAO sess_dao = new SessionDAO();
        public Profile()
        {
            InitializeComponent();
        }
        private void user_update_button_MouseEnter(object sender, EventArgs e)
        {
            user_update_button.BackColor = Color.WhiteSmoke;
            user_update_button_ascent.BackColor = Color.FromArgb(33, 150, 243);
        }
        private void user_update_button_MouseLeave(object sender, EventArgs e)
        {
            user_update_button.BackColor = Color.FromArgb(240, 240, 240);
            user_update_button_ascent.BackColor = Color.Transparent;
        }
        private void user_delete_button_MouseEnter(object sender, EventArgs e)
        {
            user_delete_button.BackColor = Color.WhiteSmoke;
            user_delete_button_ascent.BackColor = Color.FromArgb(33, 150, 243);
        }
        private void user_delete_button_MouseLeave(object sender, EventArgs e)
        {
            user_delete_button.BackColor = Color.FromArgb(240, 240, 240);
            user_delete_button_ascent.BackColor = Color.Transparent;
        }
        private void user_signout_button_MouseEnter(object sender, EventArgs e)
        {
            user_signout_button.BackColor = Color.WhiteSmoke;
            user_signout_button_ascent.BackColor = Color.FromArgb(33, 150, 243);
        }
        private void user_signout_button_MouseLeave(object sender, EventArgs e)
        {
            user_signout_button.BackColor = Color.FromArgb(240, 240, 240);
            user_signout_button_ascent.BackColor = Color.Transparent;
        }        
        string[] login_user = new string[4];
        private void Profile_Load(object sender, EventArgs e)
        {
            Session s = sess_dao.getSession("login");
            if (s.login_status.Equals(1) || s.save_login_status.Equals(1))
            {
                User u = user_dao.getUser(s.login_email);
                if (u != null)
                {
                    label_user_bio.Text = u.bio;
                    label_user_name.Text += u.name;
                    label_user_email.Text += u.email;
                    label_user_gender.Text += u.gender;
                    label_user_dob.Text += u.dob.ToString().Substring(0, u.dob.ToString().IndexOf(" "));
                    login_user[0] = u.name;
                    login_user[1] = u.email;
                    login_user[2] = u.password;
                    login_user[3] = u.bio;
                }
            }
        }
        private void user_update_button_Click(object sender, EventArgs e)
        {
            this.ParentForm.Hide();
            Update update = new Update(login_user, "profile");
            update.Show();
        }
        private void user_delete_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want to Delete Your Account?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                user_dao.delete(login_user[1]);
                sess_dao.clear();
                this.ParentForm.Hide();
                Registraion registraion = new Registraion();
                registraion.Show();
            }
        }
        private void user_signout_button_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do You Want to Sign Out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sess_dao.clear();
                this.ParentForm.Hide();
                Registraion registraion = new Registraion();
                registraion.Show();
            }
        }
    }
}