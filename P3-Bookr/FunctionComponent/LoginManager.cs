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
        Member _member = null;
        IModelComponent _modelComponentHandler;
        public Member ValidateLogin(string username, string password)
        {
            Member member = _modelComponentHandler.GetMemberByUsername(username); //sets the new member to member by username
            if (member != null && member.Password == password)
                _member = member;
            if (member != null && member.Password != password)
                return _member;
            return _member;


        }
    }
}
