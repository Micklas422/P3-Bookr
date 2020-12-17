using P3_Bookr.Models;
using System.Collections.Generic;

namespace P3_Bookr.FunctionComponent
{
    public interface IPaymentManager
    {
        //bool Pay(Payment payment);
        bool Cancel(IPayment payments);
    }
}
