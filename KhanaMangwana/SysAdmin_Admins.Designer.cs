namespace KhanaMangwana
{
    partial class SysAdminAdmins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysAdminAdmins));
            this.NewAdminButton = new System.Windows.Forms.Button();
            this.AllAdminsListBox = new System.Windows.Forms.ListBox();
            this.AdminDetailsButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewAdminButton
            // 
            this.NewAdminButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewAdminButton.Location = new System.Drawing.Point(301, 61);
            this.NewAdminButton.Name = "NewAdminButton";
            this.NewAdminButton.Size = new System.Drawing.Size(121, 42);
            this.NewAdminButton.TabIndex = 0;
            this.NewAdminButton.Text = "Add Admin\r\n";
            this.NewAdminButton.UseVisualStyleBackColor = true;
            this.NewAdminButton.Click += new System.EventHandler(this.NewAdminButton_Click);
            // 
            // AllAdminsListBox
            // 
            this.AllAdminsListBox.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllAdminsListBox.FormattingEnabled = true;
            this.AllAdminsListBox.ItemHeight = 18;
            this.AllAdminsListBox.Items.AddRange(new object[] {
            "Tapal Cafeteria",
            "Cafe2Go",
            "Cafeela"});
            this.AllAdminsListBox.Location = new System.Drawing.Point(39, 61);
            this.AllAdminsListBox.Name = "AllAdminsListBox";
            this.AllAdminsListBox.Size = new System.Drawing.Size(232, 220);
            this.AllAdminsListBox.TabIndex = 1;
            // 
            // AdminDetailsButton
            // 
            this.AdminDetailsButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminDetailsButton.Location = new System.Drawing.Point(301, 118);
            this.AdminDetailsButton.Name = "AdminDetailsButton";
            this.AdminDetailsButton.Size = new System.Drawing.Size(121, 42);
            this.AdminDetailsButton.TabIndex = 2;
            this.AdminDetailsButton.Text = "Admin Details";
            this.AdminDetailsButton.UseVisualStyleBackColor = true;
            this.AdminDetailsButton.Click += new System.EventHandler(this.AdminDetailsButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(301, 177);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(121, 42);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove Admin";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(301, 235);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(121, 42);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SysAdminAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 332);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AdminDetailsButton);
            this.Controls.Add(this.AllAdminsListBox);
            this.Controls.Add(this.NewAdminButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SysAdminAdmins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admins";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewAdminButton;
        private System.Windows.Forms.ListBox AllAdminsListBox;
        private System.Windows.Forms.Button AdminDetailsButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button BackButton;
    }
}