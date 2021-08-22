using System;

namespace ObserverPattern
{
    public class NewsSubscriber : IObserver
    {
        public NewsSubscriber(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public void Update(ISubject subject)
        {
            if (subject is WeatherStation weatherStation)
            {
                Console.WriteLine($"{this.Name} reporting temperature: {weatherStation.Temp} degree celsius ");
            }
        }
    }
}