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
            ServiceOptionFlowOptionInfo1.Text = _serviceOffering.Name;
            ServiceOptionFlowOptionInfo2.Text = _serviceOffering.Price.ToString("F");
            ServiceOptionFlowOptionInfo1.Click += RaiseClick;
            ServiceOptionFlowOptionInfo2.Click += RaiseClick;
        }

        void RaiseClick(object sender, EventArgs e)
        {
            OnClick(e);
        }

        public ServiceOffering GetServiceOffering()
        {
            return _serviceOffering;
        }
    }
}
