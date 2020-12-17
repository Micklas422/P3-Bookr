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
using P3_Bookr.Models;

namespace P3_Bookr.Windows
{
    public partial class ServiceDetails : UserControl
    {
        ServiceInfoPanel _serviceInfoPanel;
        ServiceBook _serviceBook;

        public ServiceDetails(ServiceInfoPanel serviceInfoPanel, ServiceBook serviceBook, IService service)
        {
            _serviceInfoPanel = serviceInfoPanel;
            _serviceBook = serviceBook;
            InitializeComponent();
            this.ServiceDetailsTitel1.Text = service.Name;

        }

        private void ServiceDetails_Load(object sender, EventArgs e)
        {
            ServiceDetailsInfoPanel1.Controls.Add(_serviceInfoPanel);
            ServiceDetailsOptionPanel1.Controls.Add(_serviceBook);
        }
    }
}
