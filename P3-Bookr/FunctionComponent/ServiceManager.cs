using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;

namespace P3_Bookr.FunctionComponent
{
    public class ServiceManager : IServiceManager
    {
        IModelComponent _modelComponent;
        IPermissionManager _permissionManager;
        public ServiceManager(IModelComponent modelComponent, IPermissionManager permissionManager)
        {
            _modelComponent = modelComponent;
            _permissionManager = permissionManager;
        }

        public List<IService> GetActiveServices()
        {
            List<IService> services = _modelComponent.GetAllServices();
            List<IService> result = new List<IService>();
            foreach (IService ser in services)
            {
                if (ser.ServiceState != Service.ServiceStates.Deactivated)
                {
                    result.Add(ser);
                }
            }
            return result;
        }

        public List<IService> FindLastServicesUsed(IMember member, int cnt)
        {
            List<IService> services = new List<IService>();
            services.Add(_modelComponent.customer.Departments[0].Services[0]);
            return services;
        }

        public List<IService> GetActiveServicesByMember(IMember member)
        {
            List<IService> result = new List<IService>();
            foreach (IDepartment d in member.Departments)
            {
                foreach (IService s in d.Services)
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

        //public void Reserve()
        //{
        //    throw new NotImplementedException();
        //}

        //public void SeeAvailability()
        //{
        //    throw new NotImplementedException();
        //}
        public bool AddServiceToServiceList(IService service, IDepartment department)
        {
            try
            {
                _modelComponent.customer.Departments.Where(d => d.Equals(department)).FirstOrDefault().Services.Add(service);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;

        }
    }
}
