using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;
using P3_Bookr.Commons.Enums;

namespace P3_Bookr.Windows.WindowsInterfaces
{
    interface IAdminToolsUI
    {
        void AddUser();
        Service AddService(Service service);
        void AddServiceGroup();
        void AddUserGroup();
        void CreateServiceOffering();

    }
}
