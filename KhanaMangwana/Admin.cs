using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KhanaMangwana;

namespace KhanaMangwana
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   
            Pending_Orders PO = new Pending_Orders();
            PO.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pending_Orders PO = new Pending_Orders(true);
            PO.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
        }

        private void EditMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User_Menu menu = new User_Menu(true);
            menu.Show();
        }


        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
