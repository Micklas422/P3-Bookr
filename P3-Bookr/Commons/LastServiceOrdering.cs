using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;

namespace P3_Bookr.Commons
{
    class LastServiceOrdering : IComparer<Reservation>
    {
        public int Compare(Reservation x, Reservation y)
        {
            int compareService = x.ServiceOffering.CompareTo(y.ServiceOffering);
        }
    }
}
