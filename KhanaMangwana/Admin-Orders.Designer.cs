namespace KhanaMangwana
{
    partial class Pending_Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pending_Orders));
            this.Order_details = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AcceptButton1 = new System.Windows.Forms.PictureBox();
            this.DeclineButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeclineButton)).BeginInit();
            this.SuspendLayout();
            // 
            // Order_details
            // 
            this.Order_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_details.Location = new System.Drawing.Point(207, 266);
            this.Order_details.Name = "Order_details";
            this.Order_details.Size = new System.Drawing.Size(88, 33);
            this.Order_details.TabIndex = 1;
            this.Order_details.Text = "OrderDetails";
            this.Order_details.UseVisualStyleBackColor = true;
            this.Order_details.Click += new System.EventHandler(this.Order_details_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(301, 267);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(70, 33);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "06983\tSaleha Raza "});
            this.listBox1.Location = new System.Drawing.Point(16, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(355, 225);
            this.listBox1.TabIndex = 3;
            // 
            // AcceptButton1
            // 
            this.AcceptButton1.Image = ((System.Drawing.Image)(resources.GetObject("AcceptButton1.Image")));
            this.AcceptButton1.Location = new System.Drawing.Point(16, 267);
            this.AcceptButton1.Name = "AcceptButton1";
            this.AcceptButton1.Size = new System.Drawing.Size(34, 33);
            this.AcceptButton1.TabIndex = 4;
            this.AcceptButton1.TabStop = false;
            // 
            // DeclineButton
            // 
            this.DeclineButton.Image = ((System.Drawing.Image)(resources.GetObject("DeclineButton.Image")));
            this.DeclineButton.Location = new System.Drawing.Point(82, 267);
            this.DeclineButton.Name = "DeclineButton";
            this.DeclineButton.Size = new System.Drawing.Size(35, 33);
            this.DeclineButton.TabIndex = 5;
            this.DeclineButton.TabStop = false;
            // 
            // Pending_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 312);
            this.Controls.Add(this.DeclineButton);
            this.Controls.Add(this.AcceptButton1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Order_details);
            this.Name = "Pending_Orders";
            this.Text = "Pending_Orders";
            ((System.ComponentModel.ISupportInitialize)(this.AcceptButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeclineButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Order_details;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox AcceptButton1;
        private System.Windows.Forms.PictureBox DeclineButton;
    }
}