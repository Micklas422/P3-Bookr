using System;
using Xunit;
using P3_Bookr.Models;
using P3_Bookr.FunctionComponent;

namespace P3_Bookr.Tests
{
    public class ValidateServiceAccesUnitTest
    {
        [Fact]
        public void ValidateSerceAccesUnitTest_ShouldReturnTrue()
        {
            Customer c = new Customer(true, DateTime.Now, "Test", "Mintestvej 19", "test@gmail.com");
            Member memberTest = new Member(c, "Jane", "Janesen", "Janevej 12");
            Service serviceTest = new Service("Vaskemaskine", Commons.Enums.ServiceTypes.WashingMachine);

            PermissionManager permissionManager = new PermissionManager(null);

            Assert.True(permissionManager.ValidateServiceAcces(memberTest, serviceTest));
        }
    }
}
