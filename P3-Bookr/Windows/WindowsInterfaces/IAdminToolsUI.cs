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
        //Service AddService(string location, string description, string name, ServiceTypes serviceType, string timePeriod, List<ServiceOffering> serviceOfferings);
        void AddUser();
        void AddService(Service service, Department department);
        void AddServiceGroup();
        void AddUserGroup();
        void CreateServiceOffering();
        void SwitchToHomePage();

    }
}
