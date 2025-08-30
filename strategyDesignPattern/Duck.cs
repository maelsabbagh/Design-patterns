using strategyDesignPattern.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyDesignPattern
{
    class Duck
    {
        string name;
        string color;
        private readonly IFly _fly;
        private readonly IQuack _quack;

        public Duck(IFly fly, IQuack quack, string name, string color)
        {
            _fly = fly;
            _quack = quack;
            this.name = name;
            this.color = color;
        }

        public void DuckFly()
        {
            this._fly.fly();
        }

        public void DuckQuack()
        {
            this._quack.quack();
        }

        public void printDuck()
        {
            Console.WriteLine($"Duck name={name}\n" +
                $"Duck color={color}\n" +
                $"------------------------------------------");  
        }
    }
}
