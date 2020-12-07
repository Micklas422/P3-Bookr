using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models.Interfaces
{
    interface IDepartment
    {
        bool IsActive { get; set; }
        string Name { get; set; }
        string Adress { get; set; }
        string Description { get; set; }
        void createService();
        void deleteService();
    }
}
