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
            StartTime = startTime;
            EndTime = endTime;
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
        internal Service Serivce { get => _service; set => _service = value; }
    }
}
