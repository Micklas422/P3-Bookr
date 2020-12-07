using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static P3_Bookr.Commons.Common;

namespace P3_Bookr.Models
{
    class Servicegroup
    {
        string _name;
        ServiceTypes _type;

        public Servicegroup()
        {

        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //Servicetype (get/set)
    }
}
