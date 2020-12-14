using P3_Bookr.Models;
using System.Collections.Generic;

namespace P3_Bookr.FunctionComponent
{
    public interface IPaymentManager
    {
        void Pay();

        bool Cancel(List<Payment> payments);
    }
}
