using FactoryPattern.AbstractProduct.Ingredient;
using System;

namespace FactoryPattern.ConcreteProduct.Ingredient
{
    internal class Mashroom : Veggies
    {
        public override void AddVeggies()
        {
            Console.WriteLine("Add Some Sliced Mashroom in Your Pizza");
        }
    }
}