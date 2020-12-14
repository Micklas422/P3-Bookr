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
        public List<TimePeriod> TimePeriods => throw new NotImplementedException();

        public List<TimePeriod> GetTimePeriodsByService(int serivceId)
        {
            throw new NotImplementedException();
        }

        public void SetTimePeriods(List<TimePeriod> timeperiods)
        {
            throw new NotImplementedException();
        }
    }
}
