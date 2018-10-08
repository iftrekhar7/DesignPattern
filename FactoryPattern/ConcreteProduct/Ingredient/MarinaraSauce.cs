using FactoryPattern.AbstractProduct.Ingredient;
using System;

namespace FactoryPattern.ConcreteProduct.Ingredient
{
    internal class MarinaraSauce : Sauce
    {
        internal override void AddSauce()
        {
            Console.WriteLine("Add Some Marianara Sauce in your pizza");
        }
    }
}