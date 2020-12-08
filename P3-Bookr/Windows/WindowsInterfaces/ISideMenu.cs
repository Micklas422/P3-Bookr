using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Windows.WindowsInterfaces
{
    public delegate void SideBarEvent(SideBarButtons sideBarButtons);

    public enum SideBarButtons
    {

    }
    public interface ISideMenu
    {
        void SwitchToHomePage();


    }
}
