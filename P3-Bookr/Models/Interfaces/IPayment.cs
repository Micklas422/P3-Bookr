using P3_Bookr.Commons.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    public interface IPayment
    {
        void StateHandler(ReservationStates reservationState);
        ReservationStates ReservationStates { get; set; }
        DateTime PaymentDate { get; set; }
        float Amount { get; set; }
        DateTime ReservationDeadline { get; set; }
        bool Refunded { get; set; }
    }
}
