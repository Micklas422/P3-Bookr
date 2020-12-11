using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P3_Bookr.Models;

namespace P3_Bookr.Windows
{
    public partial class ServiceSubOptions : UserControl
    {
        ServiceOffering _serviceOffering;
        public ServiceSubOptions(ServiceOffering serviceOffering)
        {
            _serviceOffering = serviceOffering;
            InitializeComponent();
            this.ServiceOptionFlowOptionInfo1.Text = _serviceOffering.Name;
            this.ServiceOptionFlowOptionInfo2.Text = _serviceOffering.Price.ToString("F");
        }

        private void ServiceOptionFlowOption_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
