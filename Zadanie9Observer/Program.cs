
public class Program
{
    public static void Main(string[] args)
    {
        WeatherStation weatherStation = new WeatherStation();
        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherStation);
        ForecastDisplay forecastDisplay = new ForecastDisplay(weatherStation);

        while (true)
        {
            Console.WriteLine("Enter temperature:");
            float temperature = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter humidity:");
            float humidity = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter pressure:");
            float pressure = float.Parse(Console.ReadLine());

            weatherStation.SetMeasurements(temperature, humidity, pressure);

            Console.WriteLine("Do you want to continue? (yes/no)");
            if (Console.ReadLine().ToLower() != "yes")
            {
                break;
            }
        }
    }
}









