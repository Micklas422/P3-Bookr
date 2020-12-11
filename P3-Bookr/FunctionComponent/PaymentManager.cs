using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;

namespace P3_Bookr.FunctionComponent
{
    class PaymentManager : IPaymentManager
    {
        IModelComponent _modelComponent;

        public PaymentManager(IModelComponent modelComponent)
        {
            _modelComponent = modelComponent;
        }
        public void Pay()
        {
            throw new NotImplementedException();
        }

        public bool Cancel(List<Payment> payments)
        {
            payments.ElementAt(0).Refunded = RefundPayment(payments.ElementAt(0));
            if (payments.ElementAt(0).Refunded)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RefundPayment(Payment payment)
        {
            return true;
        }
    }
}
