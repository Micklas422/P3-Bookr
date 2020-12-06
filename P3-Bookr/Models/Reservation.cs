using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    class Reservation
    {
        DateTime _creationDate;
        DateTime _cancellationDate;
        public enum ReservationState
        {
            //implemeteres i commons/membertypes
        };
        DateTime _date;
        int _duration;
        DateTime _reservationDeadline;
        public Reservation()
        {

        }
        public DateTime CreationDate
        {
            get { return _creationDate; }
            set { _creationDate = value; }
        }
        public DateTime CancellationDate
        {
            get { return _cancellationDate; }
            set { _cancellationDate = value; }
        }
        //ReservationState (get/set)
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        public DateTime ReservationDeadline
        {
            get { return _reservationDeadline; }
            set { _reservationDeadline = value; }
        }
    }
}
