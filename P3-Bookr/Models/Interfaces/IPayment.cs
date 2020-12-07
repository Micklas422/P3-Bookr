using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models.Interfaces
{
    interface IPayment
    {
        DateTime PaymentDate { get; set; }
        float Amount { get; set; }
        DateTime ReservationDeadline { get; set; }
    }
}
