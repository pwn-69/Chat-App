using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UCSY_Social
{
    public partial class Feeds : UserControl
    {
        public Feeds()
        {
            InitializeComponent();
        }

        Connection app_class = new Connection();
        private string constr = "";
        private void load_feed()
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection cn = new SqlConnection(constr);
            cn.Open();
            SqlDataAdapter da = null;
            string query = "SELECT * FROM FEEDS";
            da = new SqlDataAdapter(query, cn);
            cn.Close();

            if (da != null)
            {
                try
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    foreach(DataRow row in dt.Rows)
                    {
                        string publisher = row[1].ToString();
                        string content = row[2].ToString();
                        DateTime time = (DateTime)row[3];
                        create_post(publisher, content, time);
                    }
                                        
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        private void create_post(string publisher,string content, DateTime time)
        {
            /*//Create label
            Label label = new Label();
            Label label2 = new Label();
            label.Text = String.Format("Posted by {0}", publisher);
            label.Size = new Size(180, 30);
            label2.Text = content;
            label2.Size = new Size(300, 40);
            label.Location = new Point(20, Loc);
            Loc += 30;
            label2.Location = new Point(50, Loc);
            Loc += 70;
            this.flowLayoutPanel1.Controls.Add(label);
            this.flowLayoutPanel1.Controls.Add(label2);
            // panelname.Controls*/
            Panel panel = new Panel();
            panel.Size = new Size(370, 100);
            panel.Margin = new Padding(5);
            panel.BackColor = Color.FromArgb(250, 250, 250);
            Label l_publisher = new Label();
            Label l_date = new Label();
            Label l_content = new Label();

            l_publisher.Text = String.Format("{0}", publisher);
            l_publisher.Size = new Size(180, 20);
            l_publisher.TextAlign = ContentAlignment.MiddleLeft;
            l_publisher.Location = new Point(5, 5);
            l_publisher.Font = new Font("Poppins SemiBold", 9);

            l_date.Text = time.ToLongDateString();
            l_date.Size = new Size(180, 20);
            l_date.TextAlign = ContentAlignment.MiddleRight;
            l_date.Location = new Point(185, 5);
            l_date.Font = new Font("Rubik", 8);

            l_content.Text = "     " + content;
            l_content.Size = new Size(360, 70);
            l_content.TextAlign = ContentAlignment.MiddleLeft;
            l_content.Location = new Point(5, 25);
            l_content.Font = new Font("Roboto", 9);

            panel.Controls.Add(l_publisher);
            panel.Controls.Add(l_content);
            panel.Controls.Add(l_date);
            this.flowLayoutPanel1.Controls.Add(panel);
            this.flowLayoutPanel1.AutoScrollPosition.Offset(0, flowLayoutPanel1.Width);
        }

        private void Feeds_Load(object sender, EventArgs e)
        {
            constr = app_class.get_constr();
            load_feed();
            date.Text = String.Format("Date : {0}", DateTime.Now.ToLongDateString());
            dateTimer.Start();
            time.Text = String.Format("Time : {0}", DateTime.Now.ToLongTimeString());
        }

        private void Post_Click(object sender, EventArgs e)
        {
            posting();
        }

        private void posting()
        {
            SessionDAO sess_dao = new SessionDAO();
            string content = tb_post.Text;
            string publisher = sess_dao.login_name();
            if (content.Trim() != string.Empty)
            {
                SqlConnection cn = new SqlConnection(constr);
                cn.Open();
                string query = "insert into feeds(Publisher,Content, Time) values(@1,@2, @3)";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@1", publisher);
                cmd.Parameters.AddWithValue("@2", content);
                cmd.Parameters.AddWithValue("@3", DateTime.Now);
                cmd.ExecuteNonQuery();
                cn.Close();
                tb_post.Text = "";
                tb_post.Focus();
            }
            load_feed();
        }

        private void tb_post_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                e.Handled = true;
                if (e.Shift)
                {
                    posting();
                }   
            }
        }

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            dateTimer.Start();
            time.Text = String.Format("Time : {0}", DateTime.Now.ToLongTimeString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            load_feed();
        }
    }
}