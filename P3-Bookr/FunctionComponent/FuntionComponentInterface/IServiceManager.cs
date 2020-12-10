using P3_Bookr.Models;
using System.Collections.Generic;

namespace P3_Bookr.FunctionComponent
{
    public interface IServiceManager
    {
        List<Service> GetActiveServices();
        void Reserve();

        void SeeAvailability();
    }
}
