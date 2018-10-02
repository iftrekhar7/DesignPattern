using ObserverPattern.Observer;
using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.ConcreteSubject
{
    public class WeatherData : IWeatherSubject
    {
        private List<IWeatherObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<IWeatherObserver>();
        }

        public void SetMeaserments(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }

        public void RegisterObserver(IWeatherObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IWeatherObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }
        

        public void measurementsChanged()
        {
            NotifyObserver();
        }

        
    }
}
