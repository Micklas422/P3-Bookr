using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;
using P3_Bookr.Commons.CustomExceptions;
using P3_Bookr.FunctionComponent;

namespace P3_Bookr.FunctionComponent
{
    public class LoginManager : ILoginManager
    {
        Member _member;
        IModelComponent _modelComponent;
        public LoginManager(IModelComponent modelComponent)
        {
            _modelComponent = modelComponent;
        }
        public Member ValidateLogin(string username, string password)
        {
            Member member = _modelComponent.GetMemberByUsername(username); //sets the new member to member by username
            if (member?.Password != password)
                throw new BadPasswordException("Invalid password enter");
            return _member;
        }
    }
}
