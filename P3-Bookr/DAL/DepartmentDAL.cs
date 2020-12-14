using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.DAL.Interfaces;
using P3_Bookr.Models;

namespace P3_Bookr.DAL
{
    class DepartmentDAL : IDepartmentDAL
    {
        public List<Department> Departments => throw new NotImplementedException();

        public List<Department> GetDepartmentsByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }

        public void SetDepartments(List<Department> departments)
        {
            throw new NotImplementedException();
        }

        public void UpdateDepartment(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
