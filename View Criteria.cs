using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System;
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
using DataTable = System.Data.DataTable;

namespace CourseWork
{
    public partial class View_Criteria : Form
    {
        public View_Criteria()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        int indexRow;
        public class Criteria
        {
            public string Id { get; set; }
            public string CriteriaName { get; set; }
        }
       
        private void View_Criteria_Load(object sender, EventArgs e)
        {

            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Criteria", typeof(string));
            dataGridView1.DataSource = table;
            string[] lines = File.ReadAllLines(@"D:\criteria.csv");
            string[] values;
            for (int j = 0; j < lines.Length; j++)
            {
                values = lines[j].ToString().Split(',');
                string[] row = new string[values.Length];
                for (int i = 0; i < values.Length; i++)
                {
                    row[i] = values[i].Trim();
                }
                table.Rows.Add(row);
            }

        }

private void button1_Click(object sender, EventArgs e)
        {
            if (txtBoxId.Text != "" && userTxtBox.Text != "")
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(rowIndex);

                _Application docExcel = new Microsoft.Office.Interop.Excel.Application { Visible = false };
                dynamic workbooksExcel = docExcel.Workbooks.Open("D:\\criteria.csv");
                var worksheetExcel = (_Worksheet)workbooksExcel.ActiveSheet;
                ((Range)worksheetExcel.Rows[rowIndex + 1, Missing.Value]).Delete(XlDeleteShiftDirection.xlShiftUp);
                workbooksExcel.Save();
                workbooksExcel.Close(false);
                docExcel.Application.Quit();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            indexRow = e.RowIndex;
            DataGridViewRow rows = dataGridView1.Rows[indexRow];
            
            txtBoxId.Text = rows.Cells[0].Value.ToString();
            userTxtBox.Text = rows.Cells[1].Value.ToString();



        }
     
        int id;
        string criteriaName;
        private void button3_Click(object sender, EventArgs e)
        {

            if (txtBoxId.Text != "" && userTxtBox.Text != "")
            {
                DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];
                newDataRow.Cells[0].Value = txtBoxId.Text;
                newDataRow.Cells[1].Value = userTxtBox.Text;


                //clearing the whole data from the excel.
                var excel = new Microsoft.Office.Interop.Excel.Application();
                var workbook = excel.Workbooks.Open("D:\\criteria.csv");

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


                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value != null)
                    {
                        id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                        criteriaName = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        if (i == 0)
                        {
                           
                            addRecord(id, criteriaName, "D:\\criteria.csv");
                        }
                        else
                        {
                            addRecord(id, criteriaName, "D:\\criteria.csv");
                            Console.WriteLine(id + ", " + criteriaName);
                        }
                    }
                    
                 
                }


                //xlApp = new Microsoft.Office.Interop.Excel.Application();
                //xlWorkBook = xlApp.Workbooks.Open("D:\\criteria1234.csv");

                //xlWorkSheet = xlWorkBook.Worksheets["criteria1234"];

                //// get number of rows in the sheet
                //int rows = xlWorkSheet.Rows.Count; // 10

                //// loop through the worksheet rows
                //for (int i = 1; i <= rows; i++)
                //{
                //    // replace occurences
                //    //if (worksheet.Cells[i, 2].Value.ToString() == "Central")
                //    //    worksheet.Cells[i, 2].Value = "ABCD";

                //    xlWorkSheet.Cells[i, 1].Value = newDataRow.Cells[i-1].Value;
                //}

                //for (int i = 1; i <= rows; i++)
                //{
                //    xlWorkSheet.Cells[i, 2].Value = newDataRow.Cells[i].Value;
                //}
                // save changes
                deleteBlankRow();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");

            }

        }

        public void deleteBlankRow()
        {
            _Application docExcel = new Microsoft.Office.Interop.Excel.Application { Visible = false };
            dynamic workbooksExcel = docExcel.Workbooks.Open("D:\\criteria.csv");
            var worksheetExcel = (_Worksheet)workbooksExcel.ActiveSheet;
            ((Range)worksheetExcel.Rows[1, Missing.Value]).Delete(XlDeleteShiftDirection.xlShiftUp);
            workbooksExcel.Save();
            workbooksExcel.Close(false);
            docExcel.Application.Quit();
        }

        public void addRecord(int Id, string name, string filepath)
        {
            
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    file.Write(Id + "," + name + "\n");
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("This program is not doing well", ex);
            }
        }
    }
}
