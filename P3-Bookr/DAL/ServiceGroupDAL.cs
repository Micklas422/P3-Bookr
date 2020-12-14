using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.DAL.Interfaces;
using P3_Bookr.Models;

namespace P3_Bookr.DAL
{
    class ServiceGroupDAL : IServiceGroupDAL
    {
        public List<ServiceGroup> GetServicesByMember(int memberId)
        {
            throw new NotImplementedException();
        }

        public List<ServiceGroup> GetServicesBySerivce(int serviceId)
        {
            throw new NotImplementedException();
        }

        public void SetServices(List<Service> services)
        {
            throw new NotImplementedException();
        }
    }
}
