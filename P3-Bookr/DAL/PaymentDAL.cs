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
        string fileName = "Payments";
        JsonHandler JsonHandler = new JsonHandler();
        public List<Payment> GetPayments(int reservationsId)
        {
            List<Payment> payments;
            payments = JsonHandler.ReadJsonObjectFromFile<List<Payment>>(fileName).Where(p => p.ReservationId == reservationsId).ToList();
            return payments;
        }

        public void SetPayments(List<Payment> payments)
        {
            JsonHandler.WriteJsonObjectToFile(fileName, payments);
        }
    }
}
