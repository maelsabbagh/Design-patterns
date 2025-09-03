using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverApp.Interfaces
{
    interface IObservable
    {
        void add(EventType eventType, IObserver observer);
        void remove(EventType eventType, IObserver observer);

        void notify(EventType eventType,string message);
    }
}
