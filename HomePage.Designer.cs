namespace CourseWork
{
    partial class HomePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminDashLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.customerDashLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.adminDashLabel);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(90, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 91);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // adminDashLabel
            // 
            this.adminDashLabel.AutoSize = true;
            this.adminDashLabel.BackColor = System.Drawing.Color.LightBlue;
            this.adminDashLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminDashLabel.Font = new System.Drawing.Font("Footlight MT Light", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminDashLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.adminDashLabel.Location = new System.Drawing.Point(52, 25);
            this.adminDashLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adminDashLabel.Name = "adminDashLabel";
            this.adminDashLabel.Size = new System.Drawing.Size(305, 38);
            this.adminDashLabel.TabIndex = 0;
            this.adminDashLabel.Text = "   Admin DashBoard";
            this.adminDashLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.customerDashLabel);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(90, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 91);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "*";
            // 
            // customerDashLabel
            // 
            this.customerDashLabel.AutoSize = true;
            this.customerDashLabel.BackColor = System.Drawing.Color.LightBlue;
            this.customerDashLabel.Font = new System.Drawing.Font("Footlight MT Light", 21F);
            this.customerDashLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.customerDashLabel.Location = new System.Drawing.Point(52, 25);
            this.customerDashLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerDashLabel.Name = "customerDashLabel";
            this.customerDashLabel.Size = new System.Drawing.Size(321, 38);
            this.customerDashLabel.TabIndex = 0;
            this.customerDashLabel.Text = "Customer DashBoard";
            this.customerDashLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(38, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(556, 2);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(21, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "HOME PAGE *";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label adminDashLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label customerDashLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}