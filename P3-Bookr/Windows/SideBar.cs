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

namespace P3_Bookr.Windows
{
    public partial class SideBar : UserControl
    {
        public SideBar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var serviceForm = new ServicesOverview();
            serviceForm.Show();
        }

        private void ReservationerKnap_Click(object sender, EventArgs e)
        {
            var reservationsPage = new ReservationOverview();
            reservationsPage.Show();
        }

        private void MitForbrugKnap_Click(object sender, EventArgs e)
        {
            var mitForbrugSite = new HistoryPage();
            mitForbrugSite.Show();
        }

        private void IndstillingerKnap_Click(object sender, EventArgs e)
        {
            var indstillingerSite = new Settings();
            indstillingerSite.Show();
        }
    }
}
