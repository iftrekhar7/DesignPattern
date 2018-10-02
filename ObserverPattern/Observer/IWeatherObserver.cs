namespace ObserverPattern.Observer
{
    public interface IWeatherObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}