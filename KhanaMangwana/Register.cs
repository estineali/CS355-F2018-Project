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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

       

        private void cancelbutton_Click_1(object sender, EventArgs e)
        {
            const string message =
            "Are you sure that you would like to close the form?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                Application.Exit();
   
            }
        }

        private void RegisterButton_Click_1(object sender, EventArgs e)
        {
            /*
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;*/

            if (FirstNameTextBox.Text.Trim() == "" || LastNameTextBox.Text.Trim() == "" || EmailTextBox.Text.Trim() == "" || PasswordTextBox.Text.Trim() == "" || ConfPasswordTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the form completely!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (PasswordTextBox.TextLength < 8)
                {
                    MessageBox.Show("Error! Password should have more than 7 characters");
                }
                else
                {
                    if (PasswordTextBox.Text != ConfPasswordTextBox.Text)
                    {
                        MessageBox.Show("Not the same password, Try Again!");
                    }
                    else
                    {
                        /*cmd.CommandText = "Insert into Users(FirstName, LastName, Email, Passwordd) values ('" + textBox1.Text + "','" + textBox5.Text + "','" + textBox2.Text + "','" + textBox4.Text + "')";
                        cmd.ExecuteNonQuery(); */
                        this.Close();
                        

                        Form3 frm3 = new Form3();
                        frm3.Show();
                        MessageBox.Show("Registration Successful! Welcome to KhanaMangwana App");

                    }
                }
            }
        }

        private void loginlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Login frm = new Login();
            frm.Show();
        }

        private void passwordcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordCheck.Checked == true)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
                ConfPasswordTextBox.UseSystemPasswordChar = false;

            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
                ConfPasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        
    }
}
