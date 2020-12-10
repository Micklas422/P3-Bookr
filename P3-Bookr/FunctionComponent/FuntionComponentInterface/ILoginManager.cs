using P3_Bookr.Models;

namespace P3_Bookr.FunctionComponent
{
    public interface ILoginManager
    {
        Member ValidateLogin(string username, string password);
    }
}
