using StrategyPattern.Strategy;
using System;

namespace StrategyPattern.Context
{
    public abstract class Duck
    {
        public IQuackBehavior quackBehavior;
        public IFlyBehavior flyBehavior;


        public Duck()
        {

        }
        public void PerformQuack() => quackBehavior.PerformQuack(); //Delegate to the behavior class
        public void PerformFly() => flyBehavior.Fly();

        public void setFlyBhavior(IFlyBehavior value)
        {
            flyBehavior = value;
        }

        public void setQuackBhavior(IQuackBehavior value)
        {
            quackBehavior = value;

        }

        public abstract void Display();

        public void Swim() => Console.WriteLine("all ducks float, even decoy");
    }
}
