public class CurrentConditionsDisplay : IObserver
{
    private float temperature;
    private float humidity;

    public CurrentConditionsDisplay(ISubject weatherStation)
    {
        weatherStation.Attach(this);
    }

    public void Update(float temp, float hum, float press)
    {
        temperature = temp;
        humidity = hum;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {temperature}C degrees and {humidity}% humidity");
    }
}