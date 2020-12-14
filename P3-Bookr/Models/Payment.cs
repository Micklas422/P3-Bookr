using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    public class Payment : IPayment
    {
        DateTime _paymentDate;
        float _amount;
        DateTime _reservationDeadline;
        bool _refunded;
        public Payment(DateTime paymentDate, float amount)
        {
            PaymentDate = paymentDate;
            Amount = amount;
            Refunded = false;
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
