using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Models
{
    public class TimePeriod : ITimeperiod
    {
        static List<int> UniqueIds = new List<int>();

        int _id;
        int _ServicesId;
        DateTime _startTime;
        DateTime _endTime;
        bool _serviceUsed;
        Payment _payment;
        Service _service;

        public TimePeriod(int id, DateTime startTime, DateTime endTime, Payment payment, Service service)
        {
            if (UniqueIds.Contains(id))
                throw new ArgumentException("Id most be unquie");
            UniqueIds.Add(id);
            _id = id;
            _startTime = startTime;
            _endTime = endTime;
            Payment = payment;
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
        public int Id
        {
            get { return _id; }
        }
        public int ServicesId
        {
            get { return _ServicesId; }
            set { _ServicesId = value; }
        }

        public Payment Payment { get => _payment; private set => _payment = value; }
        internal Service Serivce { get => _service; set => _service = value; }
    }
}
