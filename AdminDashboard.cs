using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCriteria f1 = new AddCriteria();
            f1.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RatingImport ir = new RatingImport();
            ir.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RatingReport rr = new RatingReport();
            rr.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button2_BackColorChanged(object sender, EventArgs e)
        {
           
        }
    }
}
