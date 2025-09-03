## Observer pattern UML
![UML Diagram](images/ObserverPatternUML.png)

## Example: Weather station UML
![Weather station UML](images/WeatherStation_ObserverPatternUML.png)


notify in IObservable will call update in IObserver
and the concrete class of Iobserver has instance of the concrete class of IObservable so it can read the updates
