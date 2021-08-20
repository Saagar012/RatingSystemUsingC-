using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class AddCriteria : Form
    {
        public AddCriteria()
        {
            InitializeComponent();
        }
        ArrayList criteria = new ArrayList();
        ArrayList criteriaId = new ArrayList();


        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (ValidateInputs())
            {
                //for (int i = 0; i < criteria.Count; i++)
                //{
                //    Console.WriteLine(criteria[i].ToString());
                //}
                if (criteriaId.Contains(txtBoxId.Text))
                    {
                        {
                        System.Windows.MessageBox.Show("Criteria Id is duplicate", "Alert",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                else if (criteria.Contains(userTxtBox.Text))
                    {
                    System.Windows.MessageBox.Show("Criteria Name is duplicate", "Alert",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                    }
              
                else
                {
                    criteria.Add(userTxtBox.Text);
                    criteriaId.Add(txtBoxId.Text);
                    
                    //Console.WriteLine("The name of the criteria is " + txtBoxId.Text);
                    addRecord(txtBoxId.Text, userTxtBox.Text, "D:\\criteria.csv");
                    
                    //Console.WriteLine(criteria.Contains(userTxtBox.Text));
                    //Console.WriteLine(criteriaId.Contains(txtBoxId.Text));
                   
                    
                }

            }
            

        }
        public Boolean ValidateInputs()
        {
            if (txtBoxId.Text.Equals("") && userTxtBox.Text.Equals(""))
            {
                System.Windows.MessageBox.Show("Criteria Id and Name cannot be Empty", "Alert",
               MessageBoxButton.OK, MessageBoxImage.Information);
                return false;
            }
            else if (txtBoxId.Text.Equals(""))
            {
                System.Windows.MessageBox.Show("Criteria Id cannot be Empty", "Alert",
               MessageBoxButton.OK, MessageBoxImage.Information);
                return false;
            }


            else if (userTxtBox.Text.Equals(""))
            {
                System.Windows.MessageBox.Show("Criteria Name cannot be Empty", "Alert",
               MessageBoxButton.OK, MessageBoxImage.Information);
                return false;
            }
            
            return true;
        }


        private void AddCriteria_Load(object sender, EventArgs e)
        {

            
        }
        public void addRecord(string Id, string name, string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    file.WriteLine(Id + "," + name);
                }
                System.Windows.MessageBox.Show("Criteria Added");
                txtBoxId.Clear();
                userTxtBox.Clear();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("This program is not doing well", ex);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            
            View_Criteria vc = new View_Criteria();
            vc.Show();

        }
    }
}
