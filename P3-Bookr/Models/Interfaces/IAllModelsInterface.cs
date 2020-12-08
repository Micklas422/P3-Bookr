using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    interface IAllModelsInterface
    {
        ICustomer customer { get; }
        IDepartment department { get; }
        IMember member { get; }
        IPayment payment { get; }
        IReservation reservation { get; }
        IServicegroup servicegroup { get; }
        IServiceOffering serviceOffering { get; }
        IServices services { get; }
        ITimeperiod timeperiod { get; }
    }
}
