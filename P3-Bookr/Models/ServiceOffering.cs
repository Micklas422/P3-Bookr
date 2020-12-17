using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    public class ServiceOffering : IServiceOffering
    {
        string _name;
        int _duration;
        float _price;
        IService _service;

        public ServiceOffering(string name, int duration, float price, IService service)
        {
            _name = name;
            _duration = duration;
            _price = price;
            _service = service;
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
        public IService Service
        {
            get { return _service; }
            set { _service = value; }
        }
    }
}
