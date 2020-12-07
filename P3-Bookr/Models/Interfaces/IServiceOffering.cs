using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models.Interfaces
{
    interface IServiceOffering
    {
        string Name { get; set; }
        int Duration { get; set; }
        float Price { get; set; }
    }
}
