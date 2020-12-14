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
        Service.ServiceStates ServiceState { get; set; }
        ServiceTypes ServiceType { get; set; }
        int Id { get; }
        int DepartmentId { get; set; }
        List<TimePeriod> TimePeriods { get; set; }
        List<ServiceOffering> ServiceOfferings { get; set; }
    }
}
