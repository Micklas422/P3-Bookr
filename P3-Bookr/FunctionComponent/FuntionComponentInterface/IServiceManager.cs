using P3_Bookr.Models;
using System.Collections.Generic;

namespace P3_Bookr.FunctionComponent
{
    public interface IServiceManager
    {
        List<IService> GetActiveServices();
        List<IService> GetActiveServicesByMember(IMember member);
        List<IService> FindLastServicesUsed(IMember member, int cnt);
        //void Reserve();
        //void SeeAvailability();
        bool AddServiceToServiceList(IService service, IDepartment department);
    }
}
