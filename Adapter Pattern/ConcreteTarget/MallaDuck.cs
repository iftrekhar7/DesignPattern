using Adapter_Pattern.Target;
using System;

namespace Adapter_Pattern.ConcreteTarget
{
    public class MallaDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I am flying");
        }

        public void Quack()
        {
            Console.WriteLine("Quack quack");
        }
    }
}
