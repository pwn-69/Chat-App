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
    public partial class Info : UserControl
    {
        public Info()
        {
            InitializeComponent();
        }
        private void website(string url)
        {
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
        }
        private void mailto(string url)
        {
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
        }
        private void shadow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            website("https://altotunchitoo.net");
        }
        private void nyintosh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            website("https://nyintosh.github.io");
        }
        private void phyowainyunt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            website("https://phyowainyunt.doctypetech.codes/");
        }
        private void altomail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mailto("mailto:altotunchitoo@ucsy.edu.mm");
        }
        private void nyimail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mailto("mailto:nyinyihtun@ucsy.edu.mm");
        }
        private void phyomail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mailto("mailto:phyowainyunt@ucsy.edu.mm");
        }
    }
}
