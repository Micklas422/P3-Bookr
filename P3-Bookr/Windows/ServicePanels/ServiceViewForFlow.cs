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

namespace P3_Bookr.Windows
{
    public partial class ServiceViewForFlow : UserControl
    {
        public ServiceViewForFlow(Service service)
        {
            InitializeComponent();
            this.ServiceTitel.Text = service.Name;
            this.ServiceLocationInfo.Text = service.Location;
            this.ServiceInfoInfo.Text = service.Description;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string Titel
        {
            get { return this.ServiceTitel.Text; }
            set { this.ServiceTitel.Text = value; }
        }
        public string LocationInfo
        {
            get { return this.ServiceLocationInfo.Text; }
            set { this.ServiceLocationInfo.Text = value; }
        }
        public string InfoInfo
        {
            get { return this.ServiceInfoInfo.Text; }
            set { this.ServiceInfoInfo.Text = value; }
        }
    }
}
