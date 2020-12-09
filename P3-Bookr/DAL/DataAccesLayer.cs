using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.DAL.Interfaces;

namespace P3_Bookr.DAL
{
    class DataAccesLayer
    {
        ICustomerDAL _customerDAL;
        IDepartmentDAL _departmentDAL;
        IMemberDAL _memberDAL;
        IPaymentDAL _paymentDAL;
        IReservationDAL _reservationDAL;
        IServiceGroupDAL _serviceGroupDAL;
        IServiceOfferingDAL _serviceOfferingDAL;
        IServicesDAL _serviceDAL;
        ITimeperiodDAL _timeperiodDAL;

        public DataAccesLayer()
        {
            _customerDAL = new CustomerDAL();
            _departmentDAL = new DepartmentDAL();
            _memberDAL = new MemberDAL();
            _paymentDAL = new PaymentDAL();
            _reservationDAL = new ReservationDAL();
            _serviceGroupDAL = new ServiceGroupDAL();
            _serviceOfferingDAL = new ServiceOfferingDAL();
            _serviceDAL = new ServiceDAL();
            _timeperiodDAL = new TimeperiodDAL();
        }

        public ICustomerDAL customerDAL
        {
            get { return _customerDAL; }
            private set { _customerDAL = value; }
        }
        public IDepartmentDAL cepartmentDAL
        {
            get { return _departmentDAL; }
            private set { _departmentDAL = value; }
        }
        public IMemberDAL memberDAL
        {
            get { return _memberDAL; }
            private set { _memberDAL = value; }
        }
        public IPaymentDAL paymentDAL
        {
            get { return _paymentDAL; }
            private set { _paymentDAL = value; }
        }
        public IReservationDAL reservationDAL
        {
            get { return _reservationDAL; }
            private set { _reservationDAL = value; }
        }
        public IServiceGroupDAL serviceGroupDAL
        {
            get { return _serviceGroupDAL; }
            private set { _serviceGroupDAL = value; }
        }
        public IServiceOfferingDAL serviceOfferingDAL
        {
            get { return _serviceOfferingDAL; }
            private set { _serviceOfferingDAL = value; }
        }
        public IServicesDAL serviceDAL
        {
            get { return _serviceDAL; }
            private set { _serviceDAL = value; }
        }
        public ITimeperiodDAL timeperiodDAL
        {
            get { return _timeperiodDAL; }
            private set { _timeperiodDAL = value; }
        }
    }
}
