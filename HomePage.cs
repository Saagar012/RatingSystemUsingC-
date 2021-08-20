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
    public partial class HomePage : Form
    {
        public HomePage()
        {InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            //this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CustomerLogin cf = new CustomerLogin();
            cf.Show();
            //this.Hide();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}
