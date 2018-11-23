using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;


namespace KhanaMangwana
{
    public partial class Login : Form
    {
        //SqlConnection con;
        public Login()
        {
            InitializeComponent();

            /*
            con = new SqlConnection();
            con.ConnectionString = "Data Source=.; Initial Catalog=KhanaMangwana; Integrated Security=true;";
            con.ConnectionString = "Data Source=.; Initial Catalog=KhanaMangwana; User ID = sa; Pwd=Habib123##";
            con.Open(); */

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            /*
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select FirstName, Passwordd from Users";
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read() == true)
            {
                string name = rd[0].ToString();
                string password = rd[1].ToString();

                if (name == textBox1.Text && password == textBox2.Text)
                {
                    MessageBox.Show("Login successful!");
                }

                else
                {
                    MessageBox.Show("Login failed! Try Again");
                }
            }
            rd.Close(); */

            passwordtb.UseSystemPasswordChar = false;
            string pass = passwordtb.Text;
            passwordtb.UseSystemPasswordChar = true;

            if (usernametb.Text == "user" && pass == "user")
           {
                
                Form3 frm3 = new Form3();
                frm3.Show();
                MessageBox.Show("Welcome Back!", "Login Successful", MessageBoxButtons.OK);
                this.Hide();

            }
            else if (usernametb.Text == "admin" && pass == "admin")
            {

                Admin frm3 = new Admin();
                frm3.Show();
                MessageBox.Show("Welcome Back!", "Login Successful", MessageBoxButtons.OK);
                this.Hide();

            }

            else if (usernametb.Text == "sysadmin" && pass == "administer")
            { 
                SystemAdmin sysAd = new SystemAdmin();
                sysAd.Show();
                MessageBox.Show("THE RED ROASTED PARAKEETS", "Buongiorno", MessageBoxButtons.OK);
                this.Hide();

            }

            else
            {
               MessageBox.Show("Login failed! Try Again", "Login Failed", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }

        }

        private void Signuplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm frm2 = new RegistrationForm();
            frm2.Show();
            this.Hide();
        }

       

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Are you sure?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }



        private void showpass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (showpass.Checked == true)
            {
                passwordtb.UseSystemPasswordChar = false;
            }
            else
            {
                passwordtb.UseSystemPasswordChar = true;
            }
        }
    }
}
