using FactoryMethodPattern.PaymentMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class PaymentFactory : IPaymentFactory
    {

        public PaymentMethod getPaymentMethod(CardTypes cardTypes, string cardNumber, string cvv, string expiryDate, string cardHolder)
        {
            if(cardTypes==CardTypes.VISA)
            {
                return new VisaPaymentMethod(cardNumber,cvv,expiryDate,cardHolder);
            }
            else if(cardTypes==CardTypes.MASTERCARD)
            {
                return new MasterCardPaymentMethod(cardNumber, cvv, expiryDate, cardHolder);
            }
            else if(cardTypes == CardTypes.AMERICAN_EXPRESS)
            {
                return new AmericanExpressPaymentMethod(cardNumber, cvv, expiryDate, cardHolder);
            }
            else
            {
                throw new ArgumentException("Card type is not supported");
            }
        }
    }
}
