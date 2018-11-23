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
    public partial class ReviewForm : Form
    {
        public ReviewForm()
        {
            InitializeComponent();
            ratingcb.Items.Add("1");
            ratingcb.Items.Add("2");
            ratingcb.Items.Add("3");
            ratingcb.Items.Add("4");
            ratingcb.Items.Add("5");
            ratingcb.Items.Add("6");
            ratingcb.Items.Add("7");
            ratingcb.Items.Add("8");
            ratingcb.Items.Add("9");
            ratingcb.Items.Add("10");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
