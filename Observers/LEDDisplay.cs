using ObserverPatternWeatherApp.Interfaces;

namespace ObserverPatternWeatherApp.Observers
{
    public class LEDDisplay : IObserver
    {
        public void Update(float temperature)
        {
            Console.WriteLine(
                $"LED Display Updated: {temperature}°C");
        }
    }
}
