using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CourseWork
{
    public partial class RatingReport : Form
    {
        public RatingReport()
        {
            InitializeComponent();
            ShowPieChart();

        }

        ArrayList feedBack = new ArrayList();
        ArrayList feedbackcount = new ArrayList();

        private void RatingReport_Load(object sender, EventArgs e)
        {

        }
        public List<Feedback1> LoadCsvData(string CsvFile)
        {
            var query = from l in File.ReadAllLines(CsvFile)
                        let data = l.Split(',')
                        select new Feedback1
                        {
                            Feedbacks = data[0],
                            Count = data[1]
                        };

            return query.ToList();
        }

        public List<Feedback> LoadCsvData1(string CsvFile)
        {
            var query = from l in File.ReadAllLines(CsvFile)
                        let data = l.Split(',')
                        select new Feedback
                        {
                            Name = data[0],
                            OverallRating = data[11]
                        };

            return query.ToList();
        }

        public class Feedback
        {
            public string Name { get; set; }
            public string OverallRating { get; set; }
        }






        public class Feedback1
        {
            public string Feedbacks { get; set; }
            public string Count { get; set; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    if (dataGridView1.Rows[i].Cells[1].Value != null)
            //    {
            //        criteria.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
            //        //Console.WriteLine(dataGridView1.Rows[i].Cells[1].Value.ToString());


            //    }

            //}
            //for (int j = 0; j < criteria.Count; j++)
            //{
            //    Console.WriteLine(criteria[j].ToString());
            //}

            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    if (dataGridView1.Rows[i].Cells[1].Value != null)
            //    {
            //        criteria.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
            //       // Console.WriteLine(dataGridView1.Rows[i].Cells[1].Value.ToString());
            //    }

            //}


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value != null)
                {
                    feedBack.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    // Console.WriteLine(dataGridView1.Rows[i].Cells[1].Value.ToString());
                }

            }
            //feedBack.Add("Excellent");
            //feedBack.Add("Good");
            //feedBack.Add("Average");
            //feedBack.Add("Disatisfied");
           
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value != null)
                {
                    feedbackcount.Add(dataGridView1.Rows[i].Cells[1].Value);
                    // Console.WriteLine(dataGridView1.Rows[i].Cells[1].Value.ToString());
                }

            }

            //double[] RatingArray = { 3.5, 4.0, 2.5, 3.0, 5.0, };

            chart1.Series.Add("Total Rating");

            for (int i = 0; i < feedBack.Count; i++)
            {
                //Console.Write(feedBack[i].ToString() + " ");
                //Console.WriteLine(rating[i].ToString());
                chart1.Series[0].Points.AddXY(feedBack[i], feedbackcount[i]);
                

            }

            this.chart1.Series[0]["PieLabelStyle"] = "Outside";

            // Set border width so that labels are shown on the outside
            this.chart1.Series[0].BorderWidth = 1;
            this.chart1.Series[0].BorderColor = System.Drawing.Color.FromArgb(26, 59, 105);

            // Add a legend to the chart and dock it to the bottom-center
            //this.chart1.Legends.Add("Legend2");
            this.chart1.Legends[0].Enabled = true;
            this.chart1.Legends[0].Docking = Docking.Bottom;
            this.chart1.Legends[0].Alignment = System.Drawing.StringAlignment.Center;

            // Set the legend to display pie chart values as percentages
            // Again, the P2 indicates a precision of 2 decimals
            this.chart1.Series[0].LegendText = "#PERCENT{P2}";

            // By sorting the data points, they show up in proper ascending order in the legend
            this.chart1.DataManipulator.Sort(PointSortOrder.Descending, chart1.Series[0]);


            //chart1.Series[0].ChartType = SeriesChartType.Column;
            chart1.Series[0].ChartType = SeriesChartType.Pie;

            chart1.Titles.Add("Pie Chart for Ratings on Service Criteria");

        }










        void ShowPieChart()
        {

        }
            private void chartRating_Click(object sender, EventArgs e)
        {

        }

        private void RatingReport_Load_1(object sender, EventArgs e)
        {
           

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        OpenFileDialog openFileDialog = new OpenFileDialog();
        //        openFileDialog.ShowDialog();
        //        string fn = openFileDialog.FileName;
        //        string readfile = File.ReadAllText(fn);
        //        string[] line = readfile.Split('\n');
        //        int count = 0;
        //        foreach (string s1 in line[0].Split(','))
        //        {
        //            count++;
        //        }
        //        dataGridView1.ColumnCount = count;
        //        foreach (string s1 in readfile.Split('\n'))
        //        {
        //            if (s1 != "")
        //                dataGridView1.Rows.Add(s1.Split(','));
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("sorry");
        //    }
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(dataGridView1.Rows[0].Cells[1].Value.ToString());
           // if ( == null)
            //{
                dataGridView1.DataSource = LoadCsvData("D:\\FeedbackCount.csv");
                // DataTable table = new DataTable();
                //table.Columns.Add("Id", typeof(int));
                //table.Columns.Add("Criteria", typeof(string));
                //dataGridView1.DataSource = table;
                //string[] lines = File.ReadAllLines(@"D:\criteria.csv");
                //string[] values;
                //for (int j = 0; j < lines.Length; j++)
                //{
                //    values = lines[j].ToString().Split(',');
                //    string[] row = new string[values.Length];
                //    for (int i = 0; i < values.Length; i++)
                //    {
                //        row[i] = values[i].Trim();
                //    }
                //    table.Rows.Add(row);
                //}



                ////Console.WriteLine(dgvData.Rows[0].Cells[0].Value.ToString());
                //for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                //{
                //    int[] row= new int[dataGridView1.Rows.Count]; ;

                //    try
                //    {


                //        //string a=Convert.ToString(dgvData.Rows[0].Cells[0].Value);
                //        //bool isCellChecked = Convert.ToBoolean(dgvData.Rows[0].Cells[0].Value);
                //        Console.WriteLine(dataGridView1.Rows[i].Cells[0].Value);



                //    }
                //    catch (InvalidCastException ex)
                //    {
                //        MessageBox.Show(" " + ex);

                //    }
                //    //addRecord(nameTxt.Text, contactTxt.Text, emailTxt.Text, CriteriaValue, "D:\\feedback.csv");


           // }
            //}
        }
        int CountExcellent = 0;
        int CountAverage = 0;
        int CountGood = 0;
        int CountDisatisfied = 0;

        private void button4_Click(object sender, EventArgs e)
        {

            dataGridView2.DataSource = LoadCsvData1("D:\\feedback.csv");
            //DataTable table = new DataTable();
            //table.Columns.Add("Name", typeof(string));
            //table.Columns.Add("Phone", typeof(string));
            //table.Columns.Add("Email", typeof(string));
            //table.Columns.Add("Date", typeof(string));
            //table.Columns.Add("Time", typeof(string));
            //table.Columns.Add("Food Quality", typeof(string));
            //table.Columns.Add("Friendliness", typeof(string));
            //table.Columns.Add("Cleanliness", typeof(string));
            //table.Columns.Add("Order Accuracy", typeof(string));
            //table.Columns.Add("Restaurant Ambiences", typeof(string));
            //table.Columns.Add("Value For Money", typeof(string));
            //table.Columns.Add("Overall ", typeof(string));

            //dataGridView2.DataSource = table;
            //string[] lines = File.ReadAllLines(@"D:\feedback.csv");
            //string[] values;
            //for (int j = 1; j < lines.Length; j++)
            //{
            //    values = lines[j].ToString().Split(',');
            //    string[] row = new string[values.Length];
            //    for (int i = 0; i < values.Length; i++)
            //    {
            //        row[i] = values[i].Trim();
            //    }
            //    table.Rows.Add(row);
            //}

            //clearing the whole data from the excel.
            var excel = new Microsoft.Office.Interop.Excel.Application();
            var workbook = excel.Workbooks.Open("D:\\FeedbackCount.csv");

            try
            {
                foreach (dynamic worksheet in workbook.Worksheets)
                {
                    worksheet.Cells.ClearContents();
                }

                workbook.Save();
            }
            finally
            {
                workbook.Close();
                excel.Quit();
            }


            //if (excellent+1)good average poor disasti
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                try
                {

                   

                    //string a=Convert.ToString(dgvData.Rows[0].Cells[0].Value);
                    //bool isCellChecked = Convert.ToBoolean(dgvData.Rows[0].Cells[0].Value);



                    if (dataGridView2.Rows[i].Cells[1].Value != null)
                    {

                        if (Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value) == 1)
                        {
                            CountDisatisfied = CountDisatisfied + 1;
                        }; //true
                        if (Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value) == 2)
                        {
                            CountAverage = CountAverage + 1;

                        }
                        if (Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value) == 3)
                        {
                            CountGood = CountGood + 1;

                        }
                        if (Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value) == 4)
                        {
                            CountExcellent = CountExcellent + 1;

                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }


            }
            addRecord(CountExcellent,CountGood, CountAverage, CountDisatisfied, "D:\\FeedbackCount.csv");
            deleteBlankRow();
        }

        public void addRecord(int excellent, int average, int good, int dissatisfied, string filepath)
        {
          
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    // file.WriteLine();

                    file.Write("Excellent" +","+ excellent + "\n"+ "Good" + "," + good + "\n"+ "Average" + "," + average + "\n"+ "Disatisfied" + ","+ dissatisfied+ "\n");
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("This program is not doing well", ex);
            }

        }
        public void deleteBlankRow()
        {
            _Application docExcel = new Microsoft.Office.Interop.Excel.Application { Visible = false };
            dynamic workbooksExcel = docExcel.Workbooks.Open("D:\\FeedbackCount.csv");
            var worksheetExcel = (_Worksheet)workbooksExcel.ActiveSheet;
            ((Range)worksheetExcel.Rows[1, Missing.Value]).Delete(XlDeleteShiftDirection.xlShiftUp);
            workbooksExcel.Save();
            workbooksExcel.Close(false);
            docExcel.Application.Quit();
        }
    }
}
