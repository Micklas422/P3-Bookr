using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.FunctionComponent
{
    interface IFunctionComponentInterface
    {
        ILoginManager loginManager { get; }

        IHistoryManager historyManager { get; }

        IPaymentManager paymentManager { get; }

        IPermissionManager permissionManager { get; }

        IServiceManager serviceManager { get; }
    }

    interface IHistoryManager
    {

    }

    interface ILoginManager
    {
        bool ValidateLogin(string username, string password);
    }

    interface IPaymentManager
    {

    }

    interface IPermissionManager
    {

    }

    interface IServiceManager
    {

    }
}
