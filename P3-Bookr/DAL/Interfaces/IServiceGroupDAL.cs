using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;

namespace P3_Bookr.DAL.Interfaces
{
    interface IServiceGroupDAL
    {
        List<ServiceGroup> GetServicesByMember(int memberId);
        List<ServiceGroup> GetServicesBySerivce(int serviceId);
        void SetServices(List<Service> services);
    }
}
