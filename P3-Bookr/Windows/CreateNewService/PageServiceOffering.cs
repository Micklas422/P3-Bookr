using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_Bookr.Windows.CreateNewService
{
    public partial class PageServiceOffering : UserControl
    {
        public PageServiceOffering()
        {
            InitializeComponent();
        }

        private void textBoxTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBoxTime_Validating(object sender, CancelEventArgs e)
        {
            int returnInt;
            if (!int.TryParse(textBoxTime.Text, out returnInt))
            {
                MessageBox.Show("Tidsfeltet skal skrives i hele tal med minutform");
                textBoxTime.Clear();
            }
        }

        private void textBoxPrice_Validating(object sender, CancelEventArgs e)
        {
            float returnFloat;
            if(!float.TryParse(textBoxPrice.Text, out returnFloat))
            {
                MessageBox.Show("Prisfeltet skal skrives i tal med max et komma, prisformaten er kr,øre");
                textBoxPrice.Clear();
            }
        }
    }
}
