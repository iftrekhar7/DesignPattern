using FactoryPattern.AbstractProduct.Ingredient;
using System;

namespace FactoryPattern.ConcreteProduct.Ingredient
{
    internal class Garlic : Veggies
    {
        public override void AddVeggies()
        {
            Console.WriteLine("Add Some Garlic in Your Pizza");
        }
    }
}