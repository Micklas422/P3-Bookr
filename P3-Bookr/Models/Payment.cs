using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    public class Payment : IPayment
    {
        static List<int> UniqueIds = new List<int>();

        int _id;
        int _reservationId;
        DateTime _paymentDate;
        float _amount;
        DateTime _reservationDeadline;

        public Payment(int id)
        {
            if (UniqueIds.Contains(id))
                throw new ArgumentException();
            UniqueIds.Add(id);
            _id = id;
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

        public int Id
        {
            get { return _id; }
        }

        public int ReservationId
        {
            get { return _reservationId; }
            set { _reservationId = value; }
        }
    }
}
