using StrategyPattern.ConcreteStrategy;
using System;

namespace StrategyPattern.Context
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            setQuackBhavior(new RealQuack());
            flyBehavior = new FlyWithWings();
        }


        public override void Display()
        {
            Console.WriteLine(@"I'm a real Mallard duck");
            Console.ReadLine();
        }
    }
}
