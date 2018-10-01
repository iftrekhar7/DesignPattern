using StrategyPattern.ConcreteStrategy;
using System;

namespace StrategyPattern.Context
{
    public class ModeldDuck : Duck
    {
        public ModeldDuck()
        {
            setFlyBhavior(new FlyNoWay());
            quackBehavior = new RealQuack();
        }


        public override void Display()
        {
            Console.WriteLine(@"I'm just a Model duck");
            Console.ReadLine();
        }
    }
}
