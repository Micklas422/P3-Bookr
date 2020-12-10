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

        public void Cancel()
        {
            throw new NotImplementedException();
        }
    }
}
