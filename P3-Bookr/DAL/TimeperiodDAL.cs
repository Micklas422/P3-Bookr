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
        string fileName = "TimerPeriods";
        JsonHandler jsonHandler = new JsonHandler();
        public List<TimePeriod> GetTimeperiods(int serviceId)
        {
            List<TimePeriod> timePeriods;
            timePeriods = jsonHandler.ReadJsonObjectFromFile<List<TimePeriod>>(fileName).Where(t => t.ServicesId == serviceId).ToList();
            return timePeriods;
        }

        public void SetTimePeriods(List<TimePeriod> timePeriods)
        {
            jsonHandler.WriteJsonObjectToFile(fileName, timePeriods);
        }
    }
}
