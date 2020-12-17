using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;

namespace P3_Bookr.FunctionComponent
{
    public class PermissionManager : IPermissionManager
    {
        IModelComponent _modelComponent;
        public PermissionManager(IModelComponent modelComponent)
        {
            _modelComponent = modelComponent;
        }
        //public bool ValidatePermission(string username)
        //{
        //    return true;
        //}
        public bool ValidateAdminPermission(IMember member)
        {
            return member.MemberType >= Member.MemberTypes.Administrator;
        }
        public bool ValidateServiceAcces(IMember member, IService service)
        {
            return member.SystemRights >= service.SystemRights;
        }
    }
}
