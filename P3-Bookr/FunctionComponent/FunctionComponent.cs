using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.FunctionComponent
{
    class FunctionComponent : IFunctionComponentInterface
    {
        LoginManager _loginManager;
        public ILoginManager loginManager 
        {
            get { return _loginManager; }
        }

        public IHistoryManager historyManager => throw new NotImplementedException();

        public IPaymentManager paymentManager => throw new NotImplementedException();

        public IPermissionManager permissionManager => throw new NotImplementedException();

        public IServiceManager serviceManager => throw new NotImplementedException();
    }
}
