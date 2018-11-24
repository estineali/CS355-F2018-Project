namespace KhanaMangwana
{
    partial class SysAdminCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysAdminCustomers));
            this.cancelbutton = new System.Windows.Forms.Button();
            this.detailbutton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.AllCustomersLabel = new System.Windows.Forms.Label();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelbutton
            // 
            this.cancelbutton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.Location = new System.Drawing.Point(314, 399);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 24);
            this.cancelbutton.TabIndex = 7;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // detailbutton
            // 
            this.detailbutton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailbutton.Location = new System.Drawing.Point(408, 399);
            this.detailbutton.Name = "detailbutton";
            this.detailbutton.Size = new System.Drawing.Size(75, 24);
            this.detailbutton.TabIndex = 6;
            this.detailbutton.Text = "View Details";
            this.detailbutton.UseVisualStyleBackColor = true;
            this.detailbutton.Click += new System.EventHandler(this.detailbutton_Click);
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 18;
            this.CustomersListBox.Items.AddRange(new object[] {
            "9\tAlina Qureshi",
            "10\tAli Mohammed Shujjat",
            "11\tMuhammad Shahrom Ali",
            "12\tSarah Khan",
            "13\tAymen Wasim",
            "14\tMuhammad Shahzain"});
            this.CustomersListBox.Location = new System.Drawing.Point(42, 91);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(441, 274);
            this.CustomersListBox.TabIndex = 5;
            // 
            // AllCustomersLabel
            // 
            this.AllCustomersLabel.AutoSize = true;
            this.AllCustomersLabel.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllCustomersLabel.Location = new System.Drawing.Point(180, 28);
            this.AllCustomersLabel.Name = "AllCustomersLabel";
            this.AllCustomersLabel.Size = new System.Drawing.Size(144, 25);
            this.AllCustomersLabel.TabIndex = 4;
            this.AllCustomersLabel.Text = "All Customers";
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDLabel.Location = new System.Drawing.Point(45, 71);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(20, 15);
            this.CustomerIDLabel.TabIndex = 8;
            this.CustomerIDLabel.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // SysAdminCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerIDLabel);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.detailbutton);
            this.Controls.Add(this.CustomersListBox);
            this.Controls.Add(this.AllCustomersLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SysAdminCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Customers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button detailbutton;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Label AllCustomersLabel;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Label label1;
    }
}