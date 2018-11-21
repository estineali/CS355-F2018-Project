namespace KhanaMangwana
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernametb = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Signuplink = new System.Windows.Forms.LinkLabel();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernametb
            // 
            this.usernametb.Location = new System.Drawing.Point(111, 122);
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(198, 20);
            this.usernametb.TabIndex = 0;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(156, 40);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(104, 31);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "LOGIN";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(40, 180);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(38, 125);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(111, 265);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(198, 24);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Don\'t have an account?";
            // 
            // Signuplink
            // 
            this.Signuplink.AutoSize = true;
            this.Signuplink.Location = new System.Drawing.Point(228, 321);
            this.Signuplink.Name = "Signuplink";
            this.Signuplink.Size = new System.Drawing.Size(64, 13);
            this.Signuplink.TabIndex = 7;
            this.Signuplink.TabStop = true;
            this.Signuplink.Text = "Signup here";
            this.Signuplink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Signuplink_LinkClicked);
            // 
            // showpass
            // 
            this.showpass.AutoSize = true;
            this.showpass.Location = new System.Drawing.Point(111, 213);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(102, 17);
            this.showpass.TabIndex = 8;
            this.showpass.Text = "Show Password";
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged_1);
            // 
            // passwordtb
            // 
            this.passwordtb.Location = new System.Drawing.Point(111, 177);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(198, 20);
            this.passwordtb.TabIndex = 4;
            this.passwordtb.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 356);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.Signuplink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.usernametb);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernametb;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Signuplink;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.TextBox passwordtb;
    }
}