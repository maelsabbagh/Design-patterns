using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.PaymentMethods
{
    class AmericanExpressPaymentMethod : PaymentMethod
    {
        public AmericanExpressPaymentMethod(string cardNumber, string cvv, string expiryDate, string cardHolder) : base(cardNumber, cvv, expiryDate, cardHolder)
        {

        }
        public override void authorize()
        {
            Console.WriteLine("AmericanExpress Authorization");
        }

        public override void calculatePaymentFees(double amount)
        {
            Console.WriteLine($"calculating payment fees {amount}");
        }


        public override void startMoneyTransfer()
        {
            Console.WriteLine("STARTING MONEY TRANSFER FOR AmericanExpress PAYMENT");
        }
    }
}
