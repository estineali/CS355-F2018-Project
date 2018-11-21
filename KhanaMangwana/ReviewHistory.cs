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
    public partial class ReviewHistory : Form
    {
        public ReviewHistory()
        {
            InitializeComponent();
            historylistbox.Items.Add("test");
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void detailsbutton_Click(object sender, EventArgs e)
        {
            if (historylistbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select A Review First!");
            }

            else
            {
                ReviewForm r = new ReviewForm();
                r.Show();
            }

        }

        private void historylistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
