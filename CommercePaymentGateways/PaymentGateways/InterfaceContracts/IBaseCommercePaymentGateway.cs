using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercePaymentGateways
{
    public interface IBaseCommercePaymentGateway
    {      
        Transaction ProcessTransactionForSave(Transaction transaction);
    }

    public enum ProcessorType
    {
        Hosted,
        Direct
    }

    public enum Vendor
    {
        Stripe,
        Paypal,
        MonerisCA
    }
}
