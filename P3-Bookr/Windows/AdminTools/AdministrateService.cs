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

namespace P3_Bookr.Windows.AdminTools
{
    public partial class AdministrateService : UserControl
    {
        IAdminToolsUI _handler;
        public AdministrateService(IAdminToolsUI handler)
        {
            _handler = handler;
            InitializeComponent();
        }

        private void buttonNewService_Click(object sender, EventArgs e)
        {
            _handler.SwitchToNewService();
        }
    }
}
