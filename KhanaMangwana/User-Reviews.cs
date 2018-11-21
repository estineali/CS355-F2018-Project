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
    public partial class User_Reviews : Form
    {
        public User_Reviews()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReviewForm review = new ReviewForm();
            review.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void history_Click(object sender, EventArgs e)
        {
            ReviewHistory history = new ReviewHistory();
            history.Show();
        }
    }
}
