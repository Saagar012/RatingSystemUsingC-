using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Forms;


namespace CourseWork
{
    public partial class customerForm : Form
    {
        public customerForm()
        {
            InitializeComponent();
        }
        private bool _isValidEmail;
        private bool _isContactNumber;
        int indexRow;
        private void btnLoad_Click(object sender, EventArgs e)
        {
            
        }

        public List<Criteria> LoadCsvData(string CsvFile)
        {
            var query = from l in File.ReadAllLines(CsvFile)
                        let data = l.Split(',')
                        select new Criteria
                        {
                            //Id = data[0],
                            CriteriaName = data[1]
                        };

            return query.ToList();
        }
        //public List<Criteria> LoadCsvData1(string CsvFile)
        //{
        //    var query = from l in File.ReadAllLines(CsvFile)
        //                let data = l.Split(',')
        //                select new Criteria
        //                {
        //                    Id = data[0],
        //                    CriteriaName = data[1]
        //                };

        //    return query.ToList();
        //}


        public class Criteria
        {
            //public string Id { get; set; }
            public string CriteriaName { get; set; }
        }
        
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dlg = new OpenFileDialog();
            //dlg.ShowDialog();
            //txt.Text = dlg.FileName;

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        DataTable table = new DataTable();
        private void customerForm_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = LoadCsvData("D:\\criteria.csv");
            //table.Columns.Add("Id", typeof(int));
            //table.Columns.Add("Criteria", typeof(string));
            //dgvData.DataSource = table;
            //string[] lines = File.ReadAllLines(@"D:\criteria.csv");
            //string[] values;
            //for (int j = 1; j < lines.Length; j++)
            //{
            //    values = lines[j].ToString().Split(',');
            //    string[] row = new string[values.Length];
            //    for (int i = 1; i < values.Length; i++)
            //    {
            //        row[i] = values[i].Trim();
            //    }
            //    table.Rows.Add(row);
            //}

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            if (Validation())
            {
                int overall = 0;
                int CriteriaValue = 0;
                //Console.WriteLine(dgvData.Rows[0].Cells[0].Value.ToString());
                for (int i = 0; i < dgvData.Rows.Count; i++)
                {
                    try
                    {
                        //string criteria;
                        string Excellent;
                        string Average;
                        string Good;
                        string Disatisfied;
                       
                        //string a=Convert.ToString(dgvData.Rows[0].Cells[0].Value);
                        //bool isCellChecked = Convert.ToBoolean(dgvData.Rows[0].Cells[0].Value);

                        if (dgvData.Rows[i].Cells[1].Value != null)
                        {

                            Average = dgvData.Rows[i].Cells[1].Value.ToString(); //true
                            if (Average == "True")
                            {
                                CriteriaValue = 2;
                               // Console.WriteLine(CriteriaValue);
                                overall = overall + CriteriaValue;

                            }
                        }
                        if (dgvData.Rows[i].Cells[2].Value != null)
                        {

                            Good = dgvData.Rows[i].Cells[2].Value.ToString(); //true
                            if (Good == "True")
                            {
                                CriteriaValue = 3;
                                //Console.WriteLine(CriteriaValue);
                                overall = overall + CriteriaValue;

                            }
                        }

                        if (dgvData.Rows[i].Cells[3].Value != null)
                        {
                            Excellent = dgvData.Rows[i].Cells[3].Value.ToString(); //True
                            if (Excellent == "True")
                            {
                                CriteriaValue = 4;
                                //Console.WriteLine(dgvData.Rows[i].Cells[3].Value.ToString());
                               // Console.WriteLine(CriteriaValue);
                                overall = overall + CriteriaValue;

                            }
                        }
                        if (dgvData.Rows[i].Cells[0].Value != null)
                        {

                            Disatisfied = dgvData.Rows[i].Cells[0].Value.ToString(); //true
                            if (Disatisfied == "True")
                            {
                                CriteriaValue = 1;
                                overall = overall + CriteriaValue;
                                //Console.WriteLine(CriteriaValue);

                            }
                        }


                    }
                    catch (InvalidCastException ex)
                    {
                        System.Windows.MessageBox.Show(" " + ex);

                    }

                    //addRecord(nameTxt.Text, contactTxt.Text, emailTxt.Text, CriteriaValue, "D:\\feedback.csv");
                    if (i == 0)
                    {
                        //if (Validation())
                        // {
                        addRecord(nameTxt.Text, contactTxt.Text, emailTxt.Text, CriteriaValue, "D:\\feedback.csv");

                        //}

                    }
                    else
                    {
                   
                        addRecord1(CriteriaValue, "D:\\feedback.csv");
            }


                }
                // if (Validation())
                //{

                addRecord2(overall, "D:\\feedback.csv");


                // }
            }

        }
        public void addRecord(string name, string contact, string email,int feedback,string filepath)
        {
            //Criteria cr = new Criteria();
            //string criteriaName= cr.CriteriaName();


            string date = DateTime.Now.ToShortDateString();
            string time = DateTime.Now.ToShortTimeString();
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                   // file.WriteLine();
                    file.Write(name + "," + contact +","+email+","+date+","+time+","+feedback+",");
                }
                System.Windows.MessageBox.Show("Data Added");
                nameTxt.Clear();
                emailTxt.Clear();
                contactTxt.Clear();

            }
            catch (Exception ex)
            {
                throw new ApplicationException("This program is not doing well", ex);
            }

        }


        public void addRecord1(int feedback, string filepath)
        {
           

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    file.Write(feedback+",");
                }
                //System.Windows.MessageBox.Show("Data Added");
                //nameTxt.Clear();
                //emailTxt.Clear();
                //contactTxt.Clear();

            }
            catch (Exception ex)
            {
                throw new ApplicationException("This program is not doing well", ex);
            }

        }

        public void addRecord2(int overall, string filepath)
        {


            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    double final = (double) overall / dgvData.Rows.Count;
                    
                    file.Write(Math.Round(final) + "\n");
                }
                //System.Windows.MessageBox.Show("Data Added");
                //nameTxt.Clear();
                //emailTxt.Clear();
                //contactTxt.Clear();

            }
            catch (Exception ex)
            {
                throw new ApplicationException("This program is not doing well", ex);
            }

        }










        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

          indexRow= dgvData.CurrentCell.RowIndex;
            //if(e.ColumnIndex==0 || e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 3)
            //{
            //    MessageBox.Show((e.RowIndesx+1).ToString()+" Row Clicked");
            //}
            //   int rowIndex = dgvData.CurrentCell.RowIndex;
            //   Console.WriteLine(rowIndex);

            //   int columnIndex = dgvData.CurrentCell.ColumnIndex;
            //   Console.WriteLine(columnIndex);

            ////   for (int i=0; i < dgvData.RowCount; i++)
            //  // {
            //       if(rowIndex==0 && dgvData.Columns[e.ColumnIndex].Name == "disatisfiedColumn")
            //       {

            //   }

            //  }
            //Check to ensure that the row CheckBox is clicked.


            //Check to ensure that the row CheckBox is clicked.
            //if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            //{
            //    //Loop and uncheck all other CheckBoxes.
            //    foreach (DataGridViewColumn row in dgvData.Columns)
            //    {
            //        if (row.Index == e.RowIndex)
            //        {
            //            row.Cells["disatisfiedColumn"].Value = !Convert.ToBoolean(row.Cells["disatisfiedColumn"].EditedFormattedValue);
            //        }
            //        else
            //        {
            //            row.Cells["disatisfiedColumn"].Value = false;
            //        }
            //    }
            //}













        }

        private void dgvData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
      

        }

        private void dgvData_Click(object sender, EventArgs e)
        {

        }

        private void contactTxt_TextChanged(object sender, EventArgs e)
        {
           _isContactNumber = isInputNumber(contactTxt.Text);
        }
        //this method is used to validate input is number or not
        private bool isInputNumber(string number)
        {
            const string validNumberPattern = "^[0-9]+$";
            return new Regex(validNumberPattern).IsMatch(number);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {  
            _isValidEmail = IsValidEmail(emailTxt.Text);
        }

        //the method validates the email input
        private bool IsValidEmail(string emailAddress)
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            return new Regex(validEmailPattern,
           RegexOptions.IgnoreCase).IsMatch(emailAddress);
            

        }
        
        public Boolean Validation()
        {
            if (nameTxt.Text.Equals(""))
            {
                System.Windows.MessageBox.Show("* Customer Name cannot be Empty!", "Alert",
               MessageBoxButton.OK, MessageBoxImage.Information);
                
                return false;
                
            }
            else if (emailTxt.Text.Equals(""))
            {
                System.Windows.MessageBox.Show("* Email Field cannot be Empty!", "Alert",
               MessageBoxButton.OK, MessageBoxImage.Information);
                return false;
            }
            else if (!_isValidEmail)
            {
                System.Windows.MessageBox.Show("* Email not valid !", "Alert",
               MessageBoxButton.OK, MessageBoxImage.Information);
                return false;
            }
            else if (contactTxt.Text.Equals(""))
            {
                System.Windows.MessageBox.Show("* Phone Number cannot be Empty", "Alert",
               MessageBoxButton.OK, MessageBoxImage.Information);
                return false;

            }
            else if (!_isContactNumber)
            {
                System.Windows.MessageBox.Show("* Please input valid Contact Number", "Alert",
               MessageBoxButton.OK, MessageBoxImage.Information);
                return false;
            }
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}