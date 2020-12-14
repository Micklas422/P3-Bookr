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


namespace P3_Bookr.Windows.CreateNewService
{
    public partial class NewService : UserControl
    {
        IAdminToolsUI _handler;
        public NewService()
        {
            InitializeComponent();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service.Location = textBoxAddress.Text;
            service.Name = textBoxName.Text;
            service.Description = richTextBoxDescription.Text;

            _handler.AddService(textBoxAddress.Text,richTextBoxDescription.Text, )
        }
    }
}
