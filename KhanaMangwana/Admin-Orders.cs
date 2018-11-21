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
    public partial class Pending_Orders : Form
    {

        bool Nonedit = false;

        public Pending_Orders()
        {
            InitializeComponent();
            AcceptButton1.SizeMode = PictureBoxSizeMode.StretchImage;
            DeclineButton.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public Pending_Orders(bool NotEditable)
        {
            InitializeComponent();
            if (NotEditable)
            {
                AcceptButton1.Visible = false;
                DeclineButton.Visible = false;
            }

            Nonedit = true;
            
        }

        private void Order_details_Click(object sender, EventArgs e)
        {
            if (Nonedit)
            {
                Order_Details OD = new Order_Details();
                OD.Show();
            }
            else
            {
                Order_Details OD = new Order_Details(true);
                OD.Show();
            }
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
