namespace CourseWork
{
    partial class AddCriteria
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
            this.label2 = new System.Windows.Forms.Label();
            this.userTxtBox = new System.Windows.Forms.TextBox();
            this.addCriteriaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.viewCriteriaBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 16.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Criteria :";
            // 
            // userTxtBox
            // 
            this.userTxtBox.Font = new System.Drawing.Font("Mongolian Baiti", 15F);
            this.userTxtBox.Location = new System.Drawing.Point(227, 152);
            this.userTxtBox.Multiline = true;
            this.userTxtBox.Name = "userTxtBox";
            this.userTxtBox.Size = new System.Drawing.Size(248, 30);
            this.userTxtBox.TabIndex = 4;
            // 
            // addCriteriaBtn
            // 
            this.addCriteriaBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addCriteriaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCriteriaBtn.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCriteriaBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addCriteriaBtn.Location = new System.Drawing.Point(108, 203);
            this.addCriteriaBtn.Name = "addCriteriaBtn";
            this.addCriteriaBtn.Size = new System.Drawing.Size(387, 41);
            this.addCriteriaBtn.TabIndex = 6;
            this.addCriteriaBtn.Text = "ADD CRITERIA";
            this.addCriteriaBtn.UseVisualStyleBackColor = false;
            this.addCriteriaBtn.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.8F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(113, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID :";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxId.Location = new System.Drawing.Point(227, 99);
            this.txtBoxId.Multiline = true;
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(248, 30);
            this.txtBoxId.TabIndex = 8;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Red;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cancelBtn.Location = new System.Drawing.Point(108, 315);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(387, 41);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewCriteriaBtn
            // 
            this.viewCriteriaBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.viewCriteriaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewCriteriaBtn.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCriteriaBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.viewCriteriaBtn.Location = new System.Drawing.Point(109, 259);
            this.viewCriteriaBtn.Name = "viewCriteriaBtn";
            this.viewCriteriaBtn.Size = new System.Drawing.Size(387, 41);
            this.viewCriteriaBtn.TabIndex = 10;
            this.viewCriteriaBtn.Text = "VIEW CRITERIA";
            this.viewCriteriaBtn.UseVisualStyleBackColor = false;
            this.viewCriteriaBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 16.8F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 34);
            this.label3.TabIndex = 11;
            this.label3.Text = "*";
            // 
            // AddCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.viewCriteriaBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addCriteriaBtn);
            this.Controls.Add(this.userTxtBox);
            this.Controls.Add(this.label2);
            this.Name = "AddCriteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCriteria";
            this.Load += new System.EventHandler(this.AddCriteria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userTxtBox;
        private System.Windows.Forms.Button addCriteriaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button viewCriteriaBtn;
        private System.Windows.Forms.Label label3;
    }
}