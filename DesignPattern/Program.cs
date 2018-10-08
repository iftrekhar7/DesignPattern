using DecoratorPattern.Component;
using DecoratorPattern.ConcreteComponent;
using FactoryPattern.AbstractFactory.Pizza;
using FactoryPattern.AbstractProduct.Pizza;
using FactoryPattern.ConcreteFactory.Pizza;
using ObserverPattern.ConcreteObserver;
using ObserverPattern.ConcreteSubject;
using StrategyPattern.ConcreteStrategy;
using StrategyPattern.Context;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Strategy Pattern
            //Duck mallardDuck = new MallardDuck();
            //mallardDuck.PerformQuack();
            //mallardDuck.PerformFly();

            //Duck modelDuck = new ModeldDuck();
            //modelDuck.PerformFly();
            //modelDuck.PerformQuack();
            //modelDuck.setFlyBhavior(new FlyRocketPowered());// to change behavior at runtime just call setter method
            //modelDuck.PerformFly();

            //mallardDuck.Display();
            #endregion

            #region Observer Pattern
            //WeatherData weatherData = new WeatherData();

            //CurrentConditionsDisplay currentConditions = new CurrentConditionsDisplay(weatherData);


            //weatherData.SetMeaserments(32.46f, 65, 30.4f);
            #endregion

            #region Decorator Pattern

            //Beverage beverage = new Espresso();
            //Console.WriteLine(beverage.GetDiscription() + " TK-" + beverage.cost());
            //Console.ReadLine();

            #endregion Factory Pattern

            PizzaStore nyPizzaStore = new NYPizzaStore();
            ProductPizza pizza = nyPizzaStore.Orderpizza("Cheese");

            #region 
            #endregion

            #region 
            #endregion

            #region 
            #endregion

            #region 
            #endregion

            #region 
            #endregion

            #region 
            #endregion

            Console.ReadLine();
        }
    }
}
