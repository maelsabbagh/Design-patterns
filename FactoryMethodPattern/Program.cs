using FactoryMethodPattern;
using FactoryMethodPattern.PaymentMethods;


IPaymentFactory paymentFactory = new PaymentFactory();
PaymentProcessor paymentProcessor = new PaymentProcessor(paymentFactory);

paymentProcessor.processPayment(CardTypes.VISA, "123", "123", "02-05-2026", "Mohamed",500);



