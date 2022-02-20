using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercePaymentGateways.PaymentGateways
{
    public class StripeDirectPaymentGateway : CommerceDirectPaymentGateway
    {
        public StripeDirectPaymentGateway()
        {
            PaymentProcessorName = "Stripe";
            MinimumDonationAmount = 10;
        }

        public new Report GenerateCommerceReport(ProcessorType processorType)
        {
            Report report = new Report
            {
                Id = 1,
                AmountDonated = 100,
                ProcesssorName = Vendor.Stripe
            };
            base.GenerateCommerceReport(processorType);
            return report;
        }

        public new void PrintCommerceReport(Report reportToPrint)
        {
            //Report reportToPrint = GenerateCommerceReport(processorType);
            Console.WriteLine($"Id = {reportToPrint.Id}");
            Console.WriteLine($"Processor Name = {reportToPrint.ProcesssorName}");
            Console.WriteLine($"Amount = {reportToPrint.AmountDonated}");

        }        

        public Transaction ProcessTransaction(Transaction transaction)
        {
            Transaction tempTransaction = new Transaction
            {
                DonationAmount = 10,
                ProcessorType = ProcessorType.Direct,
                TransactionResults = false
            };

            return transaction;
        }

        public override Transaction ProcessTransactionForSave(Transaction transaction)
        {
            Console.WriteLine("Transaction Processed by Stripe PaymentProcessor");
            transaction.ProcessorType = ProcessorType.Direct;
            transaction.ProcessorName = Vendor.Stripe;
            transaction.TransactionResults = true;
            return transaction;
        }
    }
}
