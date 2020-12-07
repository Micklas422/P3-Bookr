using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    class Member
    {
        string _firstName;
        string _lastName;
        bool _isActive;
        string _memberNumber;
        string _rentalNumber;
        string _adress;
        string _email;
        bool _customerDeactivated;
        MemberTypes _memberType;
        public enum MemberTypes 
        {
            Renter,
            Member,
            Administrator,
            Employee
        };
        string _username;
        string _password;
        public Member(string firstName, string lastName, bool isActive, string memberNumber, string rentalNumber, string adress, string email, bool customerDeactivated, MemberTypes memberType, string username, string password)
        {
            _firstName = firstName;
            _lastName = lastName;
            _isActive = isActive;
            _memberNumber = memberNumber;
            _rentalNumber = rentalNumber;
            _adress = adress;
            _email = email;
            _customerDeactivated = customerDeactivated;
            _memberType = memberType;
            _username = username;
            _password = password;            
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

        public bool CustomerDeactivated
        {
            get { return _customerDeactivated; }
            set { _customerDeactivated = value; }
        }

        public MemberTypes MemberType
        {
            get { return _memberType; }
            set { _memberType = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _username; }
            set { _username = value; }
        }
     
        public void setPermissions()
        {
            throw new NotImplementedException();
        }

        public void acceptLogin()
        {
            throw new NotImplementedException();
        }
    }
}
