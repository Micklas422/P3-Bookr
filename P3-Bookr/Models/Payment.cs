using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Commons.Enums;

namespace P3_Bookr.Models
{
    public class Payment : IPayment
    {
        DateTime _paymentDate;
        float _amount;
        DateTime _reservationDeadline;
        bool _refunded;
        ReservationStates _reservationStates;

        public Payment(DateTime paymentDate, float amount)
        {
            PaymentDate = paymentDate;
            Amount = amount;
            Refunded = false;
        }

        public void StateHandler(ReservationStates reservationState)
        {
            ReservationStates = reservationState;
        }

        public ReservationStates ReservationStates
        {
            get { return _reservationStates; }
            set { _reservationStates = value; }
        }

        public DateTime PaymentDate
        {
            get { return _paymentDate; }
            set { _paymentDate = value; }
        }
        public float Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public DateTime ReservationDeadline
        {
            get { return _reservationDeadline; }
            set { _reservationDeadline = value; }
        }

        public bool Refunded
        {
            get { return _refunded; }
            set { _refunded = value; }
        }
    }
}
