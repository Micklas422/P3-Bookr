using P3_Bookr.Models;
using System.Collections.Generic;

namespace P3_Bookr.FunctionComponent
{
    public  interface IHistoryManager
    {
        List<IReservation> SeeHistory(IMember member);
        List<IService> GetLastUsedServices(IMember member, int count);
    }
}
