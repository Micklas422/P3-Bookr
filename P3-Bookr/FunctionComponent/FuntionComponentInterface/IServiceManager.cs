using P3_Bookr.Models;
using System.Collections.Generic;

namespace P3_Bookr.FunctionComponent
{
    public interface IServiceManager
    {
        List<Service> GetActiveServices();
        List<Service> GetActiveServicesByMember(Member member);
        List<Service> FindLastServicesUsed(Member member, int cnt);
        void Reserve();
        void SeeAvailability();
        void AddServiceToServiceList(Service service, Department department);
    }
}
