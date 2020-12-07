using System;
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
    public partial class Login : UserControl
    {
        public Login()
        {
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
            LoginManager loginmanager = new LoginManager();

            string username;
            string password;
            password = textBoxUsername.Text;
            username = textBoxUsername.Text;

            loginmanager.ValidateLogin(username, password);

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
