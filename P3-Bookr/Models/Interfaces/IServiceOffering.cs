using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    interface IServiceOffering
    {
        string Name { get; set; }
        int Duration { get; set; }
        float Price { get; set; }
        int Id { get; }
        int ServicesId { get; set; }
    }
}
