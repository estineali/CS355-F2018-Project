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
    public partial class OrderHistory : Form
    {
        public OrderHistory()
        {
            InitializeComponent();
            historylb.Items.Add("test");
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void detailbutton_Click(object sender, EventArgs e)
        {

            if (historylb.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select A Order First!");
            }

            else
            {
                User_OrderDetails details = new User_OrderDetails();
                details.Show();
            }

            
        }
    }
}
