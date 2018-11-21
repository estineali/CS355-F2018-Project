namespace KhanaMangwana
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fnametb = new System.Windows.Forms.TextBox();
            this.lnametb = new System.Windows.Forms.TextBox();
            this.emailtb = new System.Windows.Forms.TextBox();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.password2tb = new System.Windows.Forms.TextBox();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.loginlink = new System.Windows.Forms.LinkLabel();
            this.passwordcheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registeration Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Confirm Password :";
            // 
            // fnametb
            // 
            this.fnametb.Location = new System.Drawing.Point(128, 136);
            this.fnametb.Name = "fnametb";
            this.fnametb.Size = new System.Drawing.Size(240, 20);
            this.fnametb.TabIndex = 6;
            // 
            // lnametb
            // 
            this.lnametb.Location = new System.Drawing.Point(128, 187);
            this.lnametb.Name = "lnametb";
            this.lnametb.Size = new System.Drawing.Size(240, 20);
            this.lnametb.TabIndex = 13;
            // 
            // emailtb
            // 
            this.emailtb.Location = new System.Drawing.Point(128, 246);
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(240, 20);
            this.emailtb.TabIndex = 14;
            // 
            // passwordtb
            // 
            this.passwordtb.Location = new System.Drawing.Point(128, 297);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(240, 20);
            this.passwordtb.TabIndex = 15;
            this.passwordtb.UseSystemPasswordChar = true;
            // 
            // password2tb
            // 
            this.password2tb.Location = new System.Drawing.Point(128, 350);
            this.password2tb.Name = "password2tb";
            this.password2tb.Size = new System.Drawing.Size(240, 20);
            this.password2tb.TabIndex = 16;
            this.password2tb.UseSystemPasswordChar = true;
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(203, 433);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 17;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click_1);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(293, 433);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 18;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click_1);
            // 
            // loginlink
            // 
            this.loginlink.AutoSize = true;
            this.loginlink.Location = new System.Drawing.Point(13, 13);
            this.loginlink.Name = "loginlink";
            this.loginlink.Size = new System.Drawing.Size(42, 13);
            this.loginlink.TabIndex = 19;
            this.loginlink.TabStop = true;
            this.loginlink.Text = "< Login";
            this.loginlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginlink_LinkClicked);
            // 
            // passwordcheck
            // 
            this.passwordcheck.AutoSize = true;
            this.passwordcheck.Location = new System.Drawing.Point(128, 386);
            this.passwordcheck.Name = "passwordcheck";
            this.passwordcheck.Size = new System.Drawing.Size(102, 17);
            this.passwordcheck.TabIndex = 20;
            this.passwordcheck.Text = "Show Password";
            this.passwordcheck.UseVisualStyleBackColor = true;
            this.passwordcheck.CheckedChanged += new System.EventHandler(this.passwordcheck_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 491);
            this.Controls.Add(this.passwordcheck);
            this.Controls.Add(this.loginlink);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.password2tb);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.emailtb);
            this.Controls.Add(this.lnametb);
            this.Controls.Add(this.fnametb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fnametb;
        private System.Windows.Forms.TextBox lnametb;
        private System.Windows.Forms.TextBox emailtb;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.TextBox password2tb;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.LinkLabel loginlink;
        private System.Windows.Forms.CheckBox passwordcheck;
    }
}