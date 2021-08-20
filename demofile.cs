﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class demofile : Form
    {
        public demofile()
        {
            InitializeComponent();
        }
        private Boolean _isValidEmail;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _isValidEmail = IsValidEmail(textBox1.Text);
            Console.WriteLine(_isValidEmail);

        }
        private bool IsValidEmail(string emailAddress)
        {
            const string validEmailPattern =
           @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[az][a-z\.]*[a-z]$";
            return new Regex(validEmailPattern,
           RegexOptions.IgnoreCase).IsMatch(emailAddress);
        }



    }
}
