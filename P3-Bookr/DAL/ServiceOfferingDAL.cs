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
        string fileName = "ServiceOfferings";
        JsonHandler jsonHandler = new JsonHandler();
        public List<ServiceOffering> GetServiceOfferings(int serviceId)
        {
            List<ServiceOffering> serviceOfferings;
            serviceOfferings = jsonHandler.ReadJsonObjectFromFile<List<ServiceOffering>>(fileName).Where(s => s.ServicesId == serviceId).ToList();
            return serviceOfferings;
        }

        public void SetServiceOfferings(List<ServiceOffering> serviceOfferings)
        {
            jsonHandler.WriteJsonObjectToFile(fileName, serviceOfferings);
        }
    }
}
