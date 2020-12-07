using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    interface IMember
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        bool IsActive { get; set; }
        string MemberNumber { get; set; }
        string RentalNumber { get; set; }
        string Adress { get; set; }
        string Email { get; set; }
        bool CustomerDeactivated { get; set; }
        Member.MemberTypes MemberType { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        void setPermissions();
        bool approveLogin(string username, string password);
    }
}
