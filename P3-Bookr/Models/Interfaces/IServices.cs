using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Commons.Enums;

namespace P3_Bookr.Models
{
    public interface IService
    {
        string Name { get; set; }
        bool DepartmentDeactivatet { get; set; }
        string Location { get; set; }
        string Description { get; }
        Service.ServiceStates ServiceState { get; set; }
        ServiceTypes ServiceType { get; set; }
        SystemRights SystemRights { get; set; }
        List<ITimePeriod> TimePeriods { get; set; }
        List<IServiceOffering> ServiceOfferings { get; set; }
    }
}
