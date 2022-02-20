using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercePaymentGateways.PaymentGateways
{
    public class Report
    {
        public int Id { get; set; }
        public Vendor ProcesssorName { get; set; }
        public string ProcessorType { get; set; }
        public decimal AmountDonated { get; set; }
    }
}
