using strategyDesignPattern.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyDesignPattern
{
    class LoudQuack:IQuack
    {
        public void quack()
        {
            Console.WriteLine("Loud quack behavior");
        }
    }
}
