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
    public partial class SystemAdmin : Form
    {
        public SystemAdmin()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Login NewLogin = new Login();
            NewLogin.Show();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {

        }
    }

}
