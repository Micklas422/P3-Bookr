using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models.Interfaces
{
    interface ITimeperiod
    {
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        bool ServiceUsed { get; set; }
    }
}
