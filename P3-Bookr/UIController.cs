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
using P3_Bookr.Commons.CustomExceptions;

namespace P3_Bookr
{
    public class UIController : ISideMenuUI, IServicesUI, IReservationUI, IHistorikUI, ILogInUI, IHomepageUI, IAdminToolsUI, ISettingsUI
    {
        bool stayAlive = false;
        MainWindow _mainWindow;
        ServiceDetails _serviceDetails;
        ServiceInfoPanel _serviceInfoPanel;
        //ILoginManager _logInHandler;
        Member _currentUser;
        IFunctionComponentInterface _functionComponent;
        public UIController(IFunctionComponentInterface functionComponenten)
        {
            _functionComponent = functionComponenten;
            _mainWindow = new MainWindow();
            _serviceDetails = new ServiceDetails(this);
            _serviceInfoPanel = new ServiceInfoPanel(this);
            _mainWindow.panelSideBar.Controls.Clear();
            _mainWindow.panelSideBar.Controls.Add(new SideBar(this));
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

        public void SelectServiceType(ServiceOptionFlowOption price, Service service)
        {
            service.ServiceOfferings.
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
        public void SwitchToService()
        {
            _mainWindow.panelSiteView.Controls.Add(new ServiceDetails(this));


            _serviceDetails.ServiceDetailsInfoPanel1.Controls.Add(new ServiceInfoPanel(this));
            _serviceDetails.ServiceDetailsOptionPanel1.Controls.Add();
            
        }
        public void LoadInfoPanelForService(IService service)
        {
            _serviceInfoPanel.ServiceAdressInfo1 = service;
            _serviceInfoPanel.ServiceDescriptionInfo1 = service;
        }
        public void LoadandExecutePanelForServiceBooking()
        {
            throw new NotImplementedException();
            Service service;

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
            try
            {
                _currentUser = _functionComponent.loginManager.ValidateLogin(username, password);
                if (_currentUser != null)
                {
                    _mainWindow.panelForLogIn.Visible = false;
                    _mainWindow.panelForLogIn.Controls.Clear();
                    SwitchToHomePage();
                }
            }
            catch(Exception ex)
            {
                if (ex is UserNotFoundException || ex is BadPasswordException)
                    MessageBox.Show("User or Password was wrong");
                else
                    MessageBox.Show("Fejl 40 fundet");
                _mainWindow.panelForLogIn.Controls.Clear();
                _mainWindow.panelForLogIn.Controls.Add(new Login(this));
            }
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

        public void LoadInfoPanelForService()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
