using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.DAL;
using P3_Bookr.DAL.Interfaces;
using P3_Bookr.Commons.Enums;
using P3_Bookr.Commons.CustomExceptions;

namespace P3_Bookr.Models
{
    class ModelComponent:IModelComponent
    {
        IDataAccesLayer _dataAccesLayer;
        List<Customer> _customer = new List<Customer>();

        public ModelComponent(IDataAccesLayer dataAccesLayer)
        {
            _dataAccesLayer = dataAccesLayer;
        }

        public List<Customer> customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        public List<Reservation> GetAllReservationsByMember(Member member)
        {
            List<Reservation> result = new List<Reservation>();

            foreach (Customer cus in _customer)
            {
                foreach (Member mem in cus.Members)
                {
                    if (mem.Equals(member))
                    {
                        foreach (Reservation res in mem.Reservations)
                        {
                            result.Add(res);
                        }
                    }
                }
            }
            return result;
        }

        public Member GetMemberByUsername(string username)
        {
            Member member = null;
            try
            {
                foreach (Customer cus in _customer)
                {
                    member = cus.Members.Where(m => m.Username == username).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                member = null;
                Debug.WriteLine(ex);
            }

            if (member == null)
                throw new UserNotFoundException($"Cloud not find user by that username: {username}");
            else
                return member;
        }

        public List<Service> GetAllServices()
        {
            List<Service> result = new List<Service>();
            foreach (Customer cus in _customer)
            {
                foreach (Department dep in cus.Departments)
                {
                    foreach (Service ser in dep.Services)
                    {
                        result.Add(ser);
                    }
                }
            }
            return result;
        }

        public bool CancelReservation(Reservation reservation, Member member)
        {
            foreach (Customer cus in _customer)
            {
                foreach (Member mem in cus.Members)
                {
                    if (mem == member)
                    {
                        foreach (Reservation res in mem.Reservations)
                        {
                            if (res == reservation)
                            {
                                res.ReservationState = ReservationStates.Cancelled;
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}
