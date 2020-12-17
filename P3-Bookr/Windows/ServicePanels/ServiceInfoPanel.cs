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
using P3_Bookr.Models;

namespace P3_Bookr.Windows
{
    public partial class ServiceInfoPanel : UserControl
    {
        IServicesUI _handler;
        IService _service;
        public ServiceInfoPanel(IServicesUI handler, IService service)
        {
            _service = service;
            _handler = handler;
            InitializeComponent();
            this.ServiceAdressInfo1.Text = service.Location;
            this.ServiceDescriptionInfo1.Text = service.Description;
        }

        private void ServiceDescriptionInfo1_Click(object sender, EventArgs e)
        {

        }
    }
}
