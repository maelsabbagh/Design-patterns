using StrategyApp.PriceCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        private readonly IPriceCalculator _priceCalculator; // strategy pattern

        public Product(string Name,double Price,IPriceCalculator priceCalculator)
        {
            this.Name = Name;
            this.Price = Price;
            _priceCalculator = priceCalculator;
        }

        public double calculatePrice()
        {
            return _priceCalculator.CalculatePrice(Price);
        }

       
    }
}
