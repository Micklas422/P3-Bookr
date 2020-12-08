﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Models;

namespace P3_Bookr.DAL.Interfaces
{
    interface ITimeperiodDAL
    {
        List<TimePeriod> GetTimeperiods(int serviceId);
        void SetTimePeriods(List<TimePeriod> timeperiods);
    }
}