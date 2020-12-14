using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.DAL.Interfaces;
using P3_Bookr.Models;

namespace P3_Bookr.DAL
{
    class ReservationDAL : IReservationDAL
    {
        public List<Reservation> Reservations => throw new NotImplementedException();

        public Reservation GetReservation(int reservationId)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetReservationsByMember(int memberId)
        {
            throw new NotImplementedException();
        }

        public void SetRevervations(List<Reservation> reservations)
        {
            throw new NotImplementedException();
        }
    }
}
