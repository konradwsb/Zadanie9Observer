public class WeatherStation : ISubject
{
    private List<IObserver> observers;
    private float temperature;
    private float humidity;
    private float pressure;

    public WeatherStation()
    {
        observers = new List<IObserver>();
    }

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(temperature, humidity, pressure);
        }
    }

    public void SetMeasurements(float temp, float hum, float press)
    {
        temperature = temp;
        humidity = hum;
        pressure = press;
        NotifyObservers();
    }
}