namespace KhanaMangwana
{
    partial class ReviewHistory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.historylistbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.detailsbutton = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.historylistbox);
            this.groupBox1.Location = new System.Drawing.Point(37, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Reviews";
            // 
            // historylistbox
            // 
            this.historylistbox.FormattingEnabled = true;
            this.historylistbox.Location = new System.Drawing.Point(0, 24);
            this.historylistbox.Name = "historylistbox";
            this.historylistbox.Size = new System.Drawing.Size(401, 277);
            this.historylistbox.TabIndex = 0;
            this.historylistbox.SelectedIndexChanged += new System.EventHandler(this.historylistbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Review History";
            // 
            // detailsbutton
            // 
            this.detailsbutton.Location = new System.Drawing.Point(363, 411);
            this.detailsbutton.Name = "detailsbutton";
            this.detailsbutton.Size = new System.Drawing.Size(75, 23);
            this.detailsbutton.TabIndex = 2;
            this.detailsbutton.Text = "View Details";
            this.detailsbutton.UseVisualStyleBackColor = true;
            this.detailsbutton.Click += new System.EventHandler(this.detailsbutton_Click);
            // 
            // closebutton
            // 
            this.closebutton.Location = new System.Drawing.Point(265, 411);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(75, 23);
            this.closebutton.TabIndex = 3;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // ReviewHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 446);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.detailsbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReviewHistory";
            this.Text = "ReviewHistory";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox historylistbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button detailsbutton;
        private System.Windows.Forms.Button closebutton;
    }
}