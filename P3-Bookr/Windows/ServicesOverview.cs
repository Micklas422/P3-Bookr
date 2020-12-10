using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P3_Bookr.Windows.WindowsInterfaces;

namespace P3_Bookr.Windows
{
    public partial class ServicesOverview : UserControl
    {
        IServicesUI _handler;
        public ServicesOverview(IServicesUI handler)
        {
            InitializeComponent();
            _handler = handler;
        }

        private void ServicesOverview_Load(object sender, EventArgs e)
        {

        }

        private void ServiceOverviewBookr_Click(object sender, EventArgs e)
        {

        }
    }
}
