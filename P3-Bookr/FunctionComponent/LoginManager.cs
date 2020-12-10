using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;
using P3_Bookr.DAL;
using P3_Bookr.FunctionComponent;

namespace P3_Bookr.FunctionComponent
{
    public class LoginManager : ILoginManager
    {
        Member _member;
        public Member ValidateLogin(string username, string password)
        {
            Member member = new Member();
            return member;


        }
    }
}
