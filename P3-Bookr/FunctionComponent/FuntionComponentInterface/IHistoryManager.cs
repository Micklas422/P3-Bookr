using P3_Bookr.Models;
using System.Collections.Generic;

namespace P3_Bookr.FunctionComponent
{
    public  interface IHistoryManager
    {
        void SeeHistory();
        List<Service> GetLastUsedServices(Member member, int count);
    }
}
