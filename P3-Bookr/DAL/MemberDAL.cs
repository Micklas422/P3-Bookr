using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.DAL.Interfaces;
using P3_Bookr.Models;

namespace P3_Bookr.DAL
{
    class MemberDAL : InterfaceMemberDAL
    {
        JsonHandler JsonHandler = new JsonHandler();

        public List<Member> LoadUsers()
        {
            List<Member> members = new List<Member>();
            members = JsonHandler.ReadJsonObjectFromFile<List<Member>>("");
            return members;
        }
    }
}
