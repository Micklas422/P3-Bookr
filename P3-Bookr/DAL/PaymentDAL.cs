using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.DAL.Interfaces;
using P3_Bookr.Models;

namespace P3_Bookr.DAL
{
    class PaymentDAL : IPaymentDAL
    {
        List<Payment> _payments;
        string _fileName = "Payments";
        JsonHandler _JsonHandler = new JsonHandler();

        public PaymentDAL()
        {
            Payments = LoadPayments();
        }

        public List<Payment> Payments { get => _payments; private set => _payments = value; }

        public Payment GetPayment(int paymentId)
        {
            return Payments.Where(p => p.Id == paymentId).FirstOrDefault();
        }

        public List<Payment> GetPaymentByReservation(int reservationId)
        {
            return Payments.Where(p => p.ReservationId == reservationId).ToList();
        }

        public List<Payment> LoadPayments()
        {
            List<Payment> payments;
            payments = _JsonHandler.ReadJsonObjectFromFile<List<Payment>>(_fileName);
            return payments;
        }

        public void SetPayments(List<Payment> payments)
        {
            _JsonHandler.WriteJsonObjectToFile(_fileName, payments);
        }
    }
}
