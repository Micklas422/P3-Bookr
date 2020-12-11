using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P3_Bookr.Windows.WindowsInterfaces;

namespace P3_Bookr.Windows
{
    public partial class ServiceInfoPanel : UserControl
    {
        UIController _handler;
        public ServiceInfoPanel(UIController handler)
        {
            _handler = handler;
            InitializeComponent();
        }

        private void ServiceDescriptionInfo1_Click(object sender, EventArgs e)
        {

        }
    }
}
