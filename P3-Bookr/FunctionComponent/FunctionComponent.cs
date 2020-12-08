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
        HistoryManager _historyManager;
        PaymentManager _paymentManager;
        PermissionManager _permissionManager;
        ServiceManager _serviceManager;
        public ILoginManager loginManager
        {
            get { return _loginManager; }
        }

        public IHistoryManager historyManager
        {
            get { return _historyManager; }
        }

        public IPaymentManager paymentManager
        {
            get { return _paymentManager; }
            
        }

        public IPermissionManager permissionManager
        {
            get { return _permissionManager; }
        }

        public IServiceManager serviceManager
        {
            get { return _serviceManager; }
        }
    }
}
