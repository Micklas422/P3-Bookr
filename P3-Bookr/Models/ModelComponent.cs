using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Commons.Enums;
using P3_Bookr.Commons.CustomExceptions;

namespace P3_Bookr.Models
{
    public class ModelComponent: IModelComponent
    {
        ICustomer _customer;

        public ModelComponent()
        {
        }

        public ICustomer customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        public List<IReservation> GetAllReservationsByMember(IMember member)
        {
            List<IReservation> result = new List<IReservation>();
            
            foreach (IMember mem in _customer.Members)
            {
                if (mem.Equals(member))
                {
                    foreach (IReservation res in mem.Reservations)
                    {
                        result.Add(res);
                    }
                    break;
                }
            }
         
            return result;
        }

        public IMember GetMemberByUsername(string username)
        {
            IMember member = null;
            try
            {
                member = _customer.Members.Where(m => m.Username == username).FirstOrDefault();
            }
            catch (Exception ex)
            {
                member = null;
                Debug.WriteLine(ex);
            }

            if (member == null)
                throw new UserNotFoundException($"Could not find any users with username: {username}");
            else
                return member;
        }

        public List<IService> GetAllServices()
        {
            List<IService> result = new List<IService>();
            foreach (IDepartment dep in _customer.Departments)
            {
                foreach (IService ser in dep.Services)
                {
                    result.Add(ser);
                }
            }
            return result;
        }
    }
}
