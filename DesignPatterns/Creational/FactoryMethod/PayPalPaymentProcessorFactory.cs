using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //Second Concrete  Factory Creator.
    public class PayPalPaymentProcessorFactory : IPaymentProcessorFactory
    {
        public IPaymentProcessor CreatePaymentProcessor()
        {
            return new PayPalPaymentProcessor();
        }
    }
}
