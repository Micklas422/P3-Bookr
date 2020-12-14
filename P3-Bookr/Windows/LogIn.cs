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
using P3_Bookr.Windows.WindowsInterfaces;

namespace P3_Bookr.Windows
{
    partial class Login : UserControl
    {
        ILogInUI _handler;
        public Login(ILogInUI handler)
        {
            _handler = handler;
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            _handler.LogIn(textBoxUsername.Text, textBoxPassword.Text);         
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Keys)e.KeyChar == Keys.Enter)
            {
                buttonLogin_Click(sender, e);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBoxUsername.KeyPress += Login_KeyPress;
            textBoxPassword.KeyPress += Login_KeyPress;
        }
    }
}
