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
        public ServiceManager(IModelComponent modelComponent)
        {
            _modelComponent = modelComponent;
        }

        public List<Service> GetActiveServices()
        {
            List<Service> services = _modelComponent.GetAllServices();
            List<Service> result = new List<Service>();
            foreach (Service ser in services)
            {
                if (ser.ServiceState == 0)
                {
                    result.Add(ser);
                }
            }
            return result;
        }

        public List<Service> FindLastServicesUsed(Member  member, int cnt)
        {
            List<Service> services = new List<Service>();
            services.Add(_modelComponent.customer[0].Departments[0].Services[0]);
            return services;
        }

        public List<Service> GetActiveServicesByMember(Member member)
        {
            List<Service> result = new List<Service>();
            //foreach (Department d in member)
            //{

            //}

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
    }
}
