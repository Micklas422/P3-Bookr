using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_Bookr.Windows
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void HideAllControls()
        {
            foreach (Control c in this.Controls)
            {
                c.Hide();
            }
            labelLoggedIn.Hide();
            labelUserLoggedIn.Hide();
            pictureBoxBookr.Hide();
        }
    }
}
