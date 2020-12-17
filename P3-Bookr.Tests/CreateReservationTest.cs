using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P3_Bookr.Windows;
using P3_Bookr.Commons;
using System.IO;
using P3_Bookr.Models;
using P3_Bookr.FunctionComponent;
using Xunit;

namespace P3_Bookr.Tests
{
    public class CreateReservationTest
    {
        [Fact]
        public void CreateReservation_ShouldReturnTrue()
        {
            DateTime time;
            time = DateTime.Now;
            Customer c = new Customer(true, DateTime.Now, "Test", "Mintestvej 19", "test@gmail.com");

            ModelComponent modelComponent = new ModelComponent();
            PaymentManager paymentManagerTest = new PaymentManager(modelComponent);
            ReservationManager rsrvtnmngrTest = new ReservationManager(modelComponent, paymentManagerTest);
            Payment paymentTest = new Payment(DateTime.Now, 50);
            Service serviceTest = new Service("Vaskemaskine", Commons.Enums.ServiceTypes.WashingMachine);
            ServiceOffering serviceOfferingTest = new ServiceOffering("Kulørtvask", 90, 12, serviceTest);
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
            Assert.True(rsrvtnmngrTest.CreateReservation(memberTest, serviceTest, serviceOfferingTest, time));
        }
    }
}
