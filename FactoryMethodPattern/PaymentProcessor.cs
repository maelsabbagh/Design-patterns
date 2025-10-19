using FactoryMethodPattern.PaymentMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class PaymentProcessor
    {
        private readonly IPaymentFactory _paymentFactory;

        public PaymentProcessor(IPaymentFactory paymentFactory)
        {
            _paymentFactory = paymentFactory;
        }
        public void processPayment(CardTypes cardType, string cardNumber, string cvv, string expiryDate, string cardHolder,double amount)
        {
            PaymentMethod paymentMethod =_paymentFactory.getPaymentMethod(cardType, cardNumber, cvv, expiryDate, cardHolder);
            paymentMethod.authorize();
            paymentMethod.startMoneyTransfer();
            paymentMethod.calculatePaymentFees(amount);
        }



    }
}
