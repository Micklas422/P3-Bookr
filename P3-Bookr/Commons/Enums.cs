using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Commons.Enums
{
    public enum ServiceTypes
    {
        WashingMachine,
        CommonRoom
    }

    public enum ReservationStates
    {
        Created,
        BindingReservation,
        Cancelled
    };

    public enum SystemRights
    {
        NoRights,
        Member,
        Renter,
        Admin
    }
}