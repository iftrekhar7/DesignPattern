using StrategyPattern.Strategy;
using System;

namespace StrategyPattern.ConcreteStrategy
{
    internal class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine(@"Flying to the future");
        }
    }
}
