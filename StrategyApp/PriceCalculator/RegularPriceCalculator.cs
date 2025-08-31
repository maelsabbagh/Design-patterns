using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp.PriceCalculator
{
    class RegularPriceCalculator : IPriceCalculator
    {
        public double CalculatePrice(double price)
        {
            return price; // no discount
        }
    }
}
