using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using P3_Bookr.Models;
using P3_Bookr.Commons.CustomExceptions;
using P3_Bookr.FunctionComponent;
using P3_Bookr;
using P3_Bookr.Commons.Enums;

namespace P3_Bookr.Tests
{
    public class CancelReservationTest
    {

        [Fact]
        public void CancelReservation_ShouldReturnTrue()
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

            Assert.True(rsrvtnmngrTest.CancelReservation(testReservation));
        }
    


        [Fact]
        public void CancelReservation_ChecksForCorrectValuesIn()
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
            { ReservationDeadline = DateTime.Now.AddDays(1) };
            
            Assert.Equal("Janesen", testReservation.Member.LastName);
            Assert.Equal(90, testReservation.Duration); // Fails 
            Assert.Equal(paymentTest, testReservation.Payment);
        }
    }
}