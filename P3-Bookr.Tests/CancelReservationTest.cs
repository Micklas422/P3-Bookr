using System;
using Xunit;
using P3_Bookr.Models;
using P3_Bookr.FunctionComponent;

namespace P3_Bookr.Tests
{
    public class CancelReservationTest
    {

        [Fact]
        public void CancelReservation_ShouldReturnTrue()
        {
            Customer c = new Customer(true, DateTime.Now, "Test", "Mintestvej 19", "test@gmail.com");

            ModelComponent modelComponent = new ModelComponent();
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
            { ReservationDeadline = DateTime.Now.AddDays(1) };;

            Assert.True(rsrvtnmngrTest.CancelReservation(testReservation));
        }
    
        [Fact]
        public void CancelReservation_ChecksForCorrectValuesName()
        {
            Customer c = new Customer(true, DateTime.Now, "Test", "Mintestvej 19", "test@gmail.com");

            ModelComponent modelComponent = new ModelComponent();
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
            
            Assert.Equal(90, testReservation.Duration); // Fails 
        }

        [Fact]
        public void CancelReservation_ChecksForCorrectValuesDuration()
        {
            Customer c = new Customer(true, DateTime.Now, "Test", "Mintestvej 19", "test@gmail.com");

            ModelComponent modelComponent = new ModelComponent();
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

            Assert.Equal(90, testReservation.Duration);
            Assert.Equal(paymentTest, testReservation.Payment);
        }
        [Fact]
        public void CancelReservation_ChecksForCorrectValuesPayment()
        {
            Customer c = new Customer(true, DateTime.Now, "Test", "Mintestvej 19", "test@gmail.com");

            ModelComponent modelComponent = new ModelComponent();
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

            Assert.Equal(paymentTest, testReservation.Payment);
        }
    }
}