using StrategyApp.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp
{
    class Checkout
    {
        private readonly IPaymentMethod _paymentMethod;

        public Checkout(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void processPayment(double price)
        {
            _paymentMethod.processPayment(price);
        }
    }
}
