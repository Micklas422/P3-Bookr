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
        string fileName = "Reservations";
        JsonHandler jsonHandler = new JsonHandler();
        public List<Reservation> GetReservations(int memberId)
        {
            List<Reservation> reservations;
            reservations = jsonHandler.ReadJsonObjectFromFile<List<Reservation>>(fileName).Where(m => m.MemberId == memberId).ToList();
            return reservations;
        }

        public void SetRevervations(List<Reservation> reservations)
        {
            jsonHandler.WriteJsonObjectToFile(fileName, reservations);
        }
    }
}
