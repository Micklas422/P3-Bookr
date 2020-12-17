using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;

namespace P3_Bookr.Windows.WindowsInterfaces
{
    public interface IServicesUI
    {
        ServicesOverview LoadServicesToShow();
        void SwitchToService(IService services);
    }
}
