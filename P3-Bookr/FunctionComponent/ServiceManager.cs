using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;

namespace P3_Bookr.FunctionComponent
{
    class ServiceManager : IServiceManager
    {
        IModelComponent _modelComponent;
        IPermissionManager _permissionManager;
        public ServiceManager(IModelComponent modelComponent, IPermissionManager permissionManager)
        {
            _modelComponent = modelComponent;
            _permissionManager = permissionManager;
        }

        public List<Service> GetActiveServices()
        {
            List<Service> services = _modelComponent.GetAllServices();
            List<Service> result = new List<Service>();
            foreach (Service ser in services)
            {
                if (ser.ServiceState != Service.ServiceStates.Deactivated)
                {
                    result.Add(ser);
                }
            }
            return result;
        }

        public List<Service> FindLastServicesUsed(Member  member, int cnt)
        {
            List<Service> services = new List<Service>();
            services.Add(_modelComponent.customer.Departments[0].Services[0]);
            return services;
        }

        public List<Service> GetActiveServicesByMember(Member member)
        {
            List<Service> result = new List<Service>();
            foreach (Department d in member.Departments)
            {
                foreach (Service s in d.Services)
                {
                    if (!result.Contains(s) 
                        && s.ServiceState != Service.ServiceStates.Deactivated 
                        && _permissionManager.ValidateServiceAcces(member, s))
                    {
                        result.Add(s);
                    }
                }
            }
            return result;
        }

        public void Reserve()
        {
            throw new NotImplementedException();
        }

        public void SeeAvailability()
        {
            throw new NotImplementedException();
        }
        public bool AddServiceToServiceList(Service service, Department department)
        {
            try
            {
                _modelComponent.customer.Departments.Where(d => d.Equals(department)).FirstOrDefault().Services.Add(service);
            }
            catch (ArgumentNullException)
            {
                return false;
            }
            return true;

        }
    }
}
