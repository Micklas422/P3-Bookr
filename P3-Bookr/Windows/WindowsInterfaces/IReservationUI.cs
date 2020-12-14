﻿using P3_Bookr.Models;
using P3_Bookr.Windows.ReservationPanels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Windows.WindowsInterfaces
{
    public interface IReservationUI
    {
        bool CreateNewReservation(Service service, ServiceOffering serviceOffering, DateTime dateTime);
        //void LoadReservationsOfMember();
        void CancelReservation();
        ReservationPage LoadReservationsOfMember();
        void CancelReservation(Reservation reservation);
    }
}
