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
    //Danske navne på ServiceTypes
    //Skal være samme rækkefølge som ServiceTypes!
    public enum ServiceTypesTitel 
    {
        Vaskemaskiner,
        Festlokaler
    }

    public enum ReservationStates
    {
        Created,
        BindingReservation,
        Cancelled,
        Finalised
    };

    public enum SystemRights
    {
        NoRights,
        Member,
        Renter,
        Admin
    }
}