using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;

namespace P3_Bookr.FunctionComponent
{
    public class HistoryManager : IHistoryManager
    {
        IModelComponent _modelComponent;
        public HistoryManager(IModelComponent modelComponent)
        {
            _modelComponent = modelComponent;
        }

        public List<IReservation> SeeHistory(IMember member)
        {
            return _modelComponent.GetAllReservationsByMember(member)
                .Where(r => r.ReservationState == Commons.Enums.ReservationStates.Finalised).ToList();
        }

        public List<IService> GetLastUsedServices(IMember member, int count)
        {
            List<IService> result = new List<IService>();
            List<IReservation> reservations = _modelComponent.GetAllReservationsByMember(member);

            reservations = reservations.OrderByDescending(r => r.CreationDate).ToList();
            foreach (IReservation res in reservations)
            {
                if (result.Count() == count)
                    break;
                if (!result.Contains(res.ServiceOffering.Service))
                {
                    result.Add(res.ServiceOffering.Service);
                }
            }
            return result;
        }
    }
}
