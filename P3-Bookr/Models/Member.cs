using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Commons.Enums;

namespace P3_Bookr.Models
{
    public class Member : IMember
    {
        public enum MemberTypes
        {
            Renter,
            Member,
            Administrator,
            Employee
        };

        string _firstName;
        string _lastName;
        bool _isActive;
        string _memberNumber;
        string _rentalNumber;
        string _adress;
        string _email;
        string _username;
        string _password;
        SystemRights _systemRights;
        MemberTypes _memberType;
        ICustomer _customer;
        List<IReservation> _reservations = new List<IReservation>();
        List<IDepartment> _departments = new List<IDepartment>();

        public Member(ICustomer customer, string firstName, string lastName, string adress)
        {
            Customer = customer;
            FirstName = firstName;
            LastName = lastName;
            Adress = adress;         
        }

        public bool IsCustomerActive
        {
            get
            {
                return Customer != null ? Customer.IsActive : false;
            }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        public string MemberNumber
        {
            get { return _memberNumber; }
            set { _memberNumber = value; }
        }

        public string RentalNumber
        {
            get { return _rentalNumber; }
            set { _rentalNumber = value; }
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

        public MemberTypes MemberType
        {
            get { return _memberType; }
            set { _memberType = value; }
        }

        public SystemRights SystemRights
        {
            get { return _systemRights; }
            set { _systemRights = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public List<IReservation> Reservations
        {
            get { return _reservations; }
            set { _reservations = value; }
        }

        public ICustomer Customer { get => _customer; private set => _customer = value; }
        public List<IDepartment> Departments { get => _departments; set => _departments = value; }
    }
}
