using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Windows.WindowsInterfaces;
using P3_Bookr.Windows;
using System.Windows.Forms;

namespace P3_Bookr
{
    class UIController: ISideMenu
    {
        bool stayAlive = false;
        MainWindow mainWindow;
        public UIController()
        {
            mainWindow = new MainWindow();
            mainWindow.panelSideBar.Controls.Clear();
            mainWindow.panelSideBar.Controls.Add(new SideBar(this));
            //mainWindow.panelSideBar.Controls[0].Show();
            Application.Run(mainWindow);
        }

        #region SideMenuHandler
        public void SwitchToHistoryPage()
        {
            throw new NotImplementedException();
        }

        public void SwitchToHomePage()
        {
            throw new NotImplementedException();
        }

        public void SwitchToLogInPage()
        {
            throw new NotImplementedException();
        }

        public void SwitchToReservationPage()
        {
            throw new NotImplementedException();
        }

        public void SwitchToServicePage()
        {
            throw new NotImplementedException();
        }

        public void SwitchToSettingsPage()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
