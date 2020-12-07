using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models.Interfaces
{
    interface ICustommer
    {
        bool IsActive { get; set; }
        DateTime CreationDate { get; set; }
        string Name { get; set; }
        string Adress { get; set; }
        string Email { get; set; }
        void CreateMember();
        void DeleteMember();
    }
}
