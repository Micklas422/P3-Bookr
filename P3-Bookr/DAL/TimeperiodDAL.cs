using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.DAL.Interfaces;
using P3_Bookr.Models;

namespace P3_Bookr.DAL
{
    class TimeperiodDAL : ITimeperiodDAL
    {
        List<TimePeriod> _timePeriods;
        string _fileName = "TimerPeriods";
        JsonHandler _jsonHandler = new JsonHandler();

        public TimeperiodDAL()
        {
            TimePeriods = LoadTimeperiods();
        }

        public List<TimePeriod> TimePeriods { get => _timePeriods; private set => _timePeriods = value; }

        List<TimePeriod> LoadTimeperiods()
        {
            List<TimePeriod> timePeriods;
            timePeriods = _jsonHandler.ReadJsonObjectFromFile<List<TimePeriod>>(_fileName);
            return timePeriods;
        }

        public List<TimePeriod> GetTimePeriodsByService(int serivceId)
        {
            return TimePeriods.Where(t => t.ServicesId == serivceId).ToList();
        } 

        public void SetTimePeriods(List<TimePeriod> timePeriods)
        {
            _jsonHandler.WriteJsonObjectToFile(_fileName, timePeriods);
        }
    }
}
