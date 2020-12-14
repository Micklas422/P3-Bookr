using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Commons.Enums;

namespace P3_Bookr.Models
{
    public class Reservation : IReservation
    {
        DateTime _creationDate;
        DateTime _cancellationDate;
        ReservationStates _reservationState;
        DateTime _reservationDate;
        int _duration;
        DateTime _reservationDeadline;
        TimePeriod _timePeriod;
        Member _member;
        ServiceOffering _serviceOffering;
        Payment _payment;


        public Reservation(DateTime reservationDate, Member member, TimePeriod timePeriod, ServiceOffering serviceOffering, Payment payment)
        {
            Payment = payment;
            ReservationDate = reservationDate;
            Member = member;
            TimePeriod = timePeriod;
            ServiceOffering = serviceOffering;
        }
        public DateTime CreationDate
        {
            get { return _creationDate; }
            set { _creationDate = value; }
        }
        public DateTime CancellationDate
        {
            get { return _cancellationDate; }
            set { _cancellationDate = value; }
        }
        public ReservationStates ReservationState
        {
            get { return _reservationState; }
            set { _reservationState = value; }
        }
        public DateTime ReservationDate
        {
            get { return _reservationDate; }
            set { _reservationDate = value; }
        }
        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        public DateTime ReservationDeadline
        {
            get { return _reservationDeadline; }
            set { _reservationDeadline = value; }
        }

        public Payment Payment
        {
            get { return _payment; }
            set { _payment = value; }
        }

        public Member Member { get => _member; set => _member = value; }
        internal TimePeriod TimePeriod { get => _timePeriod; set => _timePeriod = value; }
        internal ServiceOffering ServiceOffering { get => _serviceOffering; set => _serviceOffering = value; }
    }
}
