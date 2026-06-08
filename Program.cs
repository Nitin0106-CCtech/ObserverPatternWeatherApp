using ObserverPatternWeatherApp.Subjects;
using ObserverPatternWeatherApp.Observers;

namespace ObserverPatternWeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new();

            MobileApp mobileApp = new();
            LEDDisplay ledDisplay = new();
            WeatherWebsite website = new();

            weatherStation.RegisterObserver(mobileApp);
            weatherStation.RegisterObserver(ledDisplay);
            weatherStation.RegisterObserver(website);

            weatherStation.SetTemperature(25);
            weatherStation.SetTemperature(30);

            weatherStation.RemoveObserver(ledDisplay);

            Console.WriteLine(
                "\nLED Display unsubscribed...\n");

            weatherStation.SetTemperature(35);
        }
    }
}
