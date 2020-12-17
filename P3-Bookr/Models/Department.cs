using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    public class Department : IDepartment
    {
        bool _isActive;
        string _name;
        string _adress;
        string _description;
        ICustomer _customer;
        List<IService> _services = new List<IService>();

        public Department(ICustomer customer, string name)
        {
            Customer = customer;
            Name = name;
        }

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
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

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public List<IService> Services
        {
            get { return _services; }
            set { _services = value; }
        }

        public ICustomer Customer { get => _customer; set => _customer = value; }
    }
}
