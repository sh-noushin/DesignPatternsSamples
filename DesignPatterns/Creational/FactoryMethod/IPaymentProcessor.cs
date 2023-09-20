using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //This interface describes our product that should be implemented by Concrete Products.
    public interface IPaymentProcessor
    {
        void ProcessPayment(double amount);
    }
}
