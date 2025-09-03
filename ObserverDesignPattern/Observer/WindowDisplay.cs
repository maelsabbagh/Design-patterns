using ObserverDesignPattern.Observable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObserverDesignPattern.Observer
{
    class WindowDisplay : IObserver, IDisplay
    {
        private WeatherStation _weatherStation;
        double currentTemp;
        string name;

        public WindowDisplay(WeatherStation weatherStation, string name)
        {
            _weatherStation = weatherStation;
            currentTemp = 0;
            this.name = name;
        }
        public void update()
        {
            this.currentTemp = _weatherStation.getTemperature();
        }
        public void Display()
        {
            Console.WriteLine($"Temperature for Window: {name} is {currentTemp}");
        }

        
    }
}
