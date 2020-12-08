using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.DAL.Interfaces;
using P3_Bookr.Models;

namespace P3_Bookr.DAL.Interfaces
{
    class ServiceDAL : IServicesDAL
    {
        string fileName = "Serives";
        JsonHandler jsonHandler = new JsonHandler();
        public List<Services> GetServices(int departmentId)
        {
            List<Services> services;
            services = jsonHandler.ReadJsonObjectFromFile<List<Services>>(fileName).Where(s => s.DepartmentId == departmentId).ToList();
            return services;
        }

        public void SetServices(List<Services> services)
        {
            jsonHandler.WriteJsonObjectToFile(fileName, services);
        }
    }
}
