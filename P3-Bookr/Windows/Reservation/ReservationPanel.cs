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
        Reservation _reservation;
        public ReservationPanel(Reservation reservation, IReservationUI reservationUI)
        {
            InitializeComponent();
            _reservationUI = reservationUI;
            this.ReservationServiceName.Text = reservation.ServiceOffering.Name;
            this.ReservationPrice.Text = reservation.ServiceOffering.Price.ToString();
            this.ReservationDate.Text = reservation.ReservationDate.ToString();
            _reservation = reservation;
        }

        private void CanselReservation_Click(object sender, EventArgs e)
        {
            _reservationUI.CancelReservation(_reservation);
        }
    }
}
