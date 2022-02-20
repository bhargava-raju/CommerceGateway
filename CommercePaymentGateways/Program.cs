using CommercePaymentGateways.PaymentGateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercePaymentGateways
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Report report = new Report { AmountDonated = 100, Id = 1, ProcesssorName = Vendor.Stripe, ProcessorType = ProcessorType.Direct.ToString() };
            Transaction transaction = new Transaction { DonationAmount = 100, ProcessorType = ProcessorType.Direct, TransactionResults = true };

            StripeDirectPaymentGateway stripeDirectPayment = new StripeDirectPaymentGateway();
            IBaseCommercePaymentGateway baseCommercePayment = new StripeDirectPaymentGateway();
            CommerceDirectPaymentGateway legacycommercePayment = new StripeDirectPaymentGateway();
            CommerceDirectPaymentGateway commercePayment = new CommerceDirectPaymentGateway();
            IBaseCommercePaymentGateway stripeCommercePayment =  new CommerceDirectPaymentGateway();            

            stripeDirectPayment.ProcessTransaction(2);
            stripeDirectPayment.ProcessTransaction(transaction);
            stripeDirectPayment.PrintCommerceReport(stripeDirectPayment.GenerateCommerceReport(ProcessorType.Hosted));

            //stripeDirectPayment.ProcessTransactionForSave(100);            
            //baseCommercePayment.ProcessTransactionForSave(100);
            //legacycommercePayment.ProcessTransactionForSave(100);
            //commercePayment.ProcessTransactionForSave(100);
            //stripeCommercePayment.ProcessTransactionForSave(100);            

            Console.ReadKey();
        }
    }
}
