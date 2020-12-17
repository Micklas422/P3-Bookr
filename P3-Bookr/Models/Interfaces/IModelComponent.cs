using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    public interface IModelComponent
    {
        ICustomer customer { get; set; }
        List<IReservation> GetAllReservationsByMember(IMember member);
        IMember GetMemberByUsername(string username);
        List<IService> GetAllServices();
    }
}
