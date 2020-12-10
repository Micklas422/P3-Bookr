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
using P3_Bookr.FunctionComponent.

namespace P3_Bookr.Windows
{
    public partial class ServiceDetails : UserControl
    {
        UIController _handler;
        ServiceOptionCalendarPanel _calendarPanel;
        ServiceOptionChoisePanel _choisePanel;
        ServiceOptionFlowOption _flowOption;
        string _name;
        string _price;
        DateTime _dateForBooking;

        public ServiceDetails(UIController handler)
        {
            InitializeComponent();
            _handler = handler;
        }

        private void ServiceDetails_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ServiceFlowTitel2_Click(object sender, EventArgs e)
        {

        }


        public void GetServiceName(ServiceOptionFlowOption flowOption)
        {
            _name = flowOption.ServiceOptionFlowOptionInfo1.Text;
        }
        public void GetServicePrice()
        {
            _price = _flowOption.ServiceOptionFlowOptionInfo2.Text;
        }
        public void GetServiceDateandTime()
        {
            //_dateForBooking = _calendar
        }
    }
}
