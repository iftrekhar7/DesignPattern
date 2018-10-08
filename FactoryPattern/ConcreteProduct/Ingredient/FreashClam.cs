using FactoryPattern.AbstractProduct.Ingredient;
using System;

namespace FactoryPattern.ConcreteProduct.Ingredient
{
    internal class FreashClam : Clams
    {
        public override void AddClam()
        {
            Console.WriteLine("Add Some Fresh Clams in Your Pizza");
        }
    }
}