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

namespace P3_Bookr.Windows.History
{
    public partial class HistoryElement : UserControl
    {
        public HistoryElement(IReservation reservation)
        {
            InitializeComponent();
            this.labelServiceName.Text = reservation.ServiceOffering.Service.Name;
            this.labelServiceAddress.Text = reservation.ServiceOffering.Service.Location;
            this.labelServiceDate.Text = reservation.ReservationDate.ToString();
            this.labelServicePrice.Text = reservation.ServiceOffering.Price.ToString();
        }
    }
}
