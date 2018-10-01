using StrategyPattern.Strategy;
using System;

namespace StrategyPattern.ConcreteStrategy
{
    public class SqueckQuack : IQuackBehavior
    {
        public void PerformQuack()
        {
            Console.WriteLine(@"squeck squeck");
        }
    }
}
