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
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = userTxt.Text;
            string password = passTxt.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("username or password cannot be empty");
            }
            else
            {
                if (username == "user")
                {
                    if (password == "user")
                    {

                        Customer_Dashboard cf = new Customer_Dashboard();
                        cf.Show();
                       // this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password !! Please input correct password of if forgotten contact developer");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect username !!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
           // this.Hide();
        }
    }
}
