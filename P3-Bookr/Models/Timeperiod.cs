using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    public class TimePeriod : ITimeperiod
    {
        DateTime _startTime;
        DateTime _endTime;
        bool _serviceUsed;
        Service _service;

        public TimePeriod(DateTime startTime, DateTime endTime, Service service)
        {
            _startTime = startTime;
            _endTime = endTime;
            Serivce = service;
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
        internal Service Serivce { get => _service; set => _service = value; }
    }
}
