using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhanaMangwana
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void orderlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void balancelink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void menulink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User_Menu menu = new User_Menu(false);
            menu.Show();
            
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Are you sure?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Login frm = new Login();
            frm.Show();
        }
    }
}
