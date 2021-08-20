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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = userTxt.Text;
            string password = passtxt.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show(" * Username or password cannot be empty");
            }
            else
            {
                if (username == "admin")
                {
                    if (password == "admin")
                    {

                        AdminDashboard ad = new AdminDashboard();
                        ad.Show();
                       // this.Hide();
                       
                    }
                    else
                    {
                        MessageBox.Show("* Incorrect password !! Please input correct password");
                     }
                }
                else
                {
                    MessageBox.Show("* Incorrect username !!");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }
    }
}
    
