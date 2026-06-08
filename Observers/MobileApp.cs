using ObserverPatternWeatherApp.Interfaces;

namespace ObserverPatternWeatherApp.Observers
{
    public class MobileApp : IObserver
    {
        public void Update(float temperature)
        {
            Console.WriteLine(
                $"Mobile App Notification: Temperature = {temperature}°C");
        }
    }
}
