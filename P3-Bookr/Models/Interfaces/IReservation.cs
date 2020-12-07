using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models.Interfaces
{
    interface IReservation
    {
        DateTime CreationDate { get; set; }
        DateTime CancellationDate { get; set; }
        Reservation.ReservationStates ReservationState { get; set; }
        DateTime ReservationDate { get; set; }
        int Duration { get; set; }
        DateTime ReservationDeadline { get; set; }
    }
}
