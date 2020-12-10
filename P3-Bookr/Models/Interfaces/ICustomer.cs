using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    interface ICustomer
    {
        bool IsActive { get; set; }
        DateTime CreationDate { get; set; }
        string Name { get; set; }
        string Adress { get; set; }
        string Email { get; set; }
        int Id { get; }
        List<Department> Departments { get; set; }
        List<Member> Members { get; set; }
        void CreateMember();
        void DeleteMember();
    }
}
