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
using P3_Bookr.Windows.ReservationPanels;
using P3_Bookr.Windows.Settings;
using P3_Bookr.FunctionComponent;
using P3_Bookr.Models;
using P3_Bookr.Commons.CustomExceptions;
using P3_Bookr.Commons.Enums;
using P3_Bookr.Windows.CreateNewService;
using P3_Bookr.Windows.AdminTools;

namespace P3_Bookr
{
    public class UIController : ISideMenuUI, IServicesUI, IReservationUI, IHistorikUI, ILogInUI, IHomepageUI, IAdminToolsUI, ISettingsUI
    {
        MainWindow _mainWindow;
        IMember _currentUser;
        IFunctionComponentInterface _functionComponent;
        public UIController(IFunctionComponentInterface functionComponenten)
        {
            _functionComponent = functionComponenten;
            _mainWindow = new MainWindow();
            _mainWindow.panelSideBar.Controls.Add(new SideBar(this, false));
            SwitchToLogInPage();
            Application.Run(_mainWindow);
        }

        #region SideMenuHandler
        public void SwitchToHistoryPage()
        {
            _mainWindow.panelSiteView.Controls.Clear();
            _mainWindow.panelSiteView.Controls.Add(LoadHistoryPage());
        }

        public void SwitchToHomePage()
        {
            _mainWindow.HideAllControls();
            _mainWindow.panelSiteView.Controls.Clear();
            FrontPageForm form = new FrontPageForm(this);
            List<IService> services = LastUsedService(5);
            foreach(IService s in services)
            {
                form.lastUsedServices1.flowLayoutPanelLastUsed.Controls.Add(new ServiceViewForFlow(s, this));
            }
            _mainWindow.panelSiteView.Controls.Add(form);

            if (_functionComponent.permissionManager.ValidateAdminPermission(_currentUser))
            {
                _mainWindow.panelSideBar.Controls.Clear();
                _mainWindow.panelSideBar.Controls.Add(new SideBar(this, true));
            } 
            else
            {
                _mainWindow.panelSideBar.Controls.Clear();
                _mainWindow.panelSideBar.Controls.Add(new SideBar(this, false));
            }

            _mainWindow.labelUserLoggedIn.Text = _currentUser.Username;
            _mainWindow.panelSideBar.Show();
            _mainWindow.panelSiteView.Show();
            _mainWindow.pictureBoxBookr.Show();
            _mainWindow.labelUserLoggedIn.Show();
            _mainWindow.labelLoggedIn.Show();
            
        }

        public void SwitchToLogInPage()
        {
            _mainWindow.HideAllControls();
            _mainWindow.panelSiteView.Controls.Clear();
            //_mainWindow.panelForLogIn.Visible = true;
            _mainWindow.panelForLogIn.Controls.Add(new Login(this));
            _mainWindow.panelForLogIn.Show();
            //_mainWindow.panelForLogIn.BringToFront();
        }

        public void SwitchToReservationPage()
        {
            _mainWindow.panelSiteView.Controls.Clear();
            _mainWindow.panelSiteView.Controls.Add(LoadReservationsOfMember());
        }

        public void SwitchToServicePage()
        {
            _mainWindow.panelSiteView.Controls.Clear();
            _mainWindow.panelSiteView.Controls.Add(LoadServicesToShow());
        }

        public void SwitchToSettingsPage()
        {
            _mainWindow.panelSiteView.Controls.Clear();
            _mainWindow.panelSiteView.Controls.Add(LoadSettings());
        }
        public void SwitchToAdminToolsPage()
        {
            _mainWindow.panelSiteView.Controls.Clear();
            _mainWindow.panelSiteView.Controls.Add(new AdminPage(this, deparmentListFromMember(_currentUser)));
        }
        public void SwitchToNewService()
        {
            _mainWindow.panelSiteView.Controls.Clear();
            _mainWindow.panelSiteView.Controls.Add(new NewService(this, deparmentListFromMember(_currentUser)));
        }
        #endregion //DONE
        #region ServicesUI
        public ServicesOverview LoadServicesToShow()
        {
            ServicesOverview servicesOverview = new ServicesOverview(this);
            List<IService> activeServices = new List<IService>();
            activeServices = _functionComponent.serviceManager.GetActiveServicesByMember(_currentUser);
            var enumValue = Enum.GetValues(typeof(ServiceTypes));
            var enumNames = Enum.GetNames(typeof(ServiceTypes));

            List<List<IService>> sortedByServiceTypes = new List<List<IService>>();

            foreach (int i in enumValue)
            {
                List<IService> v = activeServices.Where(s => s.ServiceType == (ServiceTypes) i).ToList();
                if (v.Count > 0) 
                {
                    sortedByServiceTypes.Add(v);
                }
            }

            foreach (List<IService> services in sortedByServiceTypes)
            {
                servicesOverview.FlowPanelOfFlow.Controls.Add(new ServicesTop(services.ElementAt(0)));
                foreach (IService service in services)
                {
                    servicesOverview.FlowPanelOfFlow.Controls.Add(new ServiceViewForFlow(service, this));
                }
            }
            return servicesOverview;
        }
        public void SwitchToService(IService service)
        {
            _mainWindow.panelSiteView.Controls.Clear();
            _mainWindow.panelSiteView.Controls.Add(new ServiceDetails(new ServiceInfoPanel(this, service), new ServiceBook(this,this, service), service));
        }
        #endregion
        #region ResevationUI
        public ReservationPage LoadReservationsOfMember()
        {
            ReservationPage reservationPage = new ReservationPage(this);
            List<IReservation> activeMemberReservations = new List<IReservation>();
            activeMemberReservations = _functionComponent.reservationManager.GetActiveReservationsByMember(_currentUser);

            foreach (IReservation reservation in activeMemberReservations)
            {
                reservationPage.flowLayoutPanel1.Controls.Add(new ReservationPanel(reservation, this));
            }
            return reservationPage;
        }
        public void CancelReservation(IReservation reservation)
        {
            try
            {
                if(_functionComponent.reservationManager.CancelReservation(reservation))
                {
                    MessageBox.Show("Reservation annulleret");
                    SwitchToReservationPage();
                }
                else
                {
                    MessageBox.Show("Reservation kunne ikke annulleres");
                }
            }
            catch(Exception )
            {
                MessageBox.Show("Kunne ikke annullere reservation");
            }
        }
        public bool CreateNewReservation(IService service, IServiceOffering serviceOffering, DateTime dateTime)
        {
            return _functionComponent.reservationManager.CreateReservation(_currentUser, service, serviceOffering, dateTime);
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
        public List<IService> LastUsedService(int count)
        {
            return _functionComponent.historyManager.GetLastUsedServices(_currentUser, count);
        }
        #endregion
        #region AdminToolsUI
        
        public void AddService(IService service, IDepartment department)
        {
            bool Succeded;
            Succeded = _functionComponent.serviceManager.AddServiceToServiceList(service, department);
            if (!Succeded)
            {
                MessageBox.Show("Noget gik galt under oprettelsen af servicen");
            }
            MessageBox.Show("Service oprettet, tryk på annuller for at returnere til hovedmenuen");

        }
        public List<IDepartment> deparmentListFromMember(IMember member)
        {
            List<IDepartment> departmentList = new List<IDepartment>();
            foreach(IDepartment department in member.Departments)
            {
                departmentList.Add(department);
            }

            return departmentList;
        }
        #endregion
        #region HistorikUI

        public HistoryPage LoadHistoryPage()
        {
            HistoryPage historyPage = new HistoryPage(this);
            List<IReservation> reservations = _functionComponent.historyManager.SeeHistory(_currentUser);

            foreach (IReservation r in reservations)
            {
                historyPage.flowLayoutPanel1.Controls.Add(new HistoryElement(r));
            }
            return historyPage;
        }

        #endregion
        #region SettingsUI

        public SettingsPage LoadSettings()
        {
           return new SettingsPage(this, _currentUser);
        }

        #endregion
    }
}
