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
using P3_Bookr.Windows.Reservation;
using P3_Bookr.Windows.Settings;
using P3_Bookr.FunctionComponent;
using P3_Bookr.Models;
using P3_Bookr.Commons.Enums;
using P3_Bookr.Windows.Services;

namespace P3_Bookr
{
    class UIController : ISideMenuUI, IServicesUI, IReservationUI, IHistorikUI, ILogInUI, IHomepageUI, IAdminToolsUI, ISettingsUI
    {
        bool stayAlive = false;
        MainWindow _mainWindow;
        ServicesOverview _servicesOverview;
        List<ServiceGathering> _serviceGatherings;
        //ILoginManager _logInHandler;
        Member _currentUser;
        List<Service> _activeServices;
        IFunctionComponentInterface _functionComponent;
        public UIController(IFunctionComponentInterface functionComponenten)
        {
            _functionComponent = functionComponenten;
            _mainWindow = new MainWindow();
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
            _servicesOverview = new ServicesOverview(this);
            _mainWindow.panelSiteView.Controls.Clear();
            _mainWindow.panelSiteView.Controls.Add(_servicesOverview);
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
                _servicesOverview.FlowPanelOfFlow.Controls.Add(new FlowLayoutPanel());
                foreach (Service service in services)
                {
                    _servicesOverview.flowLayoutPanel1.Controls.Add(new ServiceViewForFlow(service));
                }
            }

            //for (int i = 0; i < enumNames.Length; i++)
            //{
            //    foreach (Service service in _activeServices)
            //    {
            //        if (Enum.GetName(typeof(ServiceTypes), service.ServiceType) == enumNames[i])
            //        {
            //            _serviceGatherings.Add(new ServiceGathering());
            //            _servicesOverview.ServiceOverviewFlow1.Controls.Add(new ServiceGathering());
            //            //indsæt navn på gatherings
            //            break;
            //        }
            //    }
            //}
            //for (int i = 0; i < enumNames.Length; i++)
            //{
            //    foreach (Service service in _activeServices)
            //    {
            //        if (Enum.GetName(typeof(ServiceTypes), service.ServiceType) == enumNames[i])
            //        {

            //        }
            //    }
            //}
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
            _currentUser = _functionComponent.loginManager.ValidateLogin(username, password);
            try
            {
                if (_currentUser != null)
                {
                    _mainWindow.panelForLogIn.Visible = false;
                    SwitchToHomePage();
                }
            }
            catch(ArgumentNullException)
            {
                return;
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
        #endregion
    }
}
