using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UCSY_Social
{
    public partial class Chat : UserControl
    {
        public Chat()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Chat_Load);
        }

        Boolean public_chatting_flag = false;
        SessionDAO sess_dao = new SessionDAO();
        UserDAO user_dao = new UserDAO();
        Connection app_class = new Connection();
        private string constr = "";
        string user_name = "", user_email = "";
        private void sync_data(string login_email)
        {
            user_email = login_email;
            SqlConnection cn = new SqlConnection(constr);
            cn.Open();
            string query = "select user_name,user_email,user_bio from USERS";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            cn.Close();
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                string name = row["user_name"].ToString();
                string email = row["user_email"].ToString();
                string bio = row["user_bio"].ToString();
                if (email == user_email)
                    user_name = name;
                if (name != user_name && email != user_email)
                    create_btn(name, email,bio);
                //else
                    //per_chat.ActiveForm.Text = "Logged in as " + stu_name;
            }
        }
        private void create_btn_pchat()
        {
            Button newbtn = new Button();
            newbtn.Text = "Public Chat";
            newbtn.Location = new Point(0, 0);
            newbtn.Size = new Size(174, 30);
            newbtn.Anchor = AnchorStyles.Top;
            newbtn.Anchor = AnchorStyles.Right;
            newbtn.Anchor = AnchorStyles.Left;
            newbtn.Name = "btn_pchat";
            newbtn.FlatStyle = FlatStyle.Flat;
            newbtn.BackColor = Color.FromArgb(55, 74, 113);
            newbtn.ForeColor = Color.WhiteSmoke;
            newbtn.Cursor = Cursors.Hand;
            newbtn.Font = new Font("Oxanium SemiBold", newbtn.Font.Size);
            newbtn.Click += delegate
            {
                hidden_email.Text = "";
                   public_chatting_flag = true;
                public_chatting();
            };
            flowLayoutPanel1.Controls.Add(newbtn);
        }

        private void public_chatting()
        {
            SqlConnection cn = new SqlConnection(constr);
            cn.Open();
            SqlDataAdapter da = null;
            string query = "SELECT Conversation FROM CHATBOX";
            da = new SqlDataAdapter(query, cn);
            cn.Close();

            if (da != null)
            {
                try
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataTable dt = ds.Tables[0];

                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dt;
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                    dataGridView1.Columns["Conversation"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dataGridView1.Columns["Conversation"].DefaultCellStyle.Font = new Font("Rubik", 9);
                    dataGridView1.Columns["Conversation"].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    label20.Text = "Public Conversation";
                    bio.Text = " - - - - - - - ";

                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["Conversation"].ToString().StartsWith(user_name))
                        {
                            user_msg(dt.Rows.IndexOf(row), user_name);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        private void create_btn(string btn_name, string email,string bio)
        {            
            Button newbtn = new Button();                      
            newbtn.Text = btn_name;
            newbtn.Size = new Size(174, 30);
            newbtn.Anchor = AnchorStyles.Top;
            newbtn.Anchor = AnchorStyles.Right;
            newbtn.Anchor = AnchorStyles.Left;
            newbtn.Name = email;
            newbtn.FlatStyle = FlatStyle.Flat;
            newbtn.BackColor = Color.FromArgb(55, 74, 113);
            newbtn.ForeColor = Color.WhiteSmoke;
            newbtn.Cursor = Cursors.Hand;
            newbtn.Font = new Font("Oxanium SemiBold", newbtn.Font.Size);
            newbtn.Click += delegate
            {
                public_chatting_flag = false;
                sync_conversation(btn_name, email,bio);
                btn_send.PerformClick();
            };
            flowLayoutPanel1.Controls.Add(newbtn);
        }

        string target_name = "", target_email = "", target_bio = "";
        private void sync_conversation(string to_name, string to_email, string to_bio)
        {
            target_name = to_name;
            target_email = to_email;
            target_bio = to_bio;
            SqlDataAdapter da = sync_per_data();
            if (da != null)
            {
                try
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataTable dt = ds.Tables[0];

                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dt;
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                    dataGridView1.Columns["Conversation"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dataGridView1.Columns["Conversation"].DefaultCellStyle.Font = new Font("Rubik", 9);
                    dataGridView1.Columns["Conversation"].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    if (!public_chatting_flag)
                    {
                        label20.Text = target_name;
                        hidden_email.Text = to_email;
                        bio.Text = target_bio;
                    }

                    foreach(DataRow row in dt.Rows)
                    {
                        if (row["Conversation"].ToString().StartsWith(user_name))
                        {                            
                            user_msg(dt.Rows.IndexOf(row),user_name);
                        }
                     
                    }                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    new_conversation(get_db_name());
                }
            }
        }      

        private void new_conversation(string table_name)
        {
            SqlConnection cn = new SqlConnection(constr);
            try
            {   
                cn.Open();
                string query = "CREATE TABLE " + table_name + " (Conversation nvarchar(100) );";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
                string query2 = "insert into " + table_name + "(Conversation) values (@msg)";                
                SqlCommand cmd2 = new SqlCommand(query2, cn);
                cmd2.Parameters.AddWithValue("@msg", "You Are Now Connected!");
                cmd2.ExecuteNonQuery();
                reload();
            }
            catch (Exception ex)
            {
                ex.StackTrace.ToString();
            }
            finally
            {
                cn.Close();
            }
        }

        private SqlDataAdapter sync_per_data()
        {
            SqlConnection cn = new SqlConnection(constr);
            cn.Open();
            string temp = get_db_name();
            SqlDataAdapter da = null;
            string query = "select Conversation from " + temp;
            da = new SqlDataAdapter(query, cn);
            cn.Close();
            return da;
        }

        private string get_db_name()
        {
            string temp = "";
            if (public_chatting_flag)
            {
                temp = "CHATBOX";
            }
            else
            {
                string f_mail = user_email.Replace("@ucsy.edu.mm", "").ToLower();
                string t_mail = target_email.Replace("@ucsy.edu.mm", "").ToLower();
                string temp_name = f_mail + t_mail;
                char[] characters = temp_name.ToCharArray();
                Array.Sort(characters);
                Array.Reverse(characters);
                temp= new string(characters).ToUpper();
            }
            return temp;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (target_name != "" && target_email != "" || public_chatting_flag)
            {
                string temp = tb_input_msg.Text;
                if (temp.Trim() != string.Empty)
                {
                    SqlConnection cn = new SqlConnection(constr);
                    cn.Open();
                    string temp_table = get_db_name();                   
                    string insertquery = "insert into " + temp_table + "(Conversation) values (@msg)";
                    SqlCommand cmd = new SqlCommand(insertquery, cn);
                    string temp2 = user_name + " > " + temp;
                    cmd.Parameters.AddWithValue("@msg", temp2);                    
                    cmd.ExecuteNonQuery();
                    tb_input_msg.Clear();
                    cn.Close();
                }
                reload();
                tb_input_msg.Focus();
            }
            else
                MessageBox.Show("Choose a Conversation to Continue!");
        }

        private void reload()
        {
            if (target_email != null && target_name != null)
                sync_conversation(target_name, target_email,target_bio);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void load_Tick(object sender, EventArgs e)
        {
            load.Start();
            if (target_email != null && target_name != null)
                sync_conversation(target_name, target_email, target_bio);
        }

        private void label20_Click(object sender, EventArgs e)
        {
            if (hidden_email.Text != "")
            {
                User u = user_dao.getUser(hidden_email.Text);
                string info = String.Format("Information of {0}\nName : {1}\nEmail : {2}\nGender : {3}\nBio : {4}",u.name, u.name, u.email, u.gender, u.bio);
                MessageBox.Show(info);
            }
        }

        private void tb_input_msg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_send.PerformClick();
            }
        }

        private void user_msg(int temp,string temp_username)
        {
            dataGridView1.Rows[temp].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            string temp_msg = dataGridView1.Rows[temp].Cells["Conversation"].Value.ToString();
            dataGridView1.Rows[temp].Cells["Conversation"].Value = temp_msg.Replace(temp_username+ " > ", "");            
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            constr = app_class.get_constr();
            create_btn_pchat();
            Session s = sess_dao.getSession("login");
            if(s.login_email != "" || s.login_email != null)
                sync_data(s.login_email);
            load.Start();
        }
    }
}