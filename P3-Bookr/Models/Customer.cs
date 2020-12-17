using System;
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

        List<IDepartment> departments = new List<IDepartment>();
        List<IMember> members = new List<IMember>();

        public Customer(bool isActive, DateTime creationDate, string name, string adress, string email)
        {
            IsActive = isActive;
            CreationDate = creationDate;
            Name = name;
            Adress = adress;
            Email = email;
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
        public List<IDepartment> Departments
        {
            get { return departments; }
            set { departments = value; }
        }
        public List<IMember> Members
        {
            get { return members; }
            set { members = value; }
        }
    }
}
