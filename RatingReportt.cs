using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace CourseWork
{
    public partial class RatingReportt : Form
    {
        public RatingReportt()
        {
            InitializeComponent();
        }
       

        
        private void button3_Click(object sender, EventArgs e)

        {
            _Application docExcel = new Microsoft.Office.Interop.Excel.Application { Visible = false };
            dynamic workbooksExcel = docExcel.Workbooks.Open("D:\\criteria123.csv");
            var worksheetExcel = (_Worksheet)workbooksExcel.ActiveSheet;

            ((Range)worksheetExcel.Rows[1, Missing.Value]).Delete(XlDeleteShiftDirection.xlShiftUp);

            workbooksExcel.Save();
            workbooksExcel.Close(false);
            docExcel.Application.Quit();

        }
    }
}

