using ObserverDesignPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Observable
{
    class WeatherStation : IObservable
    {
        HashSet<IObserver> observers;
        double temperature;

        public WeatherStation()
        {
            observers = new HashSet<IObserver>();
            temperature = 0;
        }
        public void add(IObserver observer)
        {
            observers.Add(observer);
        }

        public void remove(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void notify()
        {
            foreach(var obs in observers)
            {
                obs.update();
            }
        }

        public double getTemperature()
        {
            return this.temperature;
        }

        public void setTemperature(double temp)
        {
            this.temperature = temp;
            notify();
        }

       
    }
}
