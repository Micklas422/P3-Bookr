using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;

namespace P3_Bookr.DAL.Interfaces
{
    interface IMemberDAL
    {
        List<Member> GetMembers(int customerId);
        void SetMembers(List<Member> members);
    }
}
