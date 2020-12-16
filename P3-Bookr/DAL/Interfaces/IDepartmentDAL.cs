using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;

namespace P3_Bookr.DAL.Interfaces
{
    public interface IDepartmentDAL
    {
        List<Department> Departments { get; }
        List<Department> GetDepartmentsByCustomerId(int customerId);
        //Department GetDepartment(int id);
        void UpdateDepartment(Department department);
        void SetDepartments(List<Department> departments);
    }
}
