using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //First Concrete Factory Creator.
    public class CreditCardPaymentProcessorFactory : IPaymentProcessorFactory
    {
        public IPaymentProcessor CreatePaymentProcessor()
        {
            return new CreditCardPaymentProcessor();
        }
    }
}
