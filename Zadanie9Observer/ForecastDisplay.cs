public class ForecastDisplay : IObserver
{
    private float currentPressure;
    private float lastPressure;

    public ForecastDisplay(ISubject weatherStation)
    {
        weatherStation.Attach(this);
    }

    public void Update(float temp, float hum, float press)
    {
        lastPressure = currentPressure;
        currentPressure = press;
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Forecast: ");
        if (currentPressure > lastPressure)
        {
            Console.WriteLine("Improving weather on the way!");
        }
        else if (currentPressure == lastPressure)
        {
            Console.WriteLine("More of the same");
        }
        else
        {
            Console.WriteLine("Watch out for cooler, rainy weather");
        }
    }
}