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
        List<Reservation> _reservations;
        string _fileName = "Reservations";
        JsonHandler _jsonHandler = new JsonHandler();

        public ReservationDAL()
        {
            Reservations = LoadReservations();
        }

        public List<Reservation> Reservations { get => _reservations; private set => _reservations = value; }

        public Reservation GetReservation(int reservationId)
        {
            return Reservations.Where(r => r.Id == reservationId).FirstOrDefault();
        }

        public List<Reservation> GetReservationsByMember(int memberId)
        {
            return Reservations.Where(r => r.MemberId == memberId).ToList();
        }

        public List<Reservation> LoadReservations()
        {
            List<Reservation> reservations;
            reservations = _jsonHandler.ReadJsonObjectFromFile<List<Reservation>>(_fileName);
            return reservations;
        }

        public void SetRevervations(List<Reservation> reservations)
        {
            _jsonHandler.WriteJsonObjectToFile(_fileName, reservations);
        }
    }
}
