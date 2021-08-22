 using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main()
        {
            var weatherStation = new WeatherStation();

            var newsSubscriber1 = new NewsSubscriber("San Lucas Agency");
            var newsSubscriber2 = new NewsSubscriber("Triclolcum Agency");

            weatherStation.Attach(newsSubscriber1);
            weatherStation.Attach(newsSubscriber2);

            weatherStation.Temp = 25.18f;
            weatherStation.Temp = 23.21f;
            weatherStation.Temp = 18.34f;

            Console.ReadKey();
        }
    }
}
