using System;
using Xunit;
using P3_Bookr.Models;
using P3_Bookr.FunctionComponent;

namespace P3_Bookr.Tests
{
    public class LoginManagerTest
    {

        
        [Fact]
        public void ValidateLogin_CorrectUsernameAndPasswordShouldReturnUser()
        {
            
            ModelComponent modelComponent = new ModelComponent(null);
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

            LoginManager lgnmngr = new LoginManager(modelComponent);

            
            memberTest = modelComponent.GetMemberByUsername(memberTest.Username);

            //Arrange
            Member expected = memberTest;

            //Act
            Member actual = lgnmngr.ValidateLogin("test123", "test");

            //Assert

            Assert.Equal(expected, actual);
        }
    }
}
