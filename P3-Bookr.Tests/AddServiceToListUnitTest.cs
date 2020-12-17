using System;
using System.Collections.Generic;
using P3_Bookr.Models;
using P3_Bookr.FunctionComponent;
using Xunit;

namespace P3_Bookr.Tests
{
    public class AddServiceToListUnitTest
    {
        [Fact]
        public void AddServiceToList_ShouldReturnTrue()
        {
            Customer c = new Customer(true, DateTime.Now, "Test", "Mintestvej 19", "test@gmail.com");
            c.Departments.Add(new Department(c, "testAfdeling") { Adress = "afdelingvej 19, 9000 aalborg", Description = "Dette er en test afdeling!", IsActive = true });

            PermissionManager permissionManager = new PermissionManager(null);
            ModelComponent modelComponent = new ModelComponent();
            modelComponent.customer = c;
            ServiceManager serviceManager = new ServiceManager(modelComponent, permissionManager);
            Service serviceTest = new Service("Vaskemaskine", Commons.Enums.ServiceTypes.WashingMachine);

            Assert.True(serviceManager.AddServiceToServiceList(serviceTest, c.Departments[0]));
        }
    }
}
