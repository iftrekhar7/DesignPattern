using FactoryPattern.AbstractProduct.Ingredient;
using System;

namespace FactoryPattern.ConcreteProduct.Ingredient
{
    internal class ThinCrusatDough : Dough
    {
        public override void AddDouch()
        {
            Console.WriteLine(" Your Pizza have thin Crust");
        }
    }
}