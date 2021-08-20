using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseWork
{
    public partial class Customer_Form : Form
    {
        public Customer_Form()
        {
            InitializeComponent();
        }

        private void Customer_Form_Load(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = LoadCsvData("D:\\criteria.csv");
            // create a text columns
            DataGridViewTextBoxColumn dgvcId = new DataGridViewTextBoxColumn();
            dgvcId.HeaderText = "Id";
            DataGridViewTextBoxColumn dgvcFn = new DataGridViewTextBoxColumn();
            dgvcFn.HeaderText = "First Name";
            DataGridViewTextBoxColumn dgvcLn = new DataGridViewTextBoxColumn();
            dgvcLn.HeaderText = "Last Name";

            //// create checkbox column
            //DataGridViewCheckBoxColumn dgvcCheckBox = new DataGridViewCheckBoxColumn();
            //dgvcCheckBox.HeaderText = "Delete";

            //DataGridViewCheckBoxColumn dgvcCheckBox1 = new DataGridViewCheckBoxColumn();
            //dgvcCheckBox1.HeaderText = "Delete1";

            // add columns to datagridview
            dataGridView1.Columns.Add(dgvcId);
            dataGridView1.Columns.Add(dgvcFn);
            dataGridView1.Columns.Add(dgvcLn);
            //dataGridView1.Columns.Add(dgvcCheckBox);
            //dataGridView1.Columns.Add(dgvcCheckBox1);
            // add some row to datagridview
            // true the checkBox Is checked
            // false the checkBox Is Not checked
            dataGridView1.Rows.Add("1", "DTYUI", "RTYUI");
            dataGridView1.Rows.Add("2", "KJHGF", "OIUY");
            dataGridView1.Rows.Add("3", "SDFGH", "LTDFGH");
            dataGridView1.Rows.Add("4", "ERJHGV", "CVHEYH");
            dataGridView1.Rows.Add("5", "AQSFGHKK", "TRDFHJH");
            dataGridView1.Rows.Add("6", "NQAAZTYI", "KITGHKG");
            dataGridView1.Rows.Add("7", "XBVSARY", "OTYHNC");
            dataGridView1.Rows.Add("8", "ACJKT", "PMLGESB");
            dataGridView1.Rows.Add("9", "FGHKL", "IUYTEYK");
            dataGridView1.Rows.Add("10", "WQAZR", "ERTYUVBD");
            dataGridView1.Rows.Add("11", "CKKTS", "EGCQA");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;

        }
        private void Csharp_delete_datagridview_checked_checkbox_cell_Load(object sender, EventArgs e)
        {

        }
        public List<Criteria> LoadCsvData(string CsvFile)
        {
            var query = from l in File.ReadAllLines(CsvFile)
                        let data = l.Split(',')
                        select new Criteria
                        {
                            Id = data[0],
                            CriteriaName = data[1]
                        };

            return query.ToList();
        }
        public class Criteria
        {
            public string Id { get; set; }
            public string CriteriaName { get; set; }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                bool delete = (bool)dataGridView1.Rows[i].Cells[3].Value;

                // if the checkbox cell is checked

                if (delete == true)
                {
                    MessageBox.Show("New item");

                }
            }
        }
    }
}
