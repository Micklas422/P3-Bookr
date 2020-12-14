using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.DAL.Interfaces;
using P3_Bookr.Models;

namespace P3_Bookr.DAL
{
    class ServiceOfferingDAL : IServiceOfferingDAL
    {
        public List<ServiceOffering> ServiceOfferings => throw new NotImplementedException();

        public ServiceOffering GetServiceOffering(int id)
        {
            throw new NotImplementedException();
        }

        public List<ServiceOffering> GetServiceOfferingsByServiceId(int serviceId)
        {
            throw new NotImplementedException();
        }

        public void SetServiceOfferings(List<ServiceOffering> serviceOfferings)
        {
            throw new NotImplementedException();
        }

        public void UpdateServiceOfferings(ServiceOffering serviceOffering)
        {
            throw new NotImplementedException();
        }
    }
}
