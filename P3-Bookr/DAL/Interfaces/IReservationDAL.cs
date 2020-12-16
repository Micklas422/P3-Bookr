using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;

namespace P3_Bookr.DAL.Interfaces
{
    public interface IReservationDAL
    {
        List<Reservation> Reservations { get; }
        List<Reservation> GetReservationsByMember(int memberId);
        Reservation GetReservation(int reservationId);
        void SetRevervations(List<Reservation> reservations);
    }
}
