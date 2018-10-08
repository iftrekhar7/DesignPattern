using FactoryPattern.AbstractProduct.Ingredient;
using System;

namespace FactoryPattern.ConcreteProduct.Ingredient
{
    internal class RedPepper : Veggies
    {
        public override void AddVeggies()
        {
            Console.WriteLine("Add Some Red Pepper in Your Pizza");
        }
    }
}