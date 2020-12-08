using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;

namespace P3_Bookr.DAL.Interfaces
{
    interface IReservationDAL
    {
        List<Reservation> GetReservations(int memberId);
        void SetRevervations(List<Reservation> reservations);
    }
}
