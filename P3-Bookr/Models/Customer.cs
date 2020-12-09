using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    class Customer : ICustomer
    {
        static List<int> UniqueIds = new List<int>();

        int _id;
        bool _isActive;
        DateTime _creationDate;
        string _name;
        string _adress;
        string _email;

        List<Department> departments = new List<Department>();
        List<Member> members = new List<Member>();

        public Customer(int id,  bool isActive, DateTime creationDate, string name, string adress, string email)
        {
            if (UniqueIds.Contains(id))
                throw new ArgumentException();
            UniqueIds.Add(id);
            _id = id;
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
        public int Id
        {
            get { return _id; }
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
