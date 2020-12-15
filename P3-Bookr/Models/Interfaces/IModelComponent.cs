using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    public interface IModelComponent
    {
        List<Customer> customer { get; set; }
        List<Reservation> GetAllReservationsByMember(Member member);
        Member GetMemberByUsername(string username);
        List<Service> GetAllServices();
        //bool CancelReservation(Reservation reservation, Member member);
    }
}
