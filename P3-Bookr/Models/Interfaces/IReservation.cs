using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Commons.Enums;

namespace P3_Bookr.Models
{
    public interface IReservation
    {
        IPayment Payment { get; set; }
        DateTime CreationDate { get; set; }
        DateTime CancellationDate { get; set; }
        ReservationStates ReservationState { get; set; }
        IServiceOffering ServiceOffering { get; set; }
        DateTime ReservationDate { get; set; }
        int Duration { get; }
        DateTime ReservationDeadline { get; set; }
    }
}
