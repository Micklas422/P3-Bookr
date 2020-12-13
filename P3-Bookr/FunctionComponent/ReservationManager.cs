using System;
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
        public ReservationManager(IModelComponent modelComponent)
        {
            _modelComponent = modelComponent;
        }

        public bool CreateReservation(Member member, Service service, ServiceOffering serviceOffering, DateTime dateTime)
        {
            return true;
        }

        public List<Reservation> GetActiveReservationsByMember(Member member)
        {
            return _modelComponent.GetAllReservationsByMemberId(member.Id).
                Where(r => (ReservationStates) r.ReservationState != ReservationStates.Cancelled).ToList();
        }

        public bool CancelReservation(Reservation reservation, Member member)
        {
            return _modelComponent.CancelReservation(reservation, member);
        }
    }
}