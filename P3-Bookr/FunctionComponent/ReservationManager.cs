﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;
using P3_Bookr.Commons.Enums;

namespace P3_Bookr.FunctionComponent
{
    class ReservationManager : IReservationManager
    {
        IModelComponent _modelComponent;
        IPaymentManager _paymentManager;
        public ReservationManager(IModelComponent modelComponent, IPaymentManager paymentManager)
        {
            _modelComponent = modelComponent;
            _paymentManager = paymentManager;
        }

        public bool CreateReservation(Member member, Service service, ServiceOffering serviceOffering, DateTime dateTime)
        {
            TimePeriod p = new TimePeriod(dateTime, dateTime.AddMinutes(serviceOffering.Duration), service);
            Reservation r = new Reservation(dateTime,
                member,
                p,
                serviceOffering,
                new Payment(DateTime.Now, serviceOffering.Price));

            _modelComponent.customer.Members.Where(m => m.Equals(member)).FirstOrDefault().Reservations.Add(r);
            service.TimePeriods.Add(p);
            return true;
        }

        public List<Reservation> GetActiveReservationsByMember(Member member)
        {
            return _modelComponent.GetAllReservationsByMember(member).
                Where(r => r.ReservationState != ReservationStates.Cancelled).ToList();
        }

        public bool CancelReservation(Reservation reservation)
        {
            if(DateTime.Now < reservation.ReservationDeadline)
            {
                if (_paymentManager.Cancel(reservation.Payment))
                {
                    reservation.CancellationDate = DateTime.Now;
                    reservation.ReservationState = ReservationStates.Cancelled;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}