using System;
using Xunit;
using P3_Bookr.Models;
using P3_Bookr.FunctionComponent;

namespace P3_Bookr.Tests
{
    public class CreateReservationTest
    {
        [Fact]
        public void CreateReservation_ShouldReturnTrue()
        {
            Customer c = new Customer(true, DateTime.Now, "Test", "Mintestvej 19", "test@gmail.com");

            ModelComponent modelComponent = new ModelComponent(null);
            PaymentManager paymentManagerTest = new PaymentManager(modelComponent);
            ReservationManager rsrvtnmngrTest = new ReservationManager(modelComponent, paymentManagerTest);
            Payment paymentTest = new Payment(DateTime.Now, 50);
            Service serviceTest = new Service("Vaskemaskine", Commons.Enums.ServiceTypes.WashingMachine);
            ServiceOffering serviceOfferingTest = new ServiceOffering("Kulørtvask", 90, 12, serviceTest);
            Member memberTest = new Member(c, "Jane", "Janesen", "Janevej 12");

            paymentManagerTest.Cancel(paymentTest);

            Reservation testReservation = new Reservation(
               DateTime.Now,
               memberTest,
               new TimePeriod(
               DateTime.Now.AddDays(2),
               DateTime.Now.AddDays(3),
               serviceTest),
               serviceOfferingTest,
               paymentTest)
            { ReservationDeadline = DateTime.Now.AddDays(1) }; ;

            Assert.True(rsrvtnmngrTest.CreateReservation(memberTest, serviceTest, serviceOfferingTest, DateTime.Now));
        }
    }
}
