namespace CourseWork
{
    partial class AdminDashboard
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
            this.label3 = new System.Windows.Forms.Label();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.addCriteriaBtn = new System.Windows.Forms.Button();
            this.viewReportBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.viewGraphBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.logOutBtn);
            this.panel1.Controls.Add(this.addCriteriaBtn);
            this.panel1.Controls.Add(this.viewReportBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.viewGraphBtn);
            this.panel1.Font = new System.Drawing.Font("Sama", 8.25F);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 517);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(13, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(750, 2);
            this.label3.TabIndex = 10;
            // 
            // logOutBtn
            // 
            this.logOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutBtn.Font = new System.Drawing.Font("Lucida Bright", 22.2F);
            this.logOutBtn.ForeColor = System.Drawing.Color.Red;
            this.logOutBtn.Location = new System.Drawing.Point(144, 390);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(477, 64);
            this.logOutBtn.TabIndex = 6;
            this.logOutBtn.Text = "LOG OUT";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // addCriteriaBtn
            // 
            this.addCriteriaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCriteriaBtn.Font = new System.Drawing.Font("Lucida Bright", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCriteriaBtn.ForeColor = System.Drawing.Color.Red;
            this.addCriteriaBtn.Location = new System.Drawing.Point(144, 121);
            this.addCriteriaBtn.Name = "addCriteriaBtn";
            this.addCriteriaBtn.Size = new System.Drawing.Size(477, 68);
            this.addCriteriaBtn.TabIndex = 5;
            this.addCriteriaBtn.Text = "ADD CRITERIA";
            this.addCriteriaBtn.UseVisualStyleBackColor = true;
            this.addCriteriaBtn.BackColorChanged += new System.EventHandler(this.button2_BackColorChanged);
            this.addCriteriaBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // viewReportBtn
            // 
            this.viewReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewReportBtn.Font = new System.Drawing.Font("Lucida Bright", 22.2F);
            this.viewReportBtn.ForeColor = System.Drawing.Color.Red;
            this.viewReportBtn.Location = new System.Drawing.Point(144, 218);
            this.viewReportBtn.Name = "viewReportBtn";
            this.viewReportBtn.Size = new System.Drawing.Size(477, 68);
            this.viewReportBtn.TabIndex = 4;
            this.viewReportBtn.Text = "VIEW REPORT";
            this.viewReportBtn.UseVisualStyleBackColor = true;
            this.viewReportBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(120, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(730, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "* ADMIN DASHBOARD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // viewGraphBtn
            // 
            this.viewGraphBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewGraphBtn.Font = new System.Drawing.Font("Lucida Bright", 22.2F);
            this.viewGraphBtn.ForeColor = System.Drawing.Color.Red;
            this.viewGraphBtn.Location = new System.Drawing.Point(144, 311);
            this.viewGraphBtn.Name = "viewGraphBtn";
            this.viewGraphBtn.Size = new System.Drawing.Size(477, 64);
            this.viewGraphBtn.TabIndex = 2;
            this.viewGraphBtn.Text = "VIEW GRAPH";
            this.viewGraphBtn.UseVisualStyleBackColor = true;
            this.viewGraphBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 513);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button viewGraphBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewReportBtn;
        private System.Windows.Forms.Button addCriteriaBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Label label3;
    }
}