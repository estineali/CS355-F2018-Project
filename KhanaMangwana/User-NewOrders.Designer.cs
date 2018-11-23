namespace KhanaMangwana
{
    partial class User_NewOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_NewOrders));
            this.cartpb = new System.Windows.Forms.PictureBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cafeelabutton = new System.Windows.Forms.RadioButton();
            this.cafe2gobutton = new System.Windows.Forms.RadioButton();
            this.cafebutton = new System.Windows.Forms.RadioButton();
            this.checkoutbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cartpb)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartpb
            // 
            this.cartpb.Image = ((System.Drawing.Image)(resources.GetObject("cartpb.Image")));
            this.cartpb.Location = new System.Drawing.Point(382, 41);
            this.cartpb.Name = "cartpb";
            this.cartpb.Size = new System.Drawing.Size(59, 53);
            this.cartpb.TabIndex = 0;
            this.cartpb.TabStop = false;
            this.cartpb.Click += new System.EventHandler(this.cartpb_Click);
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.Location = new System.Drawing.Point(22, 150);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(419, 43);
            this.addbutton.TabIndex = 1;
            this.addbutton.Text = "Add Items";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(22, 292);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(419, 40);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel Order";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cafeelabutton);
            this.groupBox1.Controls.Add(this.cafe2gobutton);
            this.groupBox1.Controls.Add(this.cafebutton);
            this.groupBox1.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 83);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eating House";
            // 
            // cafeelabutton
            // 
            this.cafeelabutton.AutoSize = true;
            this.cafeelabutton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cafeelabutton.Location = new System.Drawing.Point(220, 38);
            this.cafeelabutton.Name = "cafeelabutton";
            this.cafeelabutton.Size = new System.Drawing.Size(69, 19);
            this.cafeelabutton.TabIndex = 8;
            this.cafeelabutton.TabStop = true;
            this.cafeelabutton.Text = "Cafeela";
            this.cafeelabutton.UseVisualStyleBackColor = true;
            // 
            // cafe2gobutton
            // 
            this.cafe2gobutton.AutoSize = true;
            this.cafe2gobutton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cafe2gobutton.Location = new System.Drawing.Point(130, 38);
            this.cafe2gobutton.Name = "cafe2gobutton";
            this.cafe2gobutton.Size = new System.Drawing.Size(75, 19);
            this.cafe2gobutton.TabIndex = 7;
            this.cafe2gobutton.TabStop = true;
            this.cafe2gobutton.Text = "Cafe2Go";
            this.cafe2gobutton.UseVisualStyleBackColor = true;
            // 
            // cafebutton
            // 
            this.cafebutton.AutoSize = true;
            this.cafebutton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cafebutton.Location = new System.Drawing.Point(6, 38);
            this.cafebutton.Name = "cafebutton";
            this.cafebutton.Size = new System.Drawing.Size(111, 19);
            this.cafebutton.TabIndex = 6;
            this.cafebutton.TabStop = true;
            this.cafebutton.Text = "Tapal Cafeteria";
            this.cafebutton.UseVisualStyleBackColor = true;
            // 
            // checkoutbutton
            // 
            this.checkoutbutton.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutbutton.Location = new System.Drawing.Point(22, 221);
            this.checkoutbutton.Name = "checkoutbutton";
            this.checkoutbutton.Size = new System.Drawing.Size(419, 40);
            this.checkoutbutton.TabIndex = 5;
            this.checkoutbutton.Text = "Check Out";
            this.checkoutbutton.UseVisualStyleBackColor = true;
            this.checkoutbutton.Click += new System.EventHandler(this.checkoutbutton_Click);
            // 
            // User_NewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 357);
            this.Controls.Add(this.checkoutbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.cartpb);
            this.Name = "User_NewOrders";
            this.Text = "New Order";
            ((System.ComponentModel.ISupportInitialize)(this.cartpb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cartpb;
        private System.Windows.Forms.Button addbutton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button checkoutbutton;
        private System.Windows.Forms.RadioButton cafeelabutton;
        private System.Windows.Forms.RadioButton cafe2gobutton;
        private System.Windows.Forms.RadioButton cafebutton;
    }
}