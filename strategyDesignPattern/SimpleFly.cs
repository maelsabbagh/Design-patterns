using strategyDesignPattern.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyDesignPattern
{
    class SimpleFly:IFly
    {
        public void fly()
        {
            Console.WriteLine("I am a simple fly");
        }
    }
}
