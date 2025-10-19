using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.PaymentMethods
{
    public abstract class PaymentMethod
    {
        private string cardNumber;
        private string cvv;
        private string expiryDate;
        private string cardHolder;

        public PaymentMethod(string cardNumber,string cvv,string expiryDate,string cardHolder)
        {
            this.cardNumber = cardNumber;
            this.cvv = cvv;
            this.expiryDate = expiryDate;
            this.cardHolder = cardHolder;
        }


        public string getCardNumber()
        {
            return cardNumber;
        }
        public string getCVV()
        {
            return cvv;
        }
        public string getCardHolder()
        {
            return cardHolder;
        }
        public string getExpiryDate()
        {
            return expiryDate;
        }
        public abstract void authorize();
        public abstract void startMoneyTransfer();
        public abstract void calculatePaymentFees(double amount);
    }
}
