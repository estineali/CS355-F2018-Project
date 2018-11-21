namespace KhanaMangwana
{
    partial class Admin
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
            this.label2 = new System.Windows.Forms.Label();
            this.pendingorderslink = new System.Windows.Forms.LinkLabel();
            this.allOrderslink = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.EditMenulink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADMINISTRATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome!";
            // 
            // pendingorderslink
            // 
            this.pendingorderslink.AutoSize = true;
            this.pendingorderslink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingorderslink.LinkColor = System.Drawing.Color.Fuchsia;
            this.pendingorderslink.Location = new System.Drawing.Point(85, 156);
            this.pendingorderslink.Name = "pendingorderslink";
            this.pendingorderslink.Size = new System.Drawing.Size(144, 24);
            this.pendingorderslink.TabIndex = 4;
            this.pendingorderslink.TabStop = true;
            this.pendingorderslink.Text = "Pending Orders";
            this.pendingorderslink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // allOrderslink
            // 
            this.allOrderslink.AutoSize = true;
            this.allOrderslink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allOrderslink.LinkColor = System.Drawing.Color.Fuchsia;
            this.allOrderslink.Location = new System.Drawing.Point(108, 216);
            this.allOrderslink.Name = "allOrderslink";
            this.allOrderslink.Size = new System.Drawing.Size(94, 24);
            this.allOrderslink.TabIndex = 5;
            this.allOrderslink.TabStop = true;
            this.allOrderslink.Text = "All Orders";
            this.allOrderslink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditMenulink
            // 
            this.EditMenulink.AutoSize = true;
            this.EditMenulink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditMenulink.LinkColor = System.Drawing.Color.Fuchsia;
            this.EditMenulink.Location = new System.Drawing.Point(108, 270);
            this.EditMenulink.Name = "EditMenulink";
            this.EditMenulink.Size = new System.Drawing.Size(96, 24);
            this.EditMenulink.TabIndex = 7;
            this.EditMenulink.TabStop = true;
            this.EditMenulink.Text = "Edit Menu";
            this.EditMenulink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EditMenu_LinkClicked);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 382);
            this.Controls.Add(this.EditMenulink);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.allOrderslink);
            this.Controls.Add(this.pendingorderslink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel pendingorderslink;
        private System.Windows.Forms.LinkLabel allOrderslink;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel EditMenulink;
    }
}

