﻿using System;
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

namespace P3_Bookr
{
    public class UIController : ISideMenuUI, IServicesUI, IReservationUI, IHistorikUI, ILogInUI, IHomepageUI, IAdminToolsUI, ISettingsUI
    {
        MainWindow _mainWindow;
        Member _currentUser;
        IFunctionComponentInterface _functionComponent;
        public UIController(IFunctionComponentInterface functionComponenten)
        {
            _functionComponent = functionComponenten;
            _mainWindow = new MainWindow();
            //_mainWindow.panelSideBar.Controls.Clear();
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
            _mainWindow.HideAllControls();
            _mainWindow.panelSiteView.Controls.Clear();
            FrontPageForm form = new FrontPageForm(this);
            List<Service> services = LastUsedService(5);
            foreach(Service s in services)
            {
                form.lastUsedServices1.flowLayoutPanelLastUsed.Controls.Add(new ServiceViewForFlow(s, this));
            }
            _mainWindow.panelSiteView.Controls.Add(form);

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
            _mainWindow.panelSiteView.Controls.Add(new SettingsPage(this));
        }
        #endregion //DONE
        #region ServicesUI
        public ServicesOverview LoadServicesToShow()
        {
            ServicesOverview servicesOverview = new ServicesOverview(this);
            List<Service> activeServices = new List<Service>();
            activeServices = _functionComponent.serviceManager.GetActiveServicesByMember(_currentUser);
            var enumValue = Enum.GetValues(typeof(ServiceTypes));
            var enumNames = Enum.GetNames(typeof(ServiceTypes));

            List<List<Service>> sortedByServiceTypes = new List<List<Service>>();

            foreach (int i in enumValue)
            {
                List<Service> v = activeServices.Where(s => s.ServiceType == (ServiceTypes) i).ToList();
                if (v.Count > 0) 
                {
                    sortedByServiceTypes.Add(v);
                }
            }

            foreach (List<Service> services in sortedByServiceTypes)
            {
                servicesOverview.FlowPanelOfFlow.Controls.Add(new FlowLayoutPanel());
                foreach (Service service in services)
                {
                    servicesOverview.flowLayoutPanel1.Controls.Add(new ServiceViewForFlow(service, this));
                }
                servicesOverview.FlowPanelOfFlow.Controls.Add(new ServicesTop(services.ElementAt(0)));
            }
            return servicesOverview;
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
            _mainWindow.panelSiteView.Controls.Add(new ServiceDetails(new ServiceInfoPanel(this, service), new ServiceBook(this,this, service)));
        }
        public void LoadInfoPanelForService(IService service)
        {
            //_serviceInfoPanel.ServiceAdressInfo1.Text = service.Name;
            //_serviceInfoPanel.ServiceDescriptionInfo1.Text = service.Name;
        }
        public void LoadandExecutePanelForServiceBooking()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region ResevationUI
        public ReservationPage LoadReservationsOfMember()
        {
            ReservationPage reservationPage = new ReservationPage(this);
            List<Reservation> activeMemberReservations = new List<Reservation>();
            activeMemberReservations = _functionComponent.reservationManager.GetActiveReservationsByMember(_currentUser);

            foreach (Reservation reservation in activeMemberReservations)
            {
                reservationPage.flowLayoutPanel1.Controls.Add(new ReservationPanel(reservation, this));
            }
            return reservationPage;
        }
        public void CancelReservation(Reservation reservation)
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
        public List<Service> LastUsedService(int count)
        {
            return _functionComponent.historyManager.GetLastUsedServices(_currentUser, count);
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

        public Service AddService(Service service)
        {
            //Service service = new Service();
            //service.Location = location;
            //service.Description = description;
            //service.Name = name;
            //service.ServiceType = serviceType;
            //service.TimePeriods = timePeriod;
            //service.ServiceOfferings = serviceOfferings;
            //service.DepartmentDeactivatet = false;

            return service;
        }
        public void CreateServiceOffering()
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
        public void LoadInfoPanelForService()
        {
            throw new NotImplementedException();
        }

        public void SelectServiceType()
        {
            throw new NotImplementedException();
        }

        public bool CreateNewReservation(Service service, ServiceOffering serviceOffering, DateTime dateTime)
        {
            return _functionComponent.reservationManager.CreateReservation(_currentUser, service, serviceOffering, dateTime);
        }

        public void CancelReservation()
        {
            throw new NotImplementedException();
        }
        
    }
}
