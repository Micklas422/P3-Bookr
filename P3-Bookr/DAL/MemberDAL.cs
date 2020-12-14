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
        List<Member> _members;
        string _fileName = "Members";
        JsonHandler _JsonHandler = new JsonHandler();

        public MemberDAL()
        {
            Members = LoadMembers();
        }

        public List<Member> Members { get => _members; private set => _members = value; }

        List<Member> LoadMembers()
        {
            List<Member> members;
            members = _JsonHandler.ReadJsonObjectFromFile<List<Member>>(_fileName);
            return members;
        }

        //public Member GetMember(int id)
        //{
        //    return Members.Where(m => m.Id == id).FirstOrDefault();
        //}

        public List<Member> GetMembersByCustomer(Customer customer)
        {
            return Members.Where(m => m.Customer.Id == customer.Id).ToList();
        }

        public void UpdateMember(Member member)
        {
            Members.Where(m => m.Equals(member)).Select(m => m = member);
        }

        public void SetMembers(List<Member> members)
        {
            Members = members;
            _JsonHandler.WriteJsonObjectToFile(_fileName, members);
        }
    }
}