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
        IReservationUI _reservationHandler;
        Service _service;
        ServiceSubOptions _selectedServiceOffering;
        //List<ServiceOffering> _serviceOfferings;
        public ServiceBook(IServicesUI serivceHandler, IReservationUI reservationHandler, Service service)
        {
            _handler = serivceHandler;
            _service = service;
            _reservationHandler = reservationHandler;
            InitializeComponent();
        }
        
        private void ServiceSubOptions_click(object sender, EventArgs e)
        {
            foreach(ServiceSubOptions s in flowLayoutPanelOfferings.Controls)
            {
                s.BackColor = Color.White;
            }
            ServiceSubOptions sub = (ServiceSubOptions)sender;
            sub.BackColor = Color.LightGreen;
            _selectedServiceOffering = sub;
        }

        private void ServiceBook_Load(object sender, EventArgs e)
        {
            foreach (ServiceOffering so in _service.ServiceOfferings)
            {
                ServiceSubOptions sub = new ServiceSubOptions(so);
                sub.Click += ServiceSubOptions_click;
                flowLayoutPanelOfferings.Controls.Add(sub);
            }

        }

        private void ButtonBook_Click(object sender, EventArgs e)
        {
            if(_selectedServiceOffering != null)
            {
                ServiceOffering so = _selectedServiceOffering.GetServiceOffering();
                if(_reservationHandler.CreateNewReservation(_service, so, dateTimePickerServicerBook.Value))
                {
                    MessageBox.Show("Reservation godkendt");
                }
                else
                {
                    MessageBox.Show("Reservation kunne ikke gennemføres");
                }
            }
            else
            {
                MessageBox.Show("Vælg service!");
            }
        }
    }
}
