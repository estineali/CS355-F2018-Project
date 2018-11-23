namespace KhanaMangwana
{
    partial class Form4
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
            this.neworderbutton = new System.Windows.Forms.Button();
            this.statusbutton = new System.Windows.Forms.Button();
            this.historybutton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.moneytb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orders";
            // 
            // neworderbutton
            // 
            this.neworderbutton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neworderbutton.Location = new System.Drawing.Point(95, 130);
            this.neworderbutton.Name = "neworderbutton";
            this.neworderbutton.Size = new System.Drawing.Size(280, 35);
            this.neworderbutton.TabIndex = 1;
            this.neworderbutton.Text = "Place New Order";
            this.neworderbutton.UseVisualStyleBackColor = true;
            this.neworderbutton.Click += new System.EventHandler(this.neworderbutton_Click);
            // 
            // statusbutton
            // 
            this.statusbutton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusbutton.Location = new System.Drawing.Point(95, 185);
            this.statusbutton.Name = "statusbutton";
            this.statusbutton.Size = new System.Drawing.Size(280, 35);
            this.statusbutton.TabIndex = 2;
            this.statusbutton.Text = "View Order Status";
            this.statusbutton.UseVisualStyleBackColor = true;
            this.statusbutton.Click += new System.EventHandler(this.statusbutton_Click);
            // 
            // historybutton
            // 
            this.historybutton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historybutton.Location = new System.Drawing.Point(95, 242);
            this.historybutton.Name = "historybutton";
            this.historybutton.Size = new System.Drawing.Size(280, 35);
            this.historybutton.TabIndex = 3;
            this.historybutton.Text = "View Order History";
            this.historybutton.UseVisualStyleBackColor = true;
            this.historybutton.Click += new System.EventHandler(this.historybutton_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(95, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(280, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "Reviews";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current Wallet Balance: ";
            // 
            // moneytb
            // 
            this.moneytb.Enabled = false;
            this.moneytb.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneytb.Location = new System.Drawing.Point(380, 18);
            this.moneytb.Name = "moneytb";
            this.moneytb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.moneytb.Size = new System.Drawing.Size(60, 21);
            this.moneytb.TabIndex = 7;
            this.moneytb.Text = "Rs. 100";
            this.moneytb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 383);
            this.Controls.Add(this.moneytb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.historybutton);
            this.Controls.Add(this.statusbutton);
            this.Controls.Add(this.neworderbutton);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button neworderbutton;
        private System.Windows.Forms.Button statusbutton;
        private System.Windows.Forms.Button historybutton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox moneytb;
    }
}