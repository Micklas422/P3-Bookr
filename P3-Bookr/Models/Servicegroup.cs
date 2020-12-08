using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Commons.Enums;

namespace P3_Bookr.Models
{
    class ServiceGroup : IServicegroup
    {
        static List<int> UniqueIds = new List<int>();

        int _id;
        string _name;
        ServiceTypes _serviceType;

        public ServiceGroup(int id, string name, ServiceTypes serviceType)
        {
            if (UniqueIds.Contains(id))
                throw new ArgumentException();
            UniqueIds.Add(id);
            _id = id;
            _name = name;
            _serviceType = serviceType;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public ServiceTypes ServiceType
        {
            get { return _serviceType; }
            set { _serviceType = value; }
        }

        public int Id
        {
            get { return _id; }
        }
    }
}
