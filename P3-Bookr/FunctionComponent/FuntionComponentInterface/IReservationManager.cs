using System;
using P3_Bookr.Models;
using System.Collections.Generic;

namespace P3_Bookr.FunctionComponent
{
    public interface IReservationManager
    {
        List<Reservation> GetActiveReservationsByMember(Member member);

        bool CreateReservation(Member member, Service service, ServiceOffering serviceOffering, DateTime dateTime);
        void CancelReservation(Reservation reservation);
        void CancelPayment(List<Payment> payments);
    }
}
