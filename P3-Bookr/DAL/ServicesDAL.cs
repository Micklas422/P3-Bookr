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
        List<Services> _services;
        string _fileName = "Serives";
        JsonHandler _jsonHandler = new JsonHandler();

        public ServiceDAL()
        {
            Services = LoadServices();
        }

        public List<Services> Services { get => _services; private set => _services = value; }

        public List<Services> LoadServices()
        {
            List<Services> services;
            services = _jsonHandler.ReadJsonObjectFromFile<List<Services>>(_fileName);
            return services;
        }

        public List<Services> GetServices()
        {
            return Services;
        }

        public Services GetService(int id)
        {
            return Services.Where(s => s.Id == id).FirstOrDefault();
        }

        public Services GetServicesByDepartmentId(int departmentId)
        {
            return Services.Where(s => s.DepartmentId == departmentId).FirstOrDefault();
        }

        public void UpdateSerivce(Services service)
        {
            Services.Where(s => s.Id == service.Id).Select(s => s = service);
        }

        public void SetServices(List<Services> services)
        {
            _jsonHandler.WriteJsonObjectToFile(_fileName, services);
        }
    }
}
