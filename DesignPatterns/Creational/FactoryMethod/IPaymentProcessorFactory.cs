using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //Factory creator interface.
    public interface IPaymentProcessorFactory
    {
        IPaymentProcessor CreatePaymentProcessor();
    }
}
