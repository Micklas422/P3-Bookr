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
        public SideBar(ISideMenuUI handler, bool adminPermission)
        {
            InitializeComponent();
            _handler = handler;
            this.LabelAdminTools.Visible = adminPermission;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _handler.SwitchToHomePage();
        }

        private void ReservationerKnap_Click(object sender, EventArgs e)
        {
            _handler.SwitchToReservationPage();
        }

        private void MitForbrugKnap_Click(object sender, EventArgs e)
        {
            _handler.SwitchToHistoryPage();
        }

        private void IndstillingerKnap_Click(object sender, EventArgs e)
        {
            _handler.SwitchToSettingsPage();
        }

        private void SideBar_Load(object sender, EventArgs e)
        {
            //this.Dock = DockStyle.Fill;
        }

        private void ServicesKnap_Click(object sender, EventArgs e)
        {
            _handler.SwitchToServicePage();
        }

        private void LogUdKnap_Click(object sender, EventArgs e)
        {
            _handler.SwitchToLogInPage();
            
        }

        private void LabelAdminTools_Click(object sender, EventArgs e)
        {
            _handler.SwitchToAdminToolsPage();
        }
    }
}
