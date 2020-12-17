﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    interface IDepartment
    {
        bool IsActive { get; set; }
        string Name { get; set; }
        string Adress { get; set; }
        string Description { get; set; }
        Customer Customer { get; set; }
        List<Service> Services { get; set; }
    }
}
