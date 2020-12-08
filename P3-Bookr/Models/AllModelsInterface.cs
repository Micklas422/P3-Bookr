using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    class AllModelsInterface
    {
        public ICustomer customer => throw new NotImplementedException();
        public IDepartment department => throw new NotImplementedException();
        public IMember member => throw new NotImplementedException();
        public IPayment payment => throw new NotImplementedException();
        public IReservation reservation => throw new NotImplementedException();
        public IServicegroup servicegroup => throw new NotImplementedException();
        public IServiceOffering serviceOffering => throw new NotImplementedException();
        public IServices services => throw new NotImplementedException();
        public ITimeperiod timeperiod => throw new NotImplementedException();
    }
}
