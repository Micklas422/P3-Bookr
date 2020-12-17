using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Commons.Enums;
using System.Timers;
using System.Diagnostics;

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
        Timer _stateHandlerTimer;


        public Reservation(DateTime reservationDate, Member member, TimePeriod timePeriod, ServiceOffering serviceOffering, Payment payment)
        {
            Payment = payment;
            ReservationDate = reservationDate;
            ReservationDeadline = reservationDate.AddDays(-1);
            Member = member;
            TimePeriod = timePeriod;
            ServiceOffering = serviceOffering;
            StateHandlerTimer = new Timer(5000);
            StateHandlerTimer.Elapsed += OnTimedEvent;
            StateHandlerTimer.AutoReset = true;
            StateHandlerTimer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            StateHandler();
        }
        private void StateHandler()
        {
            if (ReservationDeadline <= DateTime.Now)
            {
                ReservationState = ReservationStates.BindingReservation;
                Payment.StateHandler(ReservationStates.BindingReservation);
            }
            if (ReservationDate <= DateTime.Now)
            {
                ReservationState = ReservationStates.Finalised;
                Payment.StateHandler(ReservationStates.Finalised);
            }
        }
        private Timer StateHandlerTimer
        {
            get { return _stateHandlerTimer; }
            set { _stateHandlerTimer = value; }
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
            get { return ServiceOffering.Duration; }
            
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
