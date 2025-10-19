using FactoryMethodPattern.PaymentMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    interface IPaymentFactory
    {
        PaymentMethod getPaymentMethod(CardTypes cardTypes, string cardNumber, string cvv, string expiryDate, string cardHolder); 

    }
}
