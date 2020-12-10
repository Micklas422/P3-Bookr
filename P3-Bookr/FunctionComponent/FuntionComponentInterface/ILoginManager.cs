using P3_Bookr.Models;

namespace P3_Bookr.FunctionComponent
{
    interface ILoginManager
    {
        Member ValidateLogin(string username, string password);
    }
}
