using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.FunctionComponent
{
    class FunctionComponent : IFunctionComponentInterface
    {
        ILoginManager _loginManager;
        IHistoryManager _historyManager;
        IPaymentManager _paymentManager;
        IPermissionManager _permissionManager;
        IServiceManager _serviceManager;

        public FunctionComponent(ILoginManager loginManager, IHistoryManager historyManager, IPaymentManager paymentManager, IPermissionManager permissionManager, IServiceManager serviceManager)
        {
            _loginManager = loginManager;
            _historyManager = historyManager;
            _paymentManager = paymentManager;
            _permissionManager = permissionManager;
            _serviceManager = serviceManager;
        }
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
