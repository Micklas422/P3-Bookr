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
        public List<Service> Services => throw new NotImplementedException();

        public Service GetService(int id)
        {
            throw new NotImplementedException();
        }

        public List<Service> GetServicesByDepartmentId(int departmentId)
        {
            throw new NotImplementedException();
        }

        public void SetServices(List<Service> services)
        {
            throw new NotImplementedException();
        }

        public void UpdateSerivce(Service service)
        {
            throw new NotImplementedException();
        }
    }
}
