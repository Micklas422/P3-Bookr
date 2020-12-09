using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_Bookr.Windows.WindowsInterfaces;
using P3_Bookr.Windows;
using System.Windows.Forms;
using P3_Bookr.Windows.History;
using P3_Bookr.Windows.Frontpage;

namespace P3_Bookr
{
    class UIController : ISideMenuUI, IServicesUI, IReservationUI, IHistorikUI, ILogInUI, IHomepageUI, IAdminToolsUI
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
            mainWindow.panelSiteView.Controls.Clear();
            mainWindow.panelSiteView.Controls.Add(new HistoryPage(this));
        }

        public void SwitchToHomePage()
        {
            mainWindow.panelSiteView.Controls.Clear();
            mainWindow.panelSiteView.Controls.Add(new FrontPageForm(this));
        }

        public void SwitchToLogInPage()
        {
            mainWindow.panelSiteView.Controls.Clear();
            
        }

        public void SwitchToReservationPage()
        {
            throw new NotImplementedException();
        }

        public void SwitchToServicePage()
        {
            mainWindow.panelSiteView.Controls.Clear();
            mainWindow.panelSiteView.Controls.Add(new ServicesOverview(this));
        }

        public void SwitchToSettingsPage()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region ServicesUI
        public void LoadServicesToShow()
        {
            throw new NotImplementedException();
        }
        public void ChooseServices()
        {
            throw new NotImplementedException();
        }

        public void SelectService()
        {
            throw new NotImplementedException();
        }

        public void SelectServiceType()
        {
            throw new NotImplementedException();
        }

        public void SelectDate()
        {
            throw new NotImplementedException();
        }

        public void SelectTime()
        {
            throw new NotImplementedException();
        }

        public void Book()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region ResevationUI
        public void CancelReservation()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region LogInUI
        public void LogIn()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region HomepageUI
        public void LastUsedService()
        {
            throw new NotImplementedException();
        }

        public void News()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region AdminToolsUI
        public void AddUser()
        {
            throw new NotImplementedException();
        }

        public void AddService()
        {
            throw new NotImplementedException();
        }

        public void AddServiceGroup()
        {
            throw new NotImplementedException();
        }

        public void AddUserGroup()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
