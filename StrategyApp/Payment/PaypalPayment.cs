using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp.Payment
{
    class PaypalPayment:IPaymentMethod
    {
        public void processPayment(double price)
        {
            Console.WriteLine($"Processing payment {price}$ with Paypal");
            Console.WriteLine("Adding paypal fees");
        }
    }
}
