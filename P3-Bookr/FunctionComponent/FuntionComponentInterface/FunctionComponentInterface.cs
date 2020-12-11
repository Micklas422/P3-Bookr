using P3_Bookr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.FunctionComponent
{
    public interface IFunctionComponentInterface
    {
        ILoginManager loginManager { get; }

        IHistoryManager historyManager { get; }

        IPaymentManager paymentManager { get; }

        IPermissionManager permissionManager { get; }

        IReservationManager reservationManager { get; }

        IServiceManager serviceManager { get; }
    }
}
