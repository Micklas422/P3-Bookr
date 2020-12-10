using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    public class ServiceOffering : IServiceOffering
    {
        static List<int> UniqueIds = new List<int>();

        int _id;
        int _servicesId;
        string _name;
        int _duration;
        float _price;

        public ServiceOffering(int id, string name, int duration, float price)
        {
            if (UniqueIds.Contains(id))
                throw new ArgumentException();
            UniqueIds.Add(id);
            _id = id;
            _name = name;
            _duration = duration;
            _price = price;
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

        public int Id
        {
            get { return _id; }
        }

        public int ServicesId
        {
            get { return _servicesId; }
            set { _servicesId = value; }
        }
    }
}
