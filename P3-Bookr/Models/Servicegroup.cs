using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Commons.Enums;

namespace P3_Bookr.Models
{
    class Servicegroup
    {
        string _name;
        ServiceTypes _serviceType;

        public Servicegroup(string name, ServiceTypes serviceType)
        {
            _name = name;
            _serviceType = serviceType;
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
