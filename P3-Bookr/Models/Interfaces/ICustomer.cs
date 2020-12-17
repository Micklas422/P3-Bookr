using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    public interface ICustomer
    {
        bool IsActive { get; set; }
        DateTime CreationDate { get; set; }
        string Name { get; set; }
        string Adress { get; set; }
        string Email { get; set; }
        List<IDepartment> Departments { get; set; }
        List<IMember> Members { get; set; }
    }
}
