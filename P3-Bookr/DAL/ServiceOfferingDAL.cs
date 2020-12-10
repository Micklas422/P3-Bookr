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
        string _fileName = "ServiceOfferings";
        JsonHandler _jsonHandler = new JsonHandler();

        public List<ServiceOffering> ServiceOfferings { get => _serviceOffering; private set => _serviceOffering = value; }

        public ServiceOfferingDAL()
        {
            ServiceOfferings = LoadServiceOfferings();
        }
        List<ServiceOffering> LoadServiceOfferings()
        {
            List<ServiceOffering> serviceOfferings;
            serviceOfferings = _jsonHandler.ReadJsonObjectFromFile<List<ServiceOffering>>(_fileName);
            return serviceOfferings;
        }


        public List<ServiceOffering> GetServiceOfferingsByServiceId(int serviceId)
        {
            return ServiceOfferings.Where(s => s.ServicesId == serviceId).ToList();
        }

        public ServiceOffering GetServiceOffering(int id)
        {
            return ServiceOfferings.Where(s => s.Id == id).FirstOrDefault();
        }

        public void SetServiceOfferings(List<ServiceOffering> serviceOfferings)
        {
            _jsonHandler.WriteJsonObjectToFile(_fileName, serviceOfferings);
        }

        public void UpdateServiceOfferings(ServiceOffering serviceOffering)
        {
            ServiceOfferings.Where(c => c.Id == serviceOffering.Id).Select(c => c = serviceOffering);
        }
    }
}
