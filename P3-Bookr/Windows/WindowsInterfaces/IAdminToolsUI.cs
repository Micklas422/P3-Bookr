using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;
using P3_Bookr.Commons.Enums;

namespace P3_Bookr.Windows.WindowsInterfaces
{
    public interface IAdminToolsUI
    {
        void AddService(IService service, IDepartment department);
        void SwitchToHomePage();
        void SwitchToNewService();
        void SwitchToAdminToolsPage();

    }
}
