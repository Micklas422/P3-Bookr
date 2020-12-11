using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Commons.Enums;

namespace P3_Bookr.Models
{
    interface IReservation
    {
        DateTime CreationDate { get; set; }
        DateTime CancellationDate { get; set; }
        ReservationStates ReservationState { get; set; }
        DateTime ReservationDate { get; set; }
        int Duration { get; set; }
        DateTime ReservationDeadline { get; set; }
        int Id { get; }
        int MemberId { get; set; }
    }
}
