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
    public partial class User_Cart : Form
    {
        public User_Cart()
        {
            InitializeComponent();
            itemslb.Items.Add("cake");
        }


        private void RemoveButton_Click(object sender, EventArgs e)
        {
            itemslb.Items.Remove(itemslb.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (itemslb.SelectedIndex != -1)
            {
                quantitychange.Text = (int.Parse(quantitychange.Text) + 1).ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (quantitychange.Text != "0" && itemslb.SelectedIndex != -1)
            {
                quantitychange.Text = (int.Parse(quantitychange.Text) - 1).ToString();
            }
        }
    }
}
