namespace KhanaMangwana
{
    partial class UserHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHome));
            this.orderlink = new System.Windows.Forms.LinkLabel();
            this.menulink = new System.Windows.Forms.LinkLabel();
            this.balancelink = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // orderlink
            // 
            this.orderlink.AutoSize = true;
            this.orderlink.Font = new System.Drawing.Font("Roboto Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderlink.LinkColor = System.Drawing.Color.Black;
            this.orderlink.Location = new System.Drawing.Point(131, 73);
            this.orderlink.Name = "orderlink";
            this.orderlink.Size = new System.Drawing.Size(116, 33);
            this.orderlink.TabIndex = 0;
            this.orderlink.TabStop = true;
            this.orderlink.Text = "ORDERS";
            this.orderlink.VisitedLinkColor = System.Drawing.Color.Red;
            this.orderlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.orderlink_LinkClicked);
            // 
            // menulink
            // 
            this.menulink.AutoSize = true;
            this.menulink.Font = new System.Drawing.Font("Roboto Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menulink.LinkColor = System.Drawing.Color.Black;
            this.menulink.Location = new System.Drawing.Point(144, 130);
            this.menulink.Name = "menulink";
            this.menulink.Size = new System.Drawing.Size(90, 33);
            this.menulink.TabIndex = 3;
            this.menulink.TabStop = true;
            this.menulink.Text = "MENU";
            this.menulink.VisitedLinkColor = System.Drawing.Color.Red;
            this.menulink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.menulink_LinkClicked);
            // 
            // balancelink
            // 
            this.balancelink.AutoSize = true;
            this.balancelink.Font = new System.Drawing.Font("Roboto Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balancelink.LinkColor = System.Drawing.Color.Black;
            this.balancelink.Location = new System.Drawing.Point(69, 190);
            this.balancelink.Name = "balancelink";
            this.balancelink.Size = new System.Drawing.Size(246, 33);
            this.balancelink.TabIndex = 4;
            this.balancelink.TabStop = true;
            this.balancelink.Text = "ACCOUNT INQUIRY";
            this.balancelink.VisitedLinkColor = System.Drawing.Color.Red;
            this.balancelink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.balancelink_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Roboto Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(133, 247);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(116, 33);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LOGOUT";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(381, 359);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.balancelink);
            this.Controls.Add(this.menulink);
            this.Controls.Add(this.orderlink);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel orderlink;
        private System.Windows.Forms.LinkLabel menulink;
        private System.Windows.Forms.LinkLabel balancelink;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}