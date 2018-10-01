using StrategyPattern.Strategy;
using System;

namespace StrategyPattern.ConcreteStrategy
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I am flying with a rocket");
        }
    }
}
