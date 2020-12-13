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

namespace P3_Bookr.Windows.ReservationPanels
{
    public partial class ReservationPage : UserControl
    {
        IReservationUI _handler;
        public ReservationPage(IReservationUI handler)
        {
            _handler = handler;
            InitializeComponent();
        }

        private void reservation1_Load(object sender, EventArgs e)
        {

        }
    }
}
