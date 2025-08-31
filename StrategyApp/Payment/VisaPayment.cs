using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp.Payment
{
    class VisaPayment : IPaymentMethod
    {
        public void processPayment(double price)
        {
            Console.WriteLine($"Processing payment {price}$ with VISA");
            Console.WriteLine("Adding Visa fees");
        }
    }
}
