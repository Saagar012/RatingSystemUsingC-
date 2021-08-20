namespace CourseWork
{
    partial class customerForm
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.disatisfiedColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.avgColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.goodColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.excellentColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.contactTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvData.ColumnHeadersHeight = 50;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.disatisfiedColumn,
            this.avgColumn,
            this.goodColumn,
            this.excellentColumn});
            this.dgvData.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvData.Location = new System.Drawing.Point(23, 226);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvData.RowHeadersWidth = 45;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(826, 346);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellValueChanged);
            this.dgvData.Click += new System.EventHandler(this.dgvData_Click);
            // 
            // disatisfiedColumn
            // 
            this.disatisfiedColumn.HeaderText = "Disatisfied";
            this.disatisfiedColumn.MinimumWidth = 6;
            this.disatisfiedColumn.Name = "disatisfiedColumn";
            this.disatisfiedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.disatisfiedColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // avgColumn
            // 
            this.avgColumn.HeaderText = "Average";
            this.avgColumn.MinimumWidth = 6;
            this.avgColumn.Name = "avgColumn";
            this.avgColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // goodColumn
            // 
            this.goodColumn.HeaderText = "Good";
            this.goodColumn.MinimumWidth = 6;
            this.goodColumn.Name = "goodColumn";
            this.goodColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // excellentColumn
            // 
            this.excellentColumn.HeaderText = "Excellent";
            this.excellentColumn.MinimumWidth = 6;
            this.excellentColumn.Name = "excellentColumn";
            this.excellentColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.excellentColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.nameTxt.Location = new System.Drawing.Point(456, 73);
            this.nameTxt.Multiline = true;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(323, 37);
            this.nameTxt.TabIndex = 9;
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.emailTxt.Location = new System.Drawing.Point(456, 124);
            this.emailTxt.Multiline = true;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(323, 37);
            this.emailTxt.TabIndex = 10;
            this.emailTxt.TextChanged += new System.EventHandler(this.emailTxt_TextChanged);
            // 
            // contactTxt
            // 
            this.contactTxt.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.contactTxt.Location = new System.Drawing.Point(456, 174);
            this.contactTxt.Multiline = true;
            this.contactTxt.Name = "contactTxt";
            this.contactTxt.Size = new System.Drawing.Size(323, 37);
            this.contactTxt.TabIndex = 11;
            this.contactTxt.TextChanged += new System.EventHandler(this.contactTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "CustomerName  :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(259, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 43);
            this.label4.TabIndex = 15;
            this.label4.Text = "** Customer Form";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSave.Location = new System.Drawing.Point(140, 591);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(317, 52);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "SAVE DATA";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.label5.Location = new System.Drawing.Point(191, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 31);
            this.label5.TabIndex = 17;
            this.label5.Text = "CustomerEmail  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.label2.Location = new System.Drawing.Point(191, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "CustomerPhone :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(510, 591);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 52);
            this.button1.TabIndex = 19;
            this.button1.Text = "LOG OUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(861, 666);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contactTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.dgvData);
            this.Name = "customerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customerForm";
            this.Load += new System.EventHandler(this.customerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox contactTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn disatisfiedColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn avgColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn goodColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn excellentColumn;
    }
}