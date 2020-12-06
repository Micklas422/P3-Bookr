using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    class Services
    {
        string _name;
        bool _departmentDeactivatet;
        public enum ServiceState
        {
            //implemeteres i commons/membertypes
        };
        public enum ServiceType
        {
            //implemeteres i commons/membertypes
        };
        public Services(string name, bool departmentDeactivatet)
        {
            _name = name;
            _departmentDeactivatet = departmentDeactivatet;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public bool DepartmentDeactivatet
        {
            get { return _departmentDeactivatet; }
            set { _departmentDeactivatet = value; }
        }
    }
}
