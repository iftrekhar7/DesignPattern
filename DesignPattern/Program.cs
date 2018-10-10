using Adapter_Pattern.Adapter;
using Adapter_Pattern.ConcreteTarget;
using Adapter_Pattern.CongreteAdaptee;
using Adapter_Pattern.Target;
using CommandPattern.Command;
using CommandPattern.ConcreteCommand;
using CommandPattern.Invoker;
using CommandPattern.Receiver;
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

            #endregion 

            #region Factory Pattern
           
            //PizzaStore nyPizzaStore = new NYPizzaStore();
            //ProductPizza pizza = nyPizzaStore.Orderpizza("Cheese");

            #endregion

            #region Command Pattern

            RemoteControl remoteControl = new RemoteControl();// invoker, it will be passed a command object that can be used to make request
            #region 
            #region Create all devices in their Proper Location
            Light livingRoomLight = new Light("Living Room");// receiver of the request
            Light kitchenRoomLight = new Light("kitchen Room");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            Stereo stereo = new Stereo("Living Room");
            GarageDoor garageDoor = new GarageDoor();
            #endregion

            #region Create all the command object
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);// create a command & pass it to the receiver
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);// create a command & pass it to the receiver
            LightOnCommand KichenRoomLightOn = new LightOnCommand(kitchenRoomLight);// create a command & pass it to the receiver
            LightOffCommand KichenRoomLightOff = new LightOffCommand(kitchenRoomLight);// create a command & pass it to the receiver

            CeilingFanOnCommand ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            StereoOffCommand stereoOff = new StereoOffCommand(stereo);
            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);

            GarageDoorOpenCommand garageDoorOpen = new GarageDoorOpenCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);

            #endregion

            #region load all commands in the  remote slot
            //remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            //remoteControl.SetCommand(1, KichenRoomLightOn, KichenRoomLightOff);
            //remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
            //remoteControl.SetCommand(3, stereoOnWithCD, stereoOff);
            #endregion

            #region action
            //Console.WriteLine(remoteControl);

            //remoteControl.OnButtonWasPushed(0);
            //remoteControl.OffButtonWasPushed(0);
            //remoteControl.OnButtonWasPushed(1);
            //remoteControl.OffButtonWasPushed(1);
            //remoteControl.OnButtonWasPushed(2);
            //remoteControl.OffButtonWasPushed(2);
            //remoteControl.OnButtonWasPushed(3);
            //remoteControl.OffButtonWasPushed(3);
            #endregion

            #endregion

            #region Undo Action in ceiling
            //CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            //CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            //CeilingFanLowCommand ceilingFanLow = new CeilingFanLowCommand(ceilingFan);
            //CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            //remoteControl.SetCommand(0, ceilingFanMedium, ceilingFanOff);
            //remoteControl.SetCommand(1, ceilingFanHigh, ceilingFanOff);


            //remoteControl.OnButtonWasPushed(0);
            //remoteControl.OffButtonWasPushed(0);

            //Console.WriteLine(remoteControl);
            //remoteControl.undoButtonWasPushed();

            //remoteControl.OnButtonWasPushed(1);
            //Console.WriteLine(remoteControl);
            //remoteControl.undoButtonWasPushed();
            //Console.WriteLine(remoteControl);
            #endregion


            #region Macro Command

            ICommand[] partyOn = { livingRoomLightOn, stereoOnWithCD, ceilingFanOn, garageDoorOpen };
            ICommand[] partyOff = { livingRoomLightOff, stereoOff, ceilingFanOff, garageDoorDown };

            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            remoteControl.SetCommand(0, partyOnMacro, partyOffMacro);


            //Console.WriteLine(remoteControl);
            //Console.WriteLine("----Pushing Macro On----");
            //remoteControl.OnButtonWasPushed(0);
            //Console.WriteLine("----Pushing Macro Off----");
            //remoteControl.OffButtonWasPushed(0);
            //Console.WriteLine("----Pushing Macro Undo----");
            //remoteControl.undoButtonWasPushed();
            #endregion


            #endregion

            #region Adapter Pattern
            MallaDuck duck = new MallaDuck();

            WildTurkey wildTurkey = new WildTurkey();

            IDuck turkeyAdapter = new TurkeyAdapter(wildTurkey);

            Console.WriteLine("The Turkey Says...");
            wildTurkey.Gobble();
            wildTurkey.Fly();

            Console.WriteLine("\n The Duck Says...");
            testDuck(duck);

            Console.WriteLine("\n The TurkeyAdapter Says...");
            testDuck(turkeyAdapter);
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

            #region 
            #endregion

            Console.ReadLine();
        }
        static void testDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
