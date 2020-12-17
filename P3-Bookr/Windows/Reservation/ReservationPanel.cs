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
using P3_Bookr.Windows.WindowsInterfaces;

namespace P3_Bookr.Windows.ReservationPanels
{
    public partial class ReservationPanel : UserControl
    {
        IReservationUI _reservationUI;
        IReservation _reservation;
        public ReservationPanel(IReservation reservation, IReservationUI reservationUI)
        {
            InitializeComponent();
            _reservationUI = reservationUI;
            ReservationServiceName.Text = reservation.ServiceOffering.Name;
            labelPrice.Text = reservation.ServiceOffering.Price.ToString();
            labelOrderDate.Text = reservation.ReservationDate.ToString("dd:MM:yy HH:mm");
            this.ReservationAddressLabel.Text = reservation.ServiceOffering.Service.Location;
            
            if(reservation.CancellationDate != new DateTime())
            {
                buttonCancel.Hide();
                labelCancelDate.Text = reservation.CancellationDate.ToString("dd:MM:yy HH:mm");
            }
            else if(DateTime.Now > reservation.ReservationDeadline)
            {
                buttonCancel.Hide();
                labelCancelDate.Hide();
                labelCancel.Hide();
            }
            else
            {
                labelCancelDate.Hide();
                labelCancel.Hide();
            }
            _reservation = reservation;
        }

        private void CanselReservation_Click(object sender, EventArgs e)
        {
            _reservationUI.CancelReservation(_reservation);
        }
    }
}
