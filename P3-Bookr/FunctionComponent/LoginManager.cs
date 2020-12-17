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
        IModelComponent _modelComponent;
        public LoginManager(IModelComponent modelComponent)
        {
            _modelComponent = modelComponent;
        }
        public IMember ValidateLogin(string username, string password)
        {
            IMember member = _modelComponent.GetMemberByUsername(username); //sets the new member to member by username
            if (member == null)
                throw new UserNotFoundException("User does not exsist");
            if (member.Password != password)
                throw new BadPasswordException("Invalid password enter");
            return member;
        }
    }
}
