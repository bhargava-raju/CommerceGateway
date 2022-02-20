using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercePaymentGateways
{
    public class Transaction
    {
        public int DonationAmount { get; set; }
        public ProcessorType ProcessorType { get; set; }
        public Vendor? ProcessorName { get; set; } = null;
        public bool TransactionResults { get; set; } = false;

    }
}
