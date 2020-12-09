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
        List<ServiceOffering> _serviceOffering;
        string fileName = "ServiceOfferings";
        JsonHandler jsonHandler = new JsonHandler();

        public List<ServiceOffering> Departments { get => _serviceOffering; set => _serviceOffering = value; }
        public List<ServiceOffering> LoadServiceOfferings(int serviceId)
        {
            List<ServiceOffering> serviceOfferings;
            serviceOfferings = jsonHandler.ReadJsonObjectFromFile<List<ServiceOffering>>(fileName).Where(s => s.ServicesId == serviceId).ToList();
            return serviceOfferings;
        }

        public void SetServiceOfferings(List<ServiceOffering> serviceOfferings)
        {
            jsonHandler.WriteJsonObjectToFile(fileName, serviceOfferings);
        }

        public void UpdateServiceOfferings()
        {
            throw new NotImplementedException();
        }
    }
}
