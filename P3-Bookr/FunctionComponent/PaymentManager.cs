using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;

namespace P3_Bookr.FunctionComponent
{
    public class PaymentManager : IPaymentManager
    {
        IModelComponent _modelComponent;

        public PaymentManager(IModelComponent modelComponent)
        {
            _modelComponent = modelComponent;
        }
        //public bool Pay(Payment payment)
        //{
        //    return true;
        //}

        public bool Cancel(Payment payments)
        {
            payments.Refunded = true;
            return true;
        }

        public bool RefundPayment(Payment payment)
        {
            return true;
        }
    }
}
