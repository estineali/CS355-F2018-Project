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
    public partial class Admin_AddMenuItem : Form
    {
        public Admin_AddMenuItem()
        {
            InitializeComponent();
            EatingHousecb.Items.Add("Cafe2Go");
            EatingHousecb.Items.Add("Tapal Cafeteria");
            EatingHousecb.Items.Add("Cafeela");
        }

        private void uploadbutton_Click(object sender, EventArgs e)
        {
            string imagelocation = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png| All Files(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imagelocation = dialog.FileName;
                pictureBox1.ImageLocation = imagelocation;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to exit?", "Are you sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (itemnametb.Text.Trim() == "" || caloriestb.Text.Trim() == "" || timetb.Text.Trim() == "" || EatingHousecb.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the form completely!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                DialogResult result = MessageBox.Show("Add Item to menu?", "Update Menu", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // edit later
                }
            }
        }
    }
}
