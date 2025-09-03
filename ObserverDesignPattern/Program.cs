using ObserverDesignPattern;
using ObserverDesignPattern.Observable;
using ObserverDesignPattern.Observer;

void printTempForDevices(List<IDisplay> displayDevices)
{
    Console.WriteLine("Displaying temperatures from display devices:");
    foreach (var device in displayDevices)
    {
        device.Display();
    }
    Console.WriteLine("********************************************");
}

WeatherStation weatherStation = new WeatherStation();

PhoneDisplay samsungPhone = new PhoneDisplay(weatherStation, "samsung");
PhoneDisplay applePhone = new PhoneDisplay(weatherStation, "apple");

WindowDisplay kitchenWindow = new WindowDisplay(weatherStation, "kitchenWindow");


List<IDisplay> displayDevices = new List<IDisplay>();
displayDevices.Add(samsungPhone);
displayDevices.Add(applePhone);
displayDevices.Add(kitchenWindow);

// register to weather station
weatherStation.add(samsungPhone);
weatherStation.add(applePhone);
weatherStation.add(kitchenWindow);

weatherStation.setTemperature(40);

printTempForDevices(displayDevices);


weatherStation.setTemperature(32.5);
printTempForDevices(displayDevices);


weatherStation.remove(kitchenWindow); // kitchen window will not be updated anymore
weatherStation.setTemperature(20.7);

printTempForDevices(displayDevices);
