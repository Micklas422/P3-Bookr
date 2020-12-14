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
using P3_Bookr.Commons.Enums;

namespace P3_Bookr.Windows.CreateNewService
{
    public partial class NewService : UserControl
    {
        IAdminToolsUI _handler;
        List<ServiceOffering> serviceOfferingsList = new List<ServiceOffering>();
        public NewService()
        {
            InitializeComponent();
            foreach(string serviceTypes in Enum.GetNames(typeof(ServiceTypes)))
            {
                DropdownServiceType.Items.Add(serviceTypes);
            }
            DropdownServiceType.SelectedIndex = 0;
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            foreach (PageServiceOffering offering in flowPanelServiceOffering.Controls)
            {
                ServiceOffering serviceOffering = new ServiceOffering(offering.textBoxName.Text, int.Parse(offering.textBoxTime.Text), float.Parse(offering.textBoxPrice.Text));
                serviceOfferingsList.Add(serviceOffering);
            }

            Service service = new Service(textBoxName.Text, (ServiceTypes)DropdownServiceType.SelectedIndex) ;
            service.Location = textBoxAddress.Text;
            service.Name = textBoxName.Text;
            service.Description = richTextBoxDescription.Text;
            service.ServiceOfferings = serviceOfferingsList;
            service.ServiceState = 0;

            _handler.AddService(service);
        }

        private void ButtonNewService_Click(object sender, EventArgs e)
        {
            flowPanelServiceOffering.Controls.Add(new PageServiceOffering());
        }
    }
}
