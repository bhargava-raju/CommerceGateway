using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CommercePaymentGateways;
using CommercePaymentGateways.PaymentGateways;

namespace CommercePaymentGatewaysTest
{
    [TestClass]
    public class GatewayTesting
    {
        //[TestMethod]
        //public void TestInitializeTheGateway()
        //{
        //    CommerceDirectPaymentGateway commercePaymentGatewayTest = new CommerceDirectPaymentGateway();
        //    Transaction transaction = commercePaymentGatewayTest.ProcessTransactionForSave(100);
        //    Assert.IsNotNull(transaction);
        //    Assert.IsNotNull(transaction.TransactionResults);
        //    Assert.AreEqual(commercePaymentGatewayTest.PaymentProcessorName, String.Empty);
        //}

        //[TestMethod]
        //public void TestInitializeStripeGateway()
        //{
        //    StripeDirectPaymentGateway commercePaymentGatewayTest = new StripeDirectPaymentGateway();
        //    Transaction transaction = commercePaymentGatewayTest.ProcessTransactionForSave(100);
        //    Assert.IsNotNull(transaction);
        //    Assert.IsNotNull(transaction.TransactionResults);
        //    Assert.AreEqual(commercePaymentGatewayTest.PaymentProcessorName, Vendor.Stripe.ToString());
        //}

        //[TestMethod]
        //public void TestInitializePaypalGateway()
        //{
        //    PaypalDirectPaymentGateway commercePaymentGatewayTest = new PaypalDirectPaymentGateway();
        //    Transaction transaction = commercePaymentGatewayTest.ProcessTransactionForSave(100);
        //    Assert.IsNotNull(transaction);
        //    Assert.IsNotNull(transaction.TransactionResults);
        //    Assert.AreEqual(commercePaymentGatewayTest.PaymentProcessorName, Vendor.Paypal.ToString());
        //}

        [TestMethod]
        public void TestDonationProcessedByStripeGateway()
        {
            StripeDirectPaymentGateway commercePaymentGatewayTest = new StripeDirectPaymentGateway();
            Transaction transaction = new Transaction { DonationAmount = 10 };
            transaction = commercePaymentGatewayTest.ProcessTransactionForSave(transaction);
            Assert.IsNotNull(transaction);
            Assert.IsTrue(transaction.TransactionResults);
            Assert.AreEqual(transaction.DonationAmount, 10);
            Assert.IsTrue(transaction.ProcessorName == Vendor.Stripe);
            Assert.AreEqual(commercePaymentGatewayTest.PaymentProcessorName, Vendor.Stripe.ToString());
        }

    }
}
