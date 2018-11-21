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
    public partial class User_Menu : Form
    {
        public User_Menu()
        {
            InitializeComponent();
            detailsbutton.Visible = false;
            newitembutton.Visible = false;
            editbutton.Visible = false;
            
        }

        public User_Menu(bool AdminAccess)
        {
            InitializeComponent();
            groupBox7.Visible = false;
            addbutton.Visible = false;
            if (AdminAccess == false)
            {
                listBox1.Items.Add("test");
                newitembutton.Visible = false;
                editbutton.Visible = false;
            }

        }


        private void add_Click(object sender, EventArgs e)
        {
            quantityno.Text = (int.Parse(quantityno.Text) + 1).ToString();
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            if (quantityno.Text != "0")
            {
                quantityno.Text = (int.Parse(quantityno.Text) - 1).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void detailsbutton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Menu_Details deet = new Menu_Details();
                deet.Show();
            }
            else
            {
                MessageBox.Show("Please select an item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newitembutton_Click(object sender, EventArgs e)
        {
            Admin_AddMenuItem add = new Admin_AddMenuItem();
            add.Show();
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            //will call a constructor, and display a pre-filled form
            Admin_AddMenuItem add = new Admin_AddMenuItem();
            add.Show();
        }
    }
}
