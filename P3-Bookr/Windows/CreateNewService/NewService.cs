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
        public NewService(IAdminToolsUI handler, List<Department> memberDepartments)
        {

            InitializeComponent();
            _handler = handler;
            foreach(string serviceTypes in Enum.GetNames(typeof(ServiceTypes)))
            {
                DropdownServiceType.Items.Add(serviceTypes);
            }
            DropdownServiceType.SelectedIndex = 0;
            foreach(Department department in memberDepartments)
            {
                DropdownAfdeling.Items.Add(department.Name);
            }
            DropdownAfdeling.SelectedIndex = 0;
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Service service = new Service(textBoxName.Text, (ServiceTypes)DropdownServiceType.SelectedIndex);

            foreach (PageServiceOffering offering in flowPanelServiceOffering.Controls)
            {
                ServiceOffering serviceOffering = new ServiceOffering(offering.textBoxName.Text, int.Parse(offering.textBoxTime.Text), float.Parse(offering.textBoxPrice.Text), service);
                serviceOfferingsList.Add(serviceOffering);
            }

            service.Location = textBoxAddress.Text;
            service.Name = textBoxName.Text;
            service.Description = richTextBoxDescription.Text;
            service.ServiceOfferings = serviceOfferingsList;
            service.ServiceState = 0;

            _handler.AddService(service, (Department)DropdownAfdeling.SelectedItem);
        }

        private void ButtonNewService_Click(object sender, EventArgs e)
        {
            flowPanelServiceOffering.Controls.Add(new PageServiceOffering());
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            _handler.SwitchToHomePage();
        }
    }
}
