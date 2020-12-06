using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    class ServiceOffering
    {
        string _name;
        int _duration;
        float _price;
        public ServiceOffering()
        {

        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
