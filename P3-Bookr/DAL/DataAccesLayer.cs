using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.DAL.Interfaces;

namespace P3_Bookr.DAL
{
    class DataAccesLayer : IDataAccesLayer
    {
        ICustomerDAL _customerDAL;
        IDepartmentDAL _departmentDAL;
        IMemberDAL _memberDAL;
        IPaymentDAL _paymentDAL;
        IReservationDAL _reservationDAL;
        IServiceGroupDAL _serviceGroupDAL;
        IServiceOfferingDAL _serviceOfferingDAL;
        IServicesDAL _servicesDAL;
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
            //_servicesDAL = new ServicesDAL();
        }

        ICustomerDAL CustomerDAL
        {
            get { return _customerDAL; }
        }
    }
}
