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
    public partial class SysAdminCustomers : Form
    {
        public SysAdminCustomers()
        {
            InitializeComponent();
        }

        private void detailbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Functional after database connectivity");
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            SystemAdmin SystemAdminPanel = new SystemAdmin();
            SystemAdminPanel.Show();
        }
    }
}
