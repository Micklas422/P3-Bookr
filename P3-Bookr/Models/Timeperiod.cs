using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    class Timeperiod : ITimeperiod
    {
        int _id;
        int _ServicesId;
        DateTime _startTime;
        DateTime _endTime;
        bool _serviceUsed;

        public Timeperiod(DateTime startTime, DateTime endTime)
        {
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
