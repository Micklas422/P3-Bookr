using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Commons.Enums;

namespace P3_Bookr.Models
{
    public class ServiceGroup : IServicegroup
    {
        string _name;
        ServiceTypes _serviceType;

        public ServiceGroup(int id, string name, ServiceTypes serviceType)
        {
            Name = name;
            ServiceType = serviceType;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public ServiceTypes ServiceType
        {
            get { return _serviceType; }
            set { _serviceType = value; }
        }
    }
}
