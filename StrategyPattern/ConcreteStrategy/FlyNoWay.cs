using StrategyPattern.Strategy;
using System;

namespace StrategyPattern.ConcreteStrategy
{
    internal class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine(@"I hate flying");
        }
    }
}
