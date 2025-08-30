﻿using strategyDesignPattern.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyDesignPattern
{
    class SimpleQuack : IQuack
    {
        public void quack()
        {
            Console.WriteLine("simple quack behavior");
        }
    }
}
