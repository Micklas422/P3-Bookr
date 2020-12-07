using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static P3_Bookr.Commons.Common;

namespace P3_Bookr.Models
{
    class Services
    {
        string _name;
        bool _departmentDeactivatet;
        ServiceState _state;
        ServiceTypes _type;

        public enum ServiceState
        {
            Available,
            Taken,
            Deactivated
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
