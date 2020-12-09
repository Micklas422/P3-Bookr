using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;

namespace P3_Bookr.FunctionComponent
{
    public class LoginManager : ILoginManager
    {
        Member member;
        public bool ValidateLogin(string username, string password)
        {
            
            if (member.Username == username && member.Password == password)
            {
                return true;
            }
            else 
                return false;
        }
    }
}
