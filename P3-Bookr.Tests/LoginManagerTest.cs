using System;
using System.Collections.Generic;
using P3_Bookr.Models;
using P3_Bookr.FunctionComponent;
using Xunit;


namespace P3_Bookr.Tests
{
    public class LoginManagerTest
    {
 
        [Fact]
        public void  ValidateLogin_CorrectUsernameAndPasswordShouldReturnAMember()
        {
            
            int i = 0;
            Customer c = new Customer(true, DateTime.Now, "Test", "Mintestvej 19", "test@gmail.com");

            for (i = 0; i < 2; i++)
            {
                c.Members.Add(new Member(c, $"testPerson{i}", $"testTest{i}", $"TestvejLejer 3{i}, 9000 Aalborg")
                {
                    IsActive = true,
                    Email = $"test{i}@gmail.com",
                    RentalNumber = $"00000{i}",
                    MemberNumber = $"00000000{i}",
                    MemberType = Member.MemberTypes.Administrator,
                    Username = $"test{i}",
                    Password = $"test{i}"
                });
            }

            c.Departments.Add(new Department(c, "testAfdeling") { Adress = "afdelingvej 19, 9000 aalborg", Description = "Dette er en test afdeling!", IsActive = true });
            c.Departments.Add(new Department(c, "testAfdeling2") { Adress = "afdelingvej 20", Description = "Dette er en test afdeling2!", IsActive = true });

            c.Members[0].Departments = c.Departments;
            c.Members[1].Departments.Add(c.Departments[1]);


            i = 0;
            foreach (Department d in c.Departments)
            {
                for (int k = 0; k < 3; k++)
                {
                    d.Services.Add(new Service($"Min service {i} , {k}", Commons.Enums.ServiceTypes.WashingMachine) { Description = "Dette er en test", Location = "Vingevej 19" });
                    d.Services.Add(new Service($"Min service {i} , {k}", Commons.Enums.ServiceTypes.CommonRoom) { Description = "Dette er en test", Location = "Vingevej 19" });
                    d.Services[0].ServiceOfferings.Add(new ServiceOffering($"Offering{i}", 120, 30 + k * 2, d.Services[0]));
                    i++;
                }
            }

            c.Members[0].Reservations.Add(
                new Reservation(
                DateTime.Now,
                c.Members[0],
                new TimePeriod(
                DateTime.Now.AddDays(2),
                DateTime.Now.AddDays(3),
                c.Departments[0].Services[0]),
                c.Departments[0].Services[0].ServiceOfferings[0],
                new Payment(DateTime.Now, c.Departments[0].Services[0].ServiceOfferings[0].Price))
                { ReservationDeadline = DateTime.Now.AddDays(1) });

            List<Customer> customers = new List<Customer>();
            customers.Add(c);

            ModelComponent modelComponent = new ModelComponent();
            modelComponent.customer = c;
            LoginManager lgnmngr = new LoginManager(modelComponent);

            //Arrange
            IMember expected = c.Members[0];

            //Act
            IMember actual = lgnmngr.ValidateLogin(c.Members[0].Username, c.Members[0].Password);

            //Assert

            Assert.Equal(expected, actual);
        }
    }
}