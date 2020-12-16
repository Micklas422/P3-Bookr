using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;

namespace P3_Bookr.DAL.Interfaces
{
    public interface IPaymentDAL
    {
        List<Payment> Payments { get; }
        Payment GetPayment(int paymentId);

        List<Payment> GetPaymentByReservation(int reservationId);

        void SetPayments(List<Payment> payments);
    }
}