using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    class TimePeriod : ITimeperiod
    {
        static List<int> UniqueIds = new List<int>();

        int _id;
        int _ServicesId;
        DateTime _startTime;
        DateTime _endTime;
        bool _serviceUsed;

        public TimePeriod(int id, DateTime startTime, DateTime endTime)
        {
            if (UniqueIds.Contains(id))
                throw new ArgumentException();
            UniqueIds.Add(id);
            _id = id;
            _startTime = startTime;
            _endTime = endTime;
        }

        public DateTime StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }
        public DateTime EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }
        public bool ServiceUsed
        {
            get { return _serviceUsed; }
            set { _serviceUsed = value; }
        }
        public int Id
        {
            get { return _id; }
        }
        public int ServicesId
        {
            get { return _ServicesId; }
            set { _ServicesId = value; }
        }
    }
}
