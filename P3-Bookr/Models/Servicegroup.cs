using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    class Servicegroup
    {
        string _name;
        public enum ServiceType
        {
            //implemeteres i commons/membertypes
        };
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
