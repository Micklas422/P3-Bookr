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
    class ModelComponent: IModelComponent
    {
        IDataAccesLayer _dataAccesLayer;
        Customer _customer;

        public ModelComponent(IDataAccesLayer dataAccesLayer)
        {
            _dataAccesLayer = dataAccesLayer;
        }

        public Customer customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        public List<Reservation> GetAllReservationsByMember(Member member)
        {
            List<Reservation> result = new List<Reservation>();
            
            foreach (Member mem in _customer.Members)
            {
                if (mem.Equals(member))
                {
                    foreach (Reservation res in mem.Reservations)
                    {
                        result.Add(res);
                    }
                    break;
                }
            }
         
            return result;
        }

        public Member GetMemberByUsername(string username)
        {
            Member member = null;
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
                throw new UserNotFoundException($"Cloud not find user by that username: {username}");
            else
                return member;
        }

        public List<Service> GetAllServices()
        {
            List<Service> result = new List<Service>();
            foreach (Department dep in _customer.Departments)
            {
                foreach (Service ser in dep.Services)
                {
                    result.Add(ser);
                }
            }
            return result;
        }

        //public bool CancelReservation(Reservation reservation, Member member)
        //{
        //    foreach (Customer cus in _customer)
        //    {
        //        foreach (Member mem in cus.Members)
        //        {
        //            if (mem == member)
        //            {
        //                foreach (Reservation res in mem.Reservations)
        //                {
        //                    if (res == reservation)
        //                    {
        //                        res.ReservationState = ReservationStates.Cancelled;
        //                        return true;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return false;
        //}
    }
}
