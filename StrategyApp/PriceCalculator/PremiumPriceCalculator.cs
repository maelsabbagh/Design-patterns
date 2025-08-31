using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp.PriceCalculator
{
    class PremiumPriceCalculator : IPriceCalculator
    {
        const double discount = 0.2; // 20% discount 
        public double CalculatePrice(double price)
        {
            return price - (price * discount);
        }
    }
}
