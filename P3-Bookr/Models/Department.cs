using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    class Department : IDepartment
    {
        static List<int> UniqueIds = new List<int>();

        int _id;
        int _customerId;
        bool _isActive;
        string _name;
        string _adress;
        string _description;

        List<Services> services = new List<Services>();

        public Department(int id, bool isActive, string name, string adress, string description)
        {
            if (UniqueIds.Contains(id))
                throw new ArgumentException();
            UniqueIds.Add(id);
            _id = id;
            _isActive = isActive;
            _name = name;
            _adress = adress;
            _description = description;
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

        public int Id
        {
            get { return _id; }
        }

        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        public void createService()
        {
            throw new NotImplementedException();
        }

        public void deleteService()
        {
            throw new NotImplementedException();
        }
    }
}
