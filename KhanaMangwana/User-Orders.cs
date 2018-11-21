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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void moneytb_TextChanged(object sender, EventArgs e)
        {
            moneytb.Text = "1000 Rs";
        }

        private void neworderbutton_Click(object sender, EventArgs e)
        {
            User_NewOrders un = new User_NewOrders();
            un.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            User_Reviews review = new User_Reviews();
            review.Show();
        }

        private void statusbutton_Click(object sender, EventArgs e)
        {
            OrderStatus status = new OrderStatus();
            status.Show();
        }

        private void historybutton_Click(object sender, EventArgs e)
        {
            OrderHistory hist = new OrderHistory();
            hist.Show();
        }
    }
}
