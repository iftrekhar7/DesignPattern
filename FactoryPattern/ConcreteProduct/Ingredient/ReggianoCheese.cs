using FactoryPattern.AbstractProduct.Ingredient;
using System;

namespace FactoryPattern.ConcreteProduct
{
    public class ReggianoCheese : Cheese
    {
        public override void AddCheese()
        {
            Console.WriteLine("Add Reggiano Cheese in your Pizza");
        }
    }
}