using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P3_Bookr.Windows.History;
using P3_Bookr.Windows.WindowsInterfaces;


namespace P3_Bookr.Windows
{
    public partial class SideBar : UserControl
    {
        ISideMenuUI _handler;
        public SideBar(ISideMenuUI handler)
        {
            InitializeComponent();
            _handler = handler;
            
        }

        public event SideBarEvent sideBarEvent;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _handler.SwitchToHomePage();
        }

        private void ReservationerKnap_Click(object sender, EventArgs e)
        {
            var reservationsPage = new ReservationOverview();
            reservationsPage.Show();
        }

        private void MitForbrugKnap_Click(object sender, EventArgs e)
        {
            _handler.SwitchToHistoryPage();
        }

        private void IndstillingerKnap_Click(object sender, EventArgs e)
        {
            //var indstillingerSite = new Settings();

            //indstillingerSite.Show();
        }

        private void SideBar_Load(object sender, EventArgs e)
        {
            //this.Dock = DockStyle.Fill;
        }

        private void ServicesKnap_Click(object sender, EventArgs e)
        {
            _handler.SwitchToServicePage();
        }
    }
}
