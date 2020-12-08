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
        string fileName = "Departments";
        JsonHandler jsonHandler = new JsonHandler();

        public List<Department> GetDepartments(int customerId)
        {
            List<Department> departments;
            departments = jsonHandler.ReadJsonObjectFromFile<List<Department>>(fileName).Where(c => c.CustomerId == customerId).ToList();
            return departments;
        }

        public void SetDepartments(List<Department> departments)
        {
            jsonHandler.WriteJsonObjectToFile(fileName, departments);
        }
    }
}
