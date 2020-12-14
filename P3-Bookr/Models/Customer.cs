﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    public class Customer : ICustomer
    {
        bool _isActive;
        DateTime _creationDate;
        string _name;
        string _adress;
        string _email;

        List<Department> departments = new List<Department>();
        List<Member> members = new List<Member>();

        public Customer(bool isActive, DateTime creationDate, string name, string adress, string email)
        {
            _isActive = isActive;
            _creationDate = creationDate;
            _name = name;
            _adress = adress;
            _email = email;
        }

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        public DateTime CreationDate
        {
            get { return _creationDate; }
            set { _creationDate = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public List<Department> Departments
        {
            get { return departments; }
            set { departments = value; }
        }
        public List<Member> Members
        {
            get { return members; }
            set { members = value; }
        }
        public void CreateMember()
        {
            throw new NotImplementedException();
        }
        public void DeleteMember()
        {
            throw new NotImplementedException();
        }
    }
}
