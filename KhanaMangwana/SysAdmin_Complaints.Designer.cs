namespace KhanaMangwana
{
    partial class SysAdmin_Complaints
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysAdmin_Complaints));
            this.ComplaintsHeading = new System.Windows.Forms.Label();
            this.ComplainsListBox = new System.Windows.Forms.ListBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.ResolvedButton = new System.Windows.Forms.Button();
            this.AdminIDLabel = new System.Windows.Forms.Label();
            this.ComplainLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComplaintsHeading
            // 
            this.ComplaintsHeading.AutoSize = true;
            this.ComplaintsHeading.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComplaintsHeading.Location = new System.Drawing.Point(194, 37);
            this.ComplaintsHeading.Name = "ComplaintsHeading";
            this.ComplaintsHeading.Size = new System.Drawing.Size(162, 35);
            this.ComplaintsHeading.TabIndex = 0;
            this.ComplaintsHeading.Text = "Complaints";
            // 
            // ComplainsListBox
            // 
            this.ComplainsListBox.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComplainsListBox.FormattingEnabled = true;
            this.ComplainsListBox.ItemHeight = 18;
            this.ComplainsListBox.Items.AddRange(new object[] {
            "6\t\"Can not receive Orders\"",
            "6\t\"Can not update order status for a certain customer\""});
            this.ComplainsListBox.Location = new System.Drawing.Point(37, 132);
            this.ComplainsListBox.Name = "ComplainsListBox";
            this.ComplainsListBox.Size = new System.Drawing.Size(450, 238);
            this.ComplainsListBox.TabIndex = 1;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(331, 406);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ResolvedButton
            // 
            this.ResolvedButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolvedButton.Location = new System.Drawing.Point(412, 406);
            this.ResolvedButton.Name = "ResolvedButton";
            this.ResolvedButton.Size = new System.Drawing.Size(75, 23);
            this.ResolvedButton.TabIndex = 3;
            this.ResolvedButton.Text = "Resolved";
            this.ResolvedButton.UseVisualStyleBackColor = true;
            this.ResolvedButton.Click += new System.EventHandler(this.ResolvedButton_Click);
            // 
            // AdminIDLabel
            // 
            this.AdminIDLabel.AutoSize = true;
            this.AdminIDLabel.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminIDLabel.Location = new System.Drawing.Point(36, 113);
            this.AdminIDLabel.Name = "AdminIDLabel";
            this.AdminIDLabel.Size = new System.Drawing.Size(48, 13);
            this.AdminIDLabel.TabIndex = 4;
            this.AdminIDLabel.Text = "AdminID";
            // 
            // ComplainLabel
            // 
            this.ComplainLabel.AutoSize = true;
            this.ComplainLabel.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComplainLabel.Location = new System.Drawing.Point(105, 113);
            this.ComplainLabel.Name = "ComplainLabel";
            this.ComplainLabel.Size = new System.Drawing.Size(52, 13);
            this.ComplainLabel.TabIndex = 5;
            this.ComplainLabel.Text = "Complain";
            // 
            // SysAdmin_Complaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.ComplainLabel);
            this.Controls.Add(this.AdminIDLabel);
            this.Controls.Add(this.ResolvedButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ComplainsListBox);
            this.Controls.Add(this.ComplaintsHeading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SysAdmin_Complaints";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complaints";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ComplaintsHeading;
        private System.Windows.Forms.ListBox ComplainsListBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ResolvedButton;
        private System.Windows.Forms.Label AdminIDLabel;
        private System.Windows.Forms.Label ComplainLabel;
    }
}