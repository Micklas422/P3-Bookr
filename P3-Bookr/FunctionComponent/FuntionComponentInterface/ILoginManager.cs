using P3_Bookr.Models;

namespace P3_Bookr.FunctionComponent
{
    public interface ILoginManager
    {
        IMember ValidateLogin(string username, string password);
    }
}
