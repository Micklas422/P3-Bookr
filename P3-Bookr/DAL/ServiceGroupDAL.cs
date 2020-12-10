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
        string fileName = "Services";
        JsonHandler jsonHandler = new JsonHandler();

        public List<ServiceGroup> GetServicesByMember(int memberId)
        {
            List<ServiceGroup> services;
            services = jsonHandler.ReadJsonObjectFromFile<List<ServiceGroup>>(fileName);
            return services;
        }

        public List<ServiceGroup> GetServicesBySerivce(int serviceId)
        {
            List<ServiceGroup> services;
            services = jsonHandler.ReadJsonObjectFromFile<List<ServiceGroup>>(fileName);
            return services;
        }

        public void SetServices(List<Service> services)
        {
            jsonHandler.WriteJsonObjectToFile(fileName, services);
        }
    }
}
