using StrategyPattern.Strategy;
using System;

namespace StrategyPattern.ConcreteStrategy
{
    internal class RealQuack : IQuackBehavior
    {
        public void PerformQuack()
        {
            Console.WriteLine(@"quack quack");
        }
    }
}
