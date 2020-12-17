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
        IService _service;
        ServiceSubOptions _selectedServiceOffering;
        DateTime _dateTime;
        bool _TimeSelected;

        public ServiceBook(IServicesUI serivceHandler, IReservationUI reservationHandler, IService service)
        {
            _handler = serivceHandler;
            _service = service;
            _reservationHandler = reservationHandler;
            _dateTime = DateTime.Now;
            InitializeComponent();
            buttonBack.Hide();
            buttonForward.Hide();
            comboBoxTimeSlots.Hide();
        }
        
        private void ServiceSubOptions_click(object sender, EventArgs e)
        {
            buttonForward.Show();
            comboBoxTimeSlots.Show();
            foreach (ServiceSubOptions s in flowLayoutPanelOfferings.Controls)
            {
                s.BackColor = Color.White;
            }
            ServiceSubOptions sub = (ServiceSubOptions)sender;
            sub.BackColor = Color.LightGreen;
            _selectedServiceOffering = sub;
            LoadTimePeriodes(_dateTime);
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

        void LoadTimePeriodes(DateTime dayToLoad)
        {
            DateTime endTime;
            comboBoxTimeSlots.Items.Clear();
            List<ITimePeriod> timePeriods = _service.TimePeriods.Where(t => t.StartTime.Date == dayToLoad.Date || t.EndTime.Date >= dayToLoad.Date).ToList();

            if (dayToLoad.Date == DateTime.Now.Date)
            {
                //find the next quater
                int min = ((dayToLoad.Minute / 15) * 15) + 15;
                min = min - dayToLoad.Minute;
                dayToLoad = dayToLoad.AddMinutes(min);
            }
            else
            {
                dayToLoad = new DateTime(dayToLoad.Year, dayToLoad.Month, dayToLoad.Day, 0, 0, 0);
            }

            //set midnight
            endTime = new DateTime(dayToLoad.Year, dayToLoad.Month, dayToLoad.Day, 0, 0, 0);
            endTime = endTime.AddDays(1);

            do
            {
                if(!timePeriods.Exists(t => (dayToLoad >= t.StartTime && dayToLoad <= t.EndTime) || 
                (dayToLoad.AddMinutes(_selectedServiceOffering.GetServiceOffering().Duration) > t.StartTime && dayToLoad < t.EndTime)))
                    comboBoxTimeSlots.Items.Add(dayToLoad.ToString("HH:mm dd/MM/yyyy "));

                dayToLoad = dayToLoad.AddMinutes(15);
            } while (dayToLoad < endTime);

            if(comboBoxTimeSlots.Items.Count == 0)
            {
                comboBoxTimeSlots.Items.Add("Ingen ledige tider");
                _TimeSelected = false;
            }
            else
            {
                _TimeSelected = true;
            }
            comboBoxTimeSlots.SelectedIndex = 0;
        }

        private void ButtonBook_Click(object sender, EventArgs e)
        {
            if(_selectedServiceOffering != null)
            {
                if(_TimeSelected)
                {
                    ServiceOffering so = _selectedServiceOffering.GetServiceOffering();
                    if (_reservationHandler.CreateNewReservation(_service, so, Convert.ToDateTime(comboBoxTimeSlots.SelectedItem)))
                    {
                        MessageBox.Show("Reservation godkendt");
                        LoadTimePeriodes(_dateTime);
                    }
                    else
                    {
                        MessageBox.Show("Reservation kunne ikke gennemføres");
                    }
                }
                else
                {
                    MessageBox.Show("Ingen tid valgt");
                }
            }
            else
            {
                MessageBox.Show("Vælg service!");
            }
            

        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            buttonBack.Show();
            _dateTime = _dateTime.AddDays(1);
            LoadTimePeriodes(_dateTime);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DateTime d = _dateTime.AddDays(-1);
            if (d.Date <= DateTime.Now.Date)
            {
                _dateTime = DateTime.Now;
                buttonBack.Hide();
            }
            else
                _dateTime = d;

            LoadTimePeriodes(_dateTime);
        }
    }
}
