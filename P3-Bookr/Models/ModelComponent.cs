using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.DAL;
using P3_Bookr.DAL.Interfaces;

namespace P3_Bookr.Models
{
    class ModelComponent
    {
        IDataAccesLayer _dataAccesLayer;
        List<Customer> _customer;

        public ModelComponent(IDataAccesLayer dataAccesLayer)
        {
            _dataAccesLayer = dataAccesLayer;
        }

        void LoadModel()
        {
            _customer = _dataAccesLayer.customerDAL.Customers;

            foreach(Customer cus in _customer)
            {
                cus.Members = _dataAccesLayer.memberDAL.GetMembersByCustomer(cus.Id);
                cus.Departments = _dataAccesLayer.departmentDAL.GetDepartmentsByCustomerId(cus.Id);
                foreach(Member member in cus.Members)
                {
                    member.Reservations = _dataAccesLayer.reservationDAL.GetReservationsByMember(member.Id);
                    foreach (Reservation reservation in member.Reservations)
                    {
                        reservation.Payments = _dataAccesLayer.paymentDAL.GetPaymentByReservation(reservation.Id);
                    }
                }
                foreach(Department department in cus.Departments)
                {
                    department.Services = _dataAccesLayer.serviceDAL.GetServicesByDepartmentId(department.Id);
                    foreach (Service service in department.Services)
                    {
                        service.ServiceOfferings = _dataAccesLayer.serviceOfferingDAL.GetServiceOfferingsByServiceId(service.Id);
                        service.TimePeriods = _dataAccesLayer.timeperiodDAL.GetTimePeriodsByService(service.Id);
                    }
                }
            }
        }

        public List<Customer> customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        public Member GetMemberByUsername(string username)
        {
            try
            {
                foreach (Customer cus in _customer)
                {
                    return cus.Members.Where(m => m.Username == username).FirstOrDefault();
                }
            }
            catch (ArgumentNullException)
            {
                
            }
            return new Member();
        }

        public IDataAccesLayer DAL
        {
            get { return _dataAccesLayer; }
            private set { _dataAccesLayer = value; }
        }


        //ICustomer _customer;
        //IDepartment _department;
        //IMember _member;
        //IPayment _payment;
        //IReservation _reservation;
        //IServicegroup _servicegroup;
        //IServiceOffering _serviceOffering;
        //IServices _services;
        //ITimeperiod _timeperiod;

        //public AllModelsInterface(ICustomer customer, IDepartment department, IMember member, IPayment payment, IReservation reservation, IServicegroup servicegroup, IServiceOffering serviceOffering, IServices services, ITimeperiod timeperiod)
        //{
        //    _customer = customer;
        //    _department = department;
        //    _member = member;
        //    _payment = payment;
        //    _reservation = reservation;
        //    _servicegroup = servicegroup;
        //    _serviceOffering = serviceOffering;
        //    _services = services;
        //    _timeperiod = timeperiod;

        //}

        //public ICustomer customer
        //{
        //    get { return _customer; }
        //}
        //public IDepartment department
        //{
        //    get { return _department; }
        //}
        //public IMember member
        //{
        //    get { return _member; }
        //}
        //public IPayment payment
        //{
        //    get { return _payment; }
        //}
        //public IReservation reservation
        //{
        //    get { return _reservation; }
        //}
        //public IServicegroup servicegroup
        //{
        //    get { return _servicegroup; }
        //}
        //public IServiceOffering serviceOffering
        //{
        //    get { return _serviceOffering; }
        //}
        //public IServices services
        //{
        //    get { return _services; }
        //}
        //public ITimeperiod timeperiod
        //{
        //    get { return _timeperiod; }
        //}
    }
}
