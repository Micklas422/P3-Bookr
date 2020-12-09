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
using P3_Bookr.Windows.Reservation;
using P3_Bookr.Windows.Settings;
using P3_Bookr.FunctionComponent;
using P3_Bookr.Models;

namespace P3_Bookr
{
    class UIController : ISideMenuUI, IServicesUI, IReservationUI, IHistorikUI, ILogInUI, IHomepageUI, IAdminToolsUI, ISettingsUI
    {
        bool stayAlive = false;
        MainWindow _mainWindow;
        ILoginManager _logInHandler =new LoginManager();
        Member _currentUser;
        public UIController()
        {
            _mainWindow = new MainWindow();
            _mainWindow.panelSideBar.Controls.Clear();
            _mainWindow.panelSideBar.Controls.Add(new SideBar(this));
            //mainWindow.panelSideBar.Controls[0].Show();
            Application.Run(_mainWindow);
        }

        #region SideMenuHandler
        public void SwitchToHistoryPage()
        {
            _mainWindow.panelSiteView.Controls.Clear();
            _mainWindow.panelSiteView.Controls.Add(new HistoryPage(this));
        }

        public void SwitchToHomePage()
        {
            _mainWindow.panelSiteView.Controls.Clear();
            _mainWindow.panelSiteView.Controls.Add(new FrontPageForm(this));
        }

        public void SwitchToLogInPage()
        {
            _mainWindow.panelSiteView.Controls.Clear();
            _mainWindow.panelForLogIn.Visible = true;
            _mainWindow.panelForLogIn.Controls.Add(new Login(this));
        }

        public void SwitchToReservationPage()
        {
            _mainWindow.panelSiteView.Controls.Clear();
            _mainWindow.panelSiteView.Controls.Add(new ReservationPage(this));
        }

        public void SwitchToServicePage()
        {
            _mainWindow.panelSiteView.Controls.Clear();
            _mainWindow.panelSiteView.Controls.Add(new ServicesOverview(this));
        }

        public void SwitchToSettingsPage()
        {
            _mainWindow.panelSiteView.Controls.Clear();
            _mainWindow.panelSiteView.Controls.Add(new SettingsPage(this));
        }
        #endregion //DONE
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
        public void LogIn(string username, string password)
        {
            _currentUser = _logInHandler.ValidateLogin(username, password);
            if (_currentUser != null)
            {
                _mainWindow.panelForLogIn.Visible = false;
                SwitchToHomePage();
            }
            else
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
