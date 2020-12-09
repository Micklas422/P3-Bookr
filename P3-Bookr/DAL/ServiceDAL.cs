using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.DAL.Interfaces;
using P3_Bookr.Models;

namespace P3_Bookr.DAL.Interfaces
{
    class ServiceDAL : IServiceDAL
    {
        List<Service> _services;
        string _fileName = "Serives";
        JsonHandler _jsonHandler = new JsonHandler();

        public ServiceDAL()
        {
            Services = LoadServices();
        }

        public List<Service> Services { get => _services; private set => _services = value; }

        public List<Service> LoadServices()
        {
            List<Service> services;
            services = _jsonHandler.ReadJsonObjectFromFile<List<Service>>(_fileName);
            return services;
        }

        public List<Service> GetServices()
        {
            return Services;
        }

        public Service GetService(int id)
        {
            return Services.Where(s => s.Id == id).FirstOrDefault();
        }

        public Service GetServicesByDepartmentId(int departmentId)
        {
            return Services.Where(s => s.DepartmentId == departmentId).FirstOrDefault();
        }

        public void UpdateSerivce(Service service)
        {
            Services.Where(s => s.Id == service.Id).Select(s => s = service);
        }

        public void SetServices(List<Service> services)
        {
            _jsonHandler.WriteJsonObjectToFile(_fileName, services);
        }
    }
}
