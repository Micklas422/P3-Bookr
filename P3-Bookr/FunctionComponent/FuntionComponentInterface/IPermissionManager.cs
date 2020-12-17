using P3_Bookr.Models;

namespace P3_Bookr.FunctionComponent
{
    public interface IPermissionManager
    {
        //bool ValidatePermission(string username);
        bool ValidateAdminPermission(IMember currentUser);
        bool ValidateServiceAcces(IMember member, IService service);
    }
}
