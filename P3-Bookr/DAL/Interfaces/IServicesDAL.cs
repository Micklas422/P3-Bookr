using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;

namespace P3_Bookr.DAL.Interfaces
{
    interface IServicesDAL
    {
        List<Service> Services { get; }
        Service GetService(int id);
        Service GetServicesByDepartmentId(int departmentId);
        void UpdateSerivce(Service service);
        void SetServices(List<Service> services);
    }
}
