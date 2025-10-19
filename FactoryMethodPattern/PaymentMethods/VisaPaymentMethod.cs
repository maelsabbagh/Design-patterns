using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.PaymentMethods
{
    public class VisaPaymentMethod : PaymentMethod
    {
        public VisaPaymentMethod(string cardNumber,string cvv,string expiryDate,string cardHolder):base(cardNumber,cvv,expiryDate,cardHolder)
        {
            
        }
        public override void authorize()
        {
            Console.WriteLine("VISA Authorization");
        }

        public override void calculatePaymentFees(double amount)
        {
            Console.WriteLine($"calculating payment fees {amount}");
        }   


        public override void startMoneyTransfer()
        {
            Console.WriteLine("STARTING MONEY TRANSFER FOR VISA PAYMENT");
        }
    }
}
