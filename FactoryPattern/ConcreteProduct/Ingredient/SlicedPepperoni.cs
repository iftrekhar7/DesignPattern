using FactoryPattern.AbstractProduct.Ingredient;
using System;

namespace FactoryPattern.ConcreteProduct.Ingredient
{
    internal class SlicedPepperoni : Pepperoni
    {
        public override void AddPepperoni()
        {
            Console.WriteLine("Add Some Sliced Pepperoni in Your Pizza");
        }
    }
}