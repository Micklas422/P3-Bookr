﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Windows.WindowsInterfaces
{
    public interface IServicesUI
    {
        void SelectService();
        void SelectServiceType();
        void SelectDate();
        void SelectTime();
        void Book();
        void SwitchToService();
        void LoadInfoPanelForService();
        void LoadandExecutePanelForServiceBooking();
    }
}
