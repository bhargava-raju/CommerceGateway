using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercePaymentGateways.PaymentGateways
{
    public class PaypalDirectPaymentGateway : CommerceDirectPaymentGateway
    {
        public PaypalDirectPaymentGateway()
        {
            PaymentProcessorName = Vendor.Paypal.ToString();
        }
    }
}
