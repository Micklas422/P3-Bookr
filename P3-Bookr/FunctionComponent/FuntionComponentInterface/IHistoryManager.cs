using P3_Bookr.Models;
using System.Collections.Generic;

namespace P3_Bookr.FunctionComponent
{
    public  interface IHistoryManager
    {
        List<Reservation> SeeHistory(Member member);
        List<Service> GetLastUsedServices(Member member, int count);
    }
}
