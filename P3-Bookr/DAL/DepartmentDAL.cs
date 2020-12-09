﻿using System;
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
        string fileName = "Departments";
        JsonHandler jsonHandler = new JsonHandler();

        public List<Department> Departments { get => _department; set => _department = value; }

        public DepartmentDAL(int customerId)
        {
            _department = LoadDepartments(customerId);
        }

        public List<Department> LoadDepartments(int customerId)
        {
            List<Department> departments;
            departments = jsonHandler.ReadJsonObjectFromFile<List<Department>>(fileName).Where(c => c.CustomerId == customerId).ToList();
            return departments;
        }

        public void SetDepartments(List<Department> department)
        {
            jsonHandler.WriteJsonObjectToFile(fileName, department);
        }

        public void UpdateDepartment(Department department)
        { 
        
            Departments.Where(c => c.Id== department.Id ).Select(c => c = department);
        }
    }
}
