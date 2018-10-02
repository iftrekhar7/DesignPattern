using ObserverPattern.Observer;
using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.ConcreteObserver
{
    public class CurrentConditionsDisplay : IWeatherObserver, IDisplayObserver
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private IWeatherSubject weatherData;

        public CurrentConditionsDisplay(IWeatherSubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions " + temperature+"" + humidity + "" + pressure);
            Console.ReadLine();
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }
    }
}
