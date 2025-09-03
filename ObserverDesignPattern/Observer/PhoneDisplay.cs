using ObserverDesignPattern.Observable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Observer
{
    class PhoneDisplay : IObserver, IDisplay
    {
        private WeatherStation _weatherStation;
        string name;

        double currentTemp;
        public PhoneDisplay(WeatherStation weatherStation, string name)
        {
            _weatherStation = weatherStation;
            currentTemp = 0;
            this.name = name;
        }
        public void update()
        {
            currentTemp = this._weatherStation.getTemperature();
        }

        public void Display()
        {
            Console.WriteLine($"Temperature for phone: {name} is {currentTemp}");
        }
    }
}
