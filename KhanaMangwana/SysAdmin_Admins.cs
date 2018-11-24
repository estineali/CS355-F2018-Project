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
    public partial class SysAdminAdmins : Form
    {
        public SysAdminAdmins()
        {
            InitializeComponent();
        }

        public SysAdminAdmins(string s)
        {
            InitializeComponent();
            AllAdminsListBox.Items.Add(s);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            SystemAdmin SysAdminPanel = new SystemAdmin();
            SysAdminPanel.Show();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            AllAdminsListBox.Items.Remove(AllAdminsListBox.SelectedItem);
        }

        private void AdminDetailsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon only on Red Roasted Parakeets! :3");
        }

        private void NewAdminButton_Click(object sender, EventArgs e)
        {
            this.Close();
            NewAdminForm NewAdmin = new NewAdminForm();
            NewAdmin.Show();
        }
    }
}
