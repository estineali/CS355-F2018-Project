namespace KhanaMangwana
{
    partial class OrderHistory
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
            this.historylb = new System.Windows.Forms.ListBox();
            this.detailbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order History";
            // 
            // historylb
            // 
            this.historylb.FormattingEnabled = true;
            this.historylb.Location = new System.Drawing.Point(41, 84);
            this.historylb.Name = "historylb";
            this.historylb.Size = new System.Drawing.Size(441, 303);
            this.historylb.TabIndex = 1;
            // 
            // detailbutton
            // 
            this.detailbutton.Location = new System.Drawing.Point(407, 405);
            this.detailbutton.Name = "detailbutton";
            this.detailbutton.Size = new System.Drawing.Size(75, 24);
            this.detailbutton.TabIndex = 2;
            this.detailbutton.Text = "View Details";
            this.detailbutton.UseVisualStyleBackColor = true;
            this.detailbutton.Click += new System.EventHandler(this.detailbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(313, 405);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 24);
            this.cancelbutton.TabIndex = 3;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.detailbutton);
            this.Controls.Add(this.historylb);
            this.Controls.Add(this.label1);
            this.Name = "OrderHistory";
            this.Text = "OrderHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox historylb;
        private System.Windows.Forms.Button detailbutton;
        private System.Windows.Forms.Button cancelbutton;
    }
}