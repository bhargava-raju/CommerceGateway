using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommercePaymentGateways;

namespace CommercePaymentGateways.PaymentGateways
{
    public class CommerceDirectPaymentGateway : IBaseCommercePaymentGateway
    {
        public string PaymentProcessorName { get; set; }
        public decimal MinimumDonationAmount { get; set; }
        public CommerceDirectPaymentGateway()
        {
            PaymentProcessorName = String.Empty;
            MinimumDonationAmount = 0;
        }

        public Transaction ProcessTransaction(decimal amount)
        {
            Transaction transaction = new Transaction
            {
                DonationAmount = 10,
                ProcessorType = ProcessorType.Direct,
                TransactionResults = false
            };

            return transaction;
        }

        public Report GenerateCommerceReport(ProcessorType processorType)
        {
            return new Report();
        }

        public void PrintCommerceReport(Report report)
        {
            Console.WriteLine("Printing by CommercePaymentProcessor");
        }

        public virtual Transaction ProcessTransactionForSave(Transaction transaction)
        {            
            Console.WriteLine("Transaction Processed by CommercePaymentProcessor");
            transaction.ProcessorType = ProcessorType.Direct;
            //transaction.ProcessorName = Vendor.Stripe;
            transaction.TransactionResults = true;
            return transaction;
        }
    }
}
