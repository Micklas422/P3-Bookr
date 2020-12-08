using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Commons.Enums;

namespace P3_Bookr.Models
{
    class Services : IServices
    {
        int _id;
        int _departmentId;
        string _name;
        bool _departmentDeactivatet;
        ServiceStates _serviceState;
        ServiceTypes _serviceType;

        List<Timeperiod> timeperiods = new List<Timeperiod>();
        List<ServiceOffering> serviceOfferings = new List<ServiceOffering>();

        public enum ServiceStates
        {
            Available,
            Taken,
            Deactivated
        };
        public Services(string name, ServiceTypes serviceType)
        {
            _name = name;
            _serviceType = serviceType;
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
        public ServiceStates ServiceState
        {
            get { return _serviceState; }
            set { _serviceState = value; }
        }
        public ServiceTypes ServiceType
        {
            get { return _serviceType; }
            set { _serviceType = value; }
        }

        public int Id
        {
            get { return _id; }
        }

        public int DepartmentId
        {
            get { return _departmentId; }
            set { _departmentId = value; }
        }
    }
}
