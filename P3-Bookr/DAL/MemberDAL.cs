using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.DAL.Interfaces;
using P3_Bookr.Models;

namespace P3_Bookr.DAL
{
    class MemberDAL : IMemberDAL
    {
        string fileName = "Members";
        JsonHandler JsonHandler = new JsonHandler();

        public List<Member> LoadMembers(int customerId)
        {
            List<Member> members;
            members = JsonHandler.ReadJsonObjectFromFile<List<Member>>(fileName);
            return members;
        }

        public void SaveMembers(List<Member> members)
        {
            JsonHandler.WriteJsonObjectToFile(fileName, members);
        }
    }
}
