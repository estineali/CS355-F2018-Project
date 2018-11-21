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
    public partial class User_NewOrders : Form
    {
        public User_NewOrders()
        {
            InitializeComponent();
            cartpb.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cancel Order?", "Are you sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void checkoutbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Is this your final order?", "Confirm Order", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
           
        }

        private void addbutton_Click(object sender, EventArgs e)
        {

            if (cafebutton.Checked|| cafeelabutton.Checked || cafe2gobutton.Checked)
            {
                User_Menu menu = new User_Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Please Select an Eating House first!", "Cannot Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cartpb_Click(object sender, EventArgs e)
        {
            User_Cart cart = new User_Cart();
            cart.Show();
        }
    }
}
