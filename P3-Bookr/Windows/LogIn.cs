﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P3_Bookr.FunctionComponent;

namespace P3_Bookr.Windows
{
    partial class Login : UserControl
    {
        ILoginManager _loginManager;
        public Login(ILoginManager loginManager)
        {
            _loginManager = loginManager;
            InitializeComponent();
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string username;
            string password;
            password = textBoxUsername.Text;
            username = textBoxUsername.Text;

            if (_loginManager.ValidateLogin(username, password))
            {

            }
            else
            {
                MessageBox.Show("Computer says nooo");
            }
            

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
