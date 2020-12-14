﻿using System;
using P3_Bookr.Models;
using System.Collections.Generic;

namespace P3_Bookr.FunctionComponent
{
    public interface IReservationManager
    {
        List<Reservation> GetActiveReservationsByMember(Member member);

        bool CancelReservation(Reservation reservation, Member member);

        bool CreateReservation(Member member, Service service, ServiceOffering serviceOffering, DateTime dateTime);
    }
}
