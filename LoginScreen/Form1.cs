﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        string name;
        int password; //holds the users password     
        public Form1()

        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            name = nameInput.Text;
            password = Convert.ToInt32(passwordInput.Text);

            outputLabel.Text = "Welcome " + name + ".\nPlease confirm your password:" +
                password;
        }
    }
}
