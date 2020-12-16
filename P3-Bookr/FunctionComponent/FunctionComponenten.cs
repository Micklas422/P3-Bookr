using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;

namespace P3_Bookr.FunctionComponent
{
    public class FunctionComponenten : IFunctionComponentInterface
    {
        IModelComponent _modelComponent;
        ILoginManager _loginManager;
        IHistoryManager _historyManager;
        IPaymentManager _paymentManager;
        IPermissionManager _permissionManager;
        IReservationManager _reservationManager;
        IServiceManager _serviceManager;
        
        public FunctionComponenten(IModelComponent modelComponent)
        {
            _modelComponent = modelComponent;
            _loginManager = new LoginManager(_modelComponent);
            _historyManager = new HistoryManager(_modelComponent);
            _paymentManager = new PaymentManager(_modelComponent);
            _permissionManager = new PermissionManager(_modelComponent);
            _reservationManager = new ReservationManager(_modelComponent, _paymentManager);
            _serviceManager = new ServiceManager(_modelComponent, _permissionManager);
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

        public IReservationManager reservationManager
        {
            get { return _reservationManager; }
        }
    }
}
