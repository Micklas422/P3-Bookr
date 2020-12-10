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
    public partial class ServiceOptionCalendarPanel : UserControl
    {
        List<ServiceOffering> _serviceOfferings;
        public ServiceOptionCalendarPanel(List<ServiceOffering> serviceOfferings)
        {
            _serviceOfferings = serviceOfferings;
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //this.DateTimePickerService.sele
        }

        private void ServiceOptionBookButton1_Click(object sender, EventArgs e)
        {

        }

        private void ServiceOptionCalendarPanel_Load(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            foreach (ServiceOffering s in _serviceOfferings)
            {
                this.flowLayoutPanel1.Controls.Add(new ServiceOptionFlowOption());
            }
        }
    }
}
