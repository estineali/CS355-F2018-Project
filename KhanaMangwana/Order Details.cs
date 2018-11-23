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
    public partial class Order_Details : Form
    {
        public Order_Details()
        {
            InitializeComponent();
            listBox1.Enabled = false;
        }

        public Order_Details(bool editable)
        {
            InitializeComponent();
            listBox1.Enabled = false;
            CompletedButton.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompletedButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure the order is completed?", "Confirm Order Status", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (statustb.Text == "Pending")
                {
                    statustb.Text = "Completed";
                }
            }
        }

        
    }
}
