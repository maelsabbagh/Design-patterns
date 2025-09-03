﻿using ObserverDesignPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Observable
{
    interface IObservable
    {
        void add(IObserver observer);
        void remove(IObserver observer);
        void notify();
    }
}
