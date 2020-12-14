using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Commons.Enums;

namespace P3_Bookr.Models
{
    interface IServicegroup
    {
        string Name { get; set; }
        ServiceTypes ServiceType { get; set; }
    }
}
