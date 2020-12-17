using System;
using P3_Bookr.Models;
using System.Collections.Generic;

namespace P3_Bookr.FunctionComponent
{
    public interface IReservationManager
    {
        List<IReservation> GetActiveReservationsByMember(IMember member);

        bool CancelReservation(IReservation reservation);

        bool CreateReservation(IMember member, IService service, IServiceOffering serviceOffering, DateTime dateTime);
    }
}
