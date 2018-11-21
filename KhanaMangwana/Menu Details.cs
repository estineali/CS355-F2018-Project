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
    public partial class Menu_Details : Form
    {
        public Menu_Details()
        {
            InitializeComponent();
            star1.SizeMode = PictureBoxSizeMode.StretchImage;
            star2.SizeMode = PictureBoxSizeMode.StretchImage;
            star3.SizeMode = PictureBoxSizeMode.StretchImage;
            star4.SizeMode = PictureBoxSizeMode.StretchImage;
            star5.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cloebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Details_Load(object sender, EventArgs e)
        {

        }

       
    }
}
