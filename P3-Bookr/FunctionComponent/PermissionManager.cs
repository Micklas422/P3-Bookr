using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;

namespace P3_Bookr.FunctionComponent
{
    class PermissionManager : IPermissionManager
    {
        IModelComponent _modelComponent;
        public PermissionManager(IModelComponent modelComponent)
        {
            _modelComponent = modelComponent;
        }
        public bool ValidatePermission(string username)
        {
            return true;
        }
        public bool ValidateAdminPermission(Member member)
        {
            return member.SystemRights >= Commons.Enums.SystemRights.Admin;
        }
        public bool ValidateServiceAcces(Member member, Service service)
        {
            return member.SystemRights >= service.SystemRights;
        }
    }
}
