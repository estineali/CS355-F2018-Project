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
    public partial class NewAdminForm : Form
    {
        public NewAdminForm()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text != ConfPasswordTextBox.Text)
            {
                MessageBox.Show("Passwords do not match.");
            }
            else
            {
                this.Close();
                SysAdminAdmins AllAdmins = new SysAdminAdmins(FirstNameTextBox.Text.ToString() + ' ' + LastNameTextBox.Text.ToString());
                AllAdmins.Show();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            SysAdminAdmins AllAdmins = new SysAdminAdmins();
            AllAdmins.Show();
        }
    }
}
