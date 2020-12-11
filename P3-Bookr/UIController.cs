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
using P3_Bookr.Commons.Enums;
using P3_Bookr.Windows.Services;

namespace P3_Bookr
{
    public class UIController : ISideMenuUI, IServicesUI, IReservationUI, IHistorikUI, ILogInUI, IHomepageUI, IAdminToolsUI, ISettingsUI
    {
        MainWindow _mainWindow;
        ServicesOverview _servicesOverview;
        ReservationPage _reservationPage;
        //ILoginManager _logInHandler;
        Member _currentUser;
        List<Service> _activeServices;
        List<Reservation> _activeMemberReservations;
        IFunctionComponentInterface _functionComponent;
        public UIController(IFunctionComponentInterface functionComponenten)
        {
            _functionComponent = functionComponenten;
            _mainWindow = new MainWindow();
            //_serviceDetails = new ServiceDetails(this);
            //_serviceInfoPanel = new ServiceInfoPanel(this);
            _mainWindow.panelSideBar.Controls.Clear();
            _mainWindow.panelSideBar.Controls.Add(new SideBar(this));
            SwitchToLogInPage();
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
            FrontPageForm form = new FrontPageForm(this);
            List<Service> services = _functionComponent.serviceManager.FindLastServicesUsed(_currentUser, 5);
            foreach(Service s in services)
            {
                form.lastUsedServices1.flowLayoutPanelLastUsed.Controls.Add(new ServiceViewForFlow(s, this));
            }

            
            _mainWindow.panelSiteView.Controls.Add(form);
        }

        public void SwitchToLogInPage()
        {
            _mainWindow.panelSiteView.Controls.Clear();
            _mainWindow.panelForLogIn.Visible = true;
            _mainWindow.panelForLogIn.Controls.Add(new Login(this));
        }

        public void SwitchToReservationPage()
        {
            _reservationPage = new ReservationPage(this);
            _mainWindow.panelSiteView.Controls.Clear();
            _mainWindow.panelSiteView.Controls.Add(_reservationPage);
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
            _activeServices = _functionComponent.serviceManager.GetActiveServices();
            var enumValue = Enum.GetValues(typeof(ServiceTypes));
            var enumNames = Enum.GetNames(typeof(ServiceTypes));

            List<List<Service>> sortedByServiceTypes = new List<List<Service>>();

            foreach (int i in enumValue)
            {
                List<Service> v = _activeServices.Where(s => s.ServiceType == (ServiceTypes) i).ToList();
                if (v.Count > 0) 
                {
                    sortedByServiceTypes.Add(v);
                }
            }
            foreach (List<Service> services in sortedByServiceTypes)
            {
                _servicesOverview.FlowPanelOfFlow.Controls.Add(new ServicesTop(services.ElementAt(0)));
                _servicesOverview.FlowPanelOfFlow.Controls.Add(new FlowLayoutPanel());
                foreach (Service service in services)
                {
                    _servicesOverview.flowLayoutPanel1.Controls.Add(new ServiceViewForFlow(service, this));
                }
            }
        }
        public void ChooseServices()
        {
            throw new NotImplementedException();
        }

        public void SelectService()
        {
            throw new NotImplementedException();
        }

        public void SelectServiceType(ServiceSubOptions price, Service service)
        {
            //service.ServiceOfferings.
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
        public void SwitchToService(Service service)
        {
            _mainWindow.panelSiteView.Controls.Clear();
            _mainWindow.panelSiteView.Controls.Add(new ServiceDetails(new ServiceInfoPanel(this, service), new ServiceBook(this, service.ServiceOfferings)));
        }
        public void LoadInfoPanelForService(IService service)
        {
            //_serviceInfoPanel.ServiceAdressInfo1.Text = service.Name;
            //_serviceInfoPanel.ServiceDescriptionInfo1.Text = service.Name;
        }
        public void LoadandExecutePanelForServiceBooking()
        {
            throw new NotImplementedException();
            Service service;

        }
        #endregion
        #region ResevationUI
        public void LoadReservations()
        {
            throw new NotImplementedException();
        }
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

        public void SelectServiceType()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
