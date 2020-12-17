using System;
using Xunit;
using P3_Bookr.Models;
using P3_Bookr.FunctionComponent;


namespace P3_Bookr.Tests
{
    public class ValidateAdminUnitTest
    {
        [Fact]
        public void ValidateAdminPermission_ShouldReturnTrue()
        {
            Customer c = new Customer(true, DateTime.Now, "Test", "Mintestvej 19", "test@gmail.com");
            Member memberTest = new Member(c, "Jane", "Janesen", "Janevej 12")
            {
                IsActive = true,
                Email = $"test@gmail.com",
                RentalNumber = $"00000",
                MemberNumber = $"00000000",
                MemberType = Member.MemberTypes.Administrator,
                Username = $"test123",
                Password = $"test"
            };

            PermissionManager permissionManager = new PermissionManager(null);

            Assert.True(permissionManager.ValidateAdminPermission(memberTest));
        }
        [Fact]
        public void ValidateAdminPermission_ShouldReturnFalse()
        {
            Customer c = new Customer(true, DateTime.Now, "Test", "Mintestvej 19", "test@gmail.com");
            Member memberTest = new Member(c, "Jane", "Janesen", "Janevej 12")
            {
                IsActive = true,
                Email = $"test@gmail.com",
                RentalNumber = $"00000",
                MemberNumber = $"00000000",
                MemberType = Member.MemberTypes.Renter,
                Username = $"test123",
                Password = $"test"
            };

            PermissionManager permissionManager = new PermissionManager(null);

            Assert.False(permissionManager.ValidateAdminPermission(memberTest));
        }
    }
}
