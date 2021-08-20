using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class RatingImport : Form
    {
        public RatingImport()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"D:\feedback.csv");
            string[] values;
            for (int j = 1; j < lines.Length; j++)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RatingImport_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("PhoneNumber", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Time", typeof(string));
            table.Columns.Add("FoodQuality", typeof(string));
            table.Columns.Add("Friendliness", typeof(string));
            table.Columns.Add("Cleanliness", typeof(string));
            table.Columns.Add("Order Accuracy", typeof(string));
            table.Columns.Add("Restaurant Ambience", typeof(string));
            table.Columns.Add("Value For Money", typeof(string));
            table.Columns.Add("Overall Rating", typeof(string));
            dataGridView1.DataSource = table;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "Date like'%" + textBox1.Text + "%'";
            dataGridView1.DataSource = bs;
        }

       
        //private void button2_Click_1(object sender, EventArgs e)
        //{
        //    //try
        //    //{
        //    //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    //    openFileDialog.ShowDialog();
        //    //    string fn = openFileDialog.FileName;
        //    //    string readfile = File.ReadAllText(fn);
        //    //    string[] line = readfile.Split('\n');
        //    //    int count = 0;
        //    //    foreach (string s1 in line[0].Split(','))
        //    //    {
        //    //        count++;
        //    //    }
        //    //    dataGridView1.ColumnCount = count;
        //    //    foreach (string s1 in readfile.Split('\n'))
        //    //    {
        //    //        if (s1 != "")
        //    //            dataGridView1.Rows.Add(s1.Split(','));
        //    //    }
        //    //}
        //    //catch (Exception)
        //    //{
        //    //    MessageBox.Show("sorry");
        //    //}
        //}
    }
}
