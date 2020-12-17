using System;
using Xunit;
using P3_Bookr.Models;
using P3_Bookr.FunctionComponent;

namespace P3_Bookr.Tests
{
    public class PayUnitTest
    {
        [Fact]
        public void Pay_ShouldReturnTrue()
        {
            ModelComponent modelComponent = new ModelComponent(null);
            PaymentManager paymentManager = new PaymentManager(modelComponent);
            Payment payment = new Payment(DateTime.Now, 40);

            Assert.True(paymentManager.Pay(payment));
        }
    }
}
