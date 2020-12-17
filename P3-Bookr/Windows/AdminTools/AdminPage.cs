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

namespace P3_Bookr.Windows.AdminTools
{
    public partial class AdminPage : UserControl
    {
        IAdminToolsUI _handler;
        List<IDepartment> _departmentList;
        public AdminPage(IAdminToolsUI handler, List<IDepartment> departmentList)
        {
            _handler = handler;
            _departmentList = departmentList;
            InitializeComponent();
            panelAdministrateUserAdminTool.Controls.Add(new AdministrateUser());
            panelServiceAdminTool.Controls.Add(new AdministrateService(_handler));
        }

        private void administrateService1_Load(object sender, EventArgs e)
        {

        }
    }
}
