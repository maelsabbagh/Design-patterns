using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp.Payment
{
    class BankTransferPayment:IPaymentMethod
    {
        public void processPayment(double price)
        {
            Console.WriteLine($"Processing payment {price}$ with BankTransfer");
        }
    }
}
