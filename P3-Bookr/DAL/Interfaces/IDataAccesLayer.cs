using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.DAL.Interfaces
{
    interface IDataAccesLayer
    {
        ICustomerDAL customerDAL { get; }
        IDepartmentDAL departmentDAL { get; }
        IMemberDAL memberDAL { get; }
        IPaymentDAL paymentDAL { get; }
        IReservationDAL reservationDAL { get; }
        IServiceGroupDAL serviceGroupDAL { get; }
        IServiceOfferingDAL serviceOfferingDAL { get; }
        IServiceDAL serviceDAL { get; }
        ITimeperiodDAL timeperiodDAL { get; }
    }
}
