using StrategyPattern.Strategy;
using System;

namespace StrategyPattern.ConcreteStrategy
{
    public class MuteQuack : IQuackBehavior
    {
        public void PerformQuack()
        {
            Console.WriteLine(@"No sounds, Just feel");
        }
    }
}
