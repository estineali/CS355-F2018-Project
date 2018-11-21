namespace KhanaMangwana
{
    partial class Form3
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
            this.orderlink = new System.Windows.Forms.LinkLabel();
            this.menulink = new System.Windows.Forms.LinkLabel();
            this.balancelink = new System.Windows.Forms.LinkLabel();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderlink
            // 
            this.orderlink.AutoSize = true;
            this.orderlink.Font = new System.Drawing.Font("Simplified Arabic Fixed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderlink.LinkColor = System.Drawing.Color.White;
            this.orderlink.Location = new System.Drawing.Point(131, 88);
            this.orderlink.Name = "orderlink";
            this.orderlink.Size = new System.Drawing.Size(117, 33);
            this.orderlink.TabIndex = 0;
            this.orderlink.TabStop = true;
            this.orderlink.Text = "ORDERS";
            this.orderlink.VisitedLinkColor = System.Drawing.Color.Red;
            this.orderlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.orderlink_LinkClicked);
            // 
            // menulink
            // 
            this.menulink.AutoSize = true;
            this.menulink.Font = new System.Drawing.Font("Simplified Arabic Fixed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menulink.LinkColor = System.Drawing.Color.White;
            this.menulink.Location = new System.Drawing.Point(144, 153);
            this.menulink.Name = "menulink";
            this.menulink.Size = new System.Drawing.Size(83, 33);
            this.menulink.TabIndex = 3;
            this.menulink.TabStop = true;
            this.menulink.Text = "MENU";
            this.menulink.VisitedLinkColor = System.Drawing.Color.Red;
            this.menulink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.menulink_LinkClicked);
            // 
            // balancelink
            // 
            this.balancelink.AutoSize = true;
            this.balancelink.Font = new System.Drawing.Font("Simplified Arabic Fixed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balancelink.LinkColor = System.Drawing.Color.White;
            this.balancelink.Location = new System.Drawing.Point(69, 211);
            this.balancelink.Name = "balancelink";
            this.balancelink.Size = new System.Drawing.Size(270, 33);
            this.balancelink.TabIndex = 4;
            this.balancelink.TabStop = true;
            this.balancelink.Text = "ACCOUNT INQUIRY";
            this.balancelink.VisitedLinkColor = System.Drawing.Color.Red;
            this.balancelink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.balancelink_LinkClicked);
            // 
            // logoutbutton
            // 
            this.logoutbutton.Location = new System.Drawing.Point(150, 282);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(75, 23);
            this.logoutbutton.TabIndex = 6;
            this.logoutbutton.Text = "LOGOUT";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(381, 359);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.balancelink);
            this.Controls.Add(this.menulink);
            this.Controls.Add(this.orderlink);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel orderlink;
        private System.Windows.Forms.LinkLabel menulink;
        private System.Windows.Forms.LinkLabel balancelink;
        private System.Windows.Forms.Button logoutbutton;
    }
}