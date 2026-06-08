using ObserverPatternWeatherApp.Interfaces;

namespace ObserverPatternWeatherApp.Observers
{
    public class WeatherWebsite : IObserver
    {
        public void Update(float temperature)
        {
            Console.WriteLine(
                $"Website Updated: Temperature = {temperature}°C");
        }
    }
}
