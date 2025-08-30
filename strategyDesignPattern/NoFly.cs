using strategyDesignPattern.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyDesignPattern
{
    class NoFly : IFly
    {
        public void fly()
        {
            Console.WriteLine("I am not flying");
        }
    }
}
