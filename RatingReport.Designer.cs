namespace CourseWork
{
    partial class RatingReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoadCriteria = new System.Windows.Forms.Button();
            this.btnDisplayChart = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnLoadRating = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(270, 345);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(499, 257);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(522, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(304, 199);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnLoadCriteria
            // 
            this.btnLoadCriteria.BackColor = System.Drawing.Color.Linen;
            this.btnLoadCriteria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadCriteria.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLoadCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadCriteria.ForeColor = System.Drawing.Color.Crimson;
            this.btnLoadCriteria.Location = new System.Drawing.Point(522, 269);
            this.btnLoadCriteria.Name = "btnLoadCriteria";
            this.btnLoadCriteria.Size = new System.Drawing.Size(247, 50);
            this.btnLoadCriteria.TabIndex = 6;
            this.btnLoadCriteria.Text = "Load Total NO. Of Rating";
            this.btnLoadCriteria.UseVisualStyleBackColor = false;
            this.btnLoadCriteria.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDisplayChart
            // 
            this.btnDisplayChart.BackColor = System.Drawing.Color.Red;
            this.btnDisplayChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplayChart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDisplayChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayChart.ForeColor = System.Drawing.Color.White;
            this.btnDisplayChart.Location = new System.Drawing.Point(385, 617);
            this.btnDisplayChart.Name = "btnDisplayChart";
            this.btnDisplayChart.Size = new System.Drawing.Size(294, 49);
            this.btnDisplayChart.TabIndex = 7;
            this.btnDisplayChart.Text = "Display Chart";
            this.btnDisplayChart.UseVisualStyleBackColor = false;
            this.btnDisplayChart.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView2.Location = new System.Drawing.Point(146, 64);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(309, 199);
            this.dataGridView2.TabIndex = 8;
            // 
            // btnLoadRating
            // 
            this.btnLoadRating.BackColor = System.Drawing.Color.Linen;
            this.btnLoadRating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadRating.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLoadRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadRating.ForeColor = System.Drawing.Color.Crimson;
            this.btnLoadRating.Location = new System.Drawing.Point(146, 269);
            this.btnLoadRating.Name = "btnLoadRating";
            this.btnLoadRating.Size = new System.Drawing.Size(227, 50);
            this.btnLoadRating.TabIndex = 9;
            this.btnLoadRating.Text = "Load Overall Rating";
            this.btnLoadRating.UseVisualStyleBackColor = false;
            this.btnLoadRating.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(353, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 42);
            this.label4.TabIndex = 16;
            this.label4.Text = "* VIEW GRAPH";
            // 
            // RatingReport
            // 
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1026, 688);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLoadRating);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnDisplayChart);
            this.Controls.Add(this.btnLoadCriteria);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.MaximizeBox = false;
            this.Name = "RatingReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Graph";
            this.Load += new System.EventHandler(this.RatingReport_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoadCriteria;
        private System.Windows.Forms.Button btnDisplayChart;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnLoadRating;
        private System.Windows.Forms.Label label4;
    }
}