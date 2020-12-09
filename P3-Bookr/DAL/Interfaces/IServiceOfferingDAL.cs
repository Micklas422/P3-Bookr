using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;

namespace P3_Bookr.DAL.Interfaces
{
    interface IServiceOfferingDAL
    {
        List<ServiceOffering> LoadServiceOfferings(int serviceId);
        void SetServiceOfferings(List<ServiceOffering> serviceOfferings);
    }
}
