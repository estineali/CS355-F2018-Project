namespace KhanaMangwana
{
    partial class SystemAdmin
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
            this.SysAdminLabel = new System.Windows.Forms.Label();
            this.AdminsButton = new System.Windows.Forms.Button();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.ComplaintsButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SysAdminLabel
            // 
            this.SysAdminLabel.AutoSize = true;
            this.SysAdminLabel.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysAdminLabel.Location = new System.Drawing.Point(53, 44);
            this.SysAdminLabel.Name = "SysAdminLabel";
            this.SysAdminLabel.Size = new System.Drawing.Size(223, 35);
            this.SysAdminLabel.TabIndex = 0;
            this.SysAdminLabel.Text = "SYSTEM ADMIN\r\n";
            // 
            // AdminsButton
            // 
            this.AdminsButton.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminsButton.Location = new System.Drawing.Point(29, 204);
            this.AdminsButton.Name = "AdminsButton";
            this.AdminsButton.Size = new System.Drawing.Size(279, 35);
            this.AdminsButton.TabIndex = 1;
            this.AdminsButton.Text = "Admins";
            this.AdminsButton.UseVisualStyleBackColor = true;
            // 
            // CustomersButton
            // 
            this.CustomersButton.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersButton.Location = new System.Drawing.Point(29, 257);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CustomersButton.Size = new System.Drawing.Size(279, 35);
            this.CustomersButton.TabIndex = 2;
            this.CustomersButton.Text = "Customers";
            this.CustomersButton.UseVisualStyleBackColor = true;
            // 
            // OrdersButton
            // 
            this.OrdersButton.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersButton.Location = new System.Drawing.Point(29, 310);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OrdersButton.Size = new System.Drawing.Size(279, 35);
            this.OrdersButton.TabIndex = 3;
            this.OrdersButton.Text = "Orders";
            this.OrdersButton.UseVisualStyleBackColor = true;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // ComplaintsButton
            // 
            this.ComplaintsButton.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComplaintsButton.Location = new System.Drawing.Point(29, 151);
            this.ComplaintsButton.Name = "ComplaintsButton";
            this.ComplaintsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ComplaintsButton.Size = new System.Drawing.Size(279, 35);
            this.ComplaintsButton.TabIndex = 4;
            this.ComplaintsButton.Text = "Complaints";
            this.ComplaintsButton.UseVisualStyleBackColor = true;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Location = new System.Drawing.Point(29, 362);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LogoutButton.Size = new System.Drawing.Size(279, 35);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // SystemAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.ComplaintsButton);
            this.Controls.Add(this.OrdersButton);
            this.Controls.Add(this.CustomersButton);
            this.Controls.Add(this.AdminsButton);
            this.Controls.Add(this.SysAdminLabel);
            this.Name = "SystemAdmin";
            this.Text = "System Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SysAdminLabel;
        private System.Windows.Forms.Button AdminsButton;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Button ComplaintsButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}