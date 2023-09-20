using FactoryMethod;
//Implementation with direct varaibles.
IPaymentProcessorFactory creditCardFactory = new CreditCardPaymentProcessorFactory();
IPaymentProcessor creditCardProcessor = creditCardFactory.CreatePaymentProcessor();
creditCardProcessor.ProcessPayment(100.00);

IPaymentProcessorFactory paypalFactory = new PayPalPaymentProcessorFactory();
IPaymentProcessor paypalProcessor = paypalFactory.CreatePaymentProcessor();
paypalProcessor.ProcessPayment(50.00);

//Implementation via a consumer method.
var creditCard = PaymentUserMethod(new CreditCardPaymentProcessorFactory());
creditCard.ProcessPayment(200.00);

var Paypal = PaymentUserMethod(new PayPalPaymentProcessorFactory());
Paypal.ProcessPayment(300.00);


IPaymentProcessor PaymentUserMethod(IPaymentProcessorFactory factory)
{
    return factory.CreatePaymentProcessor();
}