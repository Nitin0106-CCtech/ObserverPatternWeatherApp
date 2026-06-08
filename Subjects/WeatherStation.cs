using ObserverPatternWeatherApp.Interfaces;

namespace ObserverPatternWeatherApp.Subjects
{
    public class WeatherStation : ISubject
    {
        private List<IObserver> observers = new();

        private float temperature;

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature);
            }
        }

        public void SetTemperature(float temperature)
        {
            Console.WriteLine($"\nTemperature Updated: {temperature}°C");

            this.temperature = temperature;

            NotifyObservers();
        }
    }
}
