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

namespace P3_Bookr.Windows.ReservationPanels
{
    public partial class ReservationPanel : UserControl
    {
        public ReservationPanel(Reservation reservation)
        {
            InitializeComponent();
            this.ReservationServiceName.Text = reservation.ServiceOffering.Name;
            this.ReservationPrice.Text = reservation.ServiceOffering.Price.ToString();
            this.ReservationDate.Text = reservation.ReservationDate.ToString();
            
        }
    }
}
