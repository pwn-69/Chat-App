using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCSY_Social
{
    public partial class home : UserControl
    {
        public home()
        {
            InitializeComponent();
        }
        private void start_btn_Click(object sender, EventArgs e)
        {
            Registraion registraion = new Registraion();
            registraion.Show();
            this.ParentForm.Hide();
        }
        private void home_Load(object sender, EventArgs e)
        {
            date_timer.Start();
            label_date.Text = DateTime.Now.ToLongTimeString();
        }
        private void date_timer_Tick(object sender, EventArgs e)
        {
            date_timer.Start();
            label_date.Text = DateTime.Now.ToLongTimeString();
        }
    }
}