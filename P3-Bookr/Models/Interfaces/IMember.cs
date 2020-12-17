using P3_Bookr.Commons.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    public interface IMember
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        bool IsActive { get; set; }
        string MemberNumber { get; set; }
        string RentalNumber { get; set; }
        string Adress { get; set; }
        string Email { get; set; }
        Member.MemberTypes MemberType { get; set; }
        SystemRights SystemRights { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        bool IsCustomerActive { get; }
        ICustomer Customer { get; }
        List<IReservation> Reservations { get; set; }
        List<IDepartment> Departments { get; set; }
    }
}
