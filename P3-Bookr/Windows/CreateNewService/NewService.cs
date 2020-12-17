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
        List<IServiceOffering> _serviceOfferingsList = new List<IServiceOffering>();
        List<IDepartment> _departmentsListForUser;
        IDepartment selectedDepartment;
        public NewService(IAdminToolsUI handler, List<IDepartment> memberDepartments)
        {

            InitializeComponent();
            _handler = handler;
            _departmentsListForUser = memberDepartments;
            foreach(string serviceTypes in Enum.GetNames(typeof(ServiceTypes)))
            {
                DropdownServiceType.Items.Add(serviceTypes);
            }
            DropdownServiceType.SelectedIndex = 0;
            foreach(IDepartment department in memberDepartments)
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
                if(offering.textBoxName.TextLength > 0 || offering.textBoxPrice.TextLength > 0 ||offering.textBoxTime.TextLength > 0)
                {
                    ServiceOffering serviceOffering = new ServiceOffering(offering.textBoxName.Text, int.Parse(offering.textBoxTime.Text), float.Parse(offering.textBoxPrice.Text), service);
                    _serviceOfferingsList.Add(serviceOffering);

                }
                else
                {
                    MessageBox.Show("Et af service udbydelserne har manglende informationer");
                }
            }

            service.Location = textBoxAddress.Text;
            service.Name = textBoxName.Text;
            service.Description = richTextBoxDescription.Text;
            service.ServiceOfferings = _serviceOfferingsList;
            service.ServiceState = 0;

            selectedDepartment = _departmentsListForUser.Where(d => d.Name.Equals(DropdownAfdeling.SelectedItem)).FirstOrDefault();
            
            foreach(Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text.Length < 1)
                        MessageBox.Show("Servicen mangler informationer, venligst udfyld");

                }
                if (c is RichTextBox)
                {
                    if (c.Text.Length < 1)
                        MessageBox.Show("Servicen mangler en beskrivelse, venligst udfyld");
                }
                if(c is FlowLayoutPanel)
                {
                    if (c.Controls.Count < 1)
                        MessageBox.Show("Servicen mangler udbydelser, venligst udfyld");
                }
            }

            if(textBoxAddress.TextLength > 0 || textBoxName.TextLength > 0 || richTextBoxDescription.TextLength > 0 || flowPanelServiceOffering.Controls.Count > 0)
            {
                _handler.AddService(service, selectedDepartment);
            }



        }

        private void ButtonNewService_Click(object sender, EventArgs e)
        {
            flowPanelServiceOffering.Controls.Add(new PageServiceOffering());
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            _handler.SwitchToAdminToolsPage();
        }
    }
}
