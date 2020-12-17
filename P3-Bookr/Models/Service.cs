﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Commons.Enums;

namespace P3_Bookr.Models
{
    public class Service : IService
    {
        static List<int> UniqueIds = new List<int>();

        string _location;
        string _description;
        string _name;
        bool _departmentDeactivatet;
        ServiceStates _serviceState;
        ServiceTypes _serviceType;
        SystemRights _systemRights;

        List<TimePeriod> timeperiods = new List<TimePeriod>();
        List<ServiceOffering> serviceOfferings = new List<ServiceOffering>();

        public enum ServiceStates
        {
            Available,
            Taken,
            Deactivated
        };
        public Service()
        {

        }
        public Service(string name, ServiceTypes serviceType)
        {
            Name = name;
            ServiceType = serviceType;
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
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
        public SystemRights SystemRights
        {
            get { return _systemRights; }
            set { _systemRights = value; }
        }
        public List<TimePeriod> TimePeriods
        {
            get { return timeperiods; }
            set { timeperiods = value; }
        }
        public List<ServiceOffering> ServiceOfferings
        {
            get { return serviceOfferings; }
            set { serviceOfferings = value; }
        }
    }
}
