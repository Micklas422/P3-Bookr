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
        List<Department> _department;
        string _fileName = "Departments";
        JsonHandler _jsonHandler = new JsonHandler();

        public List<Department> Departments { get => _department; private set => _department = value; }

        public DepartmentDAL()
        {
            Departments = LoadDepartments();
        }

        List<Department> LoadDepartments()
        {
            List<Department> departments;
            departments = _jsonHandler.ReadJsonObjectFromFile<List<Department>>(_fileName);
            return departments;
        }

        public List<Department> GetDepartmentsByCustomerId(int customerId)
        {
            return Departments.Where(d => d.Customer.Id == customerId).ToList();
        }

        //public Department GetDepartment(int id)
        //{
        //    return Departments.Where(d => d == id).FirstOrDefault();
        //}

        public void SetDepartments(List<Department> department)
        {
            _jsonHandler.WriteJsonObjectToFile(_fileName, department);
        }

        public void UpdateDepartment(Department department)
        {
            Departments.Where(c => c.Equals(department)).Select(c => c = department);
        }
    }
}
