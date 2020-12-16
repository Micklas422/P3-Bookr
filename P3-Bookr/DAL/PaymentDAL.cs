using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.DAL.Interfaces;
using P3_Bookr.Models;

namespace P3_Bookr.DAL
{
    public class PaymentDAL : IPaymentDAL
    {
        public List<Payment> Payments => throw new NotImplementedException();

        public Payment GetPayment(int paymentId)
        {
            throw new NotImplementedException();
        }

        public List<Payment> GetPaymentByReservation(int reservationId)
        {
            throw new NotImplementedException();
        }

        public void SetPayments(List<Payment> payments)
        {
            throw new NotImplementedException();
        }
    }
}
