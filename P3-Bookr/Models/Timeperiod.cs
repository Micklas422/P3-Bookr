using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    public class TimePeriod : ITimePeriod
    {
        DateTime _startTime;
        DateTime _endTime;
        bool _serviceUsed;
        IService _service;

        public TimePeriod(DateTime startTime, DateTime endTime, IService service)
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
        internal IService Serivce { get => _service; set => _service = value; }
    }
}
