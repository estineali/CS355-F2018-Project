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
        bool sysAdminCall = false;
        public OrderHistory()
        {
            InitializeComponent();
            historylb.Items.Add("test");
        }

        public OrderHistory(string sysAdmin)
        {
            InitializeComponent();
            if (sysAdmin == "System Admin")
            {
                historylb.Items.Add("EatHouse   OrderID");
                historylb.Items.Add("1   1");
                historylb.Items.Add("1   2");
                historylb.Items.Add("1   3");
                historylb.Items.Add("1   4");
                historylb.Items.Add("1   5");
                historylb.Items.Add("1   6");
                historylb.Items.Add("1   7");
                historylb.Items.Add("1   8");
                historylb.Items.Add("1   9");
                historylb.Items.Add("2   1");
                historylb.Items.Add("2   2");
                historylb.Items.Add("2   3");
                historylb.Items.Add("2   4");
                historylb.Items.Add("2   5");
                historylb.Items.Add("2   6");
                historylb.Items.Add("2   7");
                historylb.Items.Add("2   8");
                historylb.Items.Add("3   1");
                historylb.Items.Add("3   2");
                historylb.Items.Add("3   3");
                historylb.Items.Add("3   4");
                historylb.Items.Add("3   5");
                historylb.Items.Add("3   6");

            }
            sysAdminCall = true;
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            if (sysAdminCall)
            {
                this.Close();
                SystemAdmin SystemAdminPanel = new SystemAdmin();
                SystemAdminPanel.Show();
            }
            else
            {
                this.Close();
            }
            
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
