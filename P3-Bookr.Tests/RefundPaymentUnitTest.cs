using System;
using Xunit;
using P3_Bookr.Models;
using P3_Bookr.FunctionComponent;

namespace P3_Bookr.Tests
{
    public class RefundPaymentUnitTest
    {

        [Fact]
        public void RefundPayment_ShouldReturnTrue()
        {
            ModelComponent modelComponent = new ModelComponent();
            PaymentManager paymentManager = new PaymentManager(modelComponent);
            Payment payment = new Payment(DateTime.Now, 40);

            Assert.True(paymentManager.RefundPayment(payment));
        }
    }
}
