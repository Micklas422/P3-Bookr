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
    public partial class ServiceBook : UserControl
    {
        IServicesUI _handler;
        List<ServiceOffering> _serviceOffering;
        //List<ServiceOffering> _serviceOfferings;
        public ServiceBook(IServicesUI handler, List<ServiceOffering> serviceOffering)
        {
            _handler = handler;
            _serviceOffering = serviceOffering;
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //this.DateTimePickerService.sele
        }

        private void ServiceOptionBookButton1_Click(object sender, EventArgs e)
        {

        }

        private void ServiceBook_Load(object sender, EventArgs e)
        {
            foreach (ServiceOffering so in _serviceOffering)
            {
                flowLayoutPanelOfferings.Controls.Add(new ServiceSubOptions(so));
            }

        }
    }
}
