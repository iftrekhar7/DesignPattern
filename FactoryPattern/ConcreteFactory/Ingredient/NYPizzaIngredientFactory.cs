using FactoryPattern.AbstractFactory.Ingredient;
using FactoryPattern.AbstractProduct.Ingredient;
using FactoryPattern.ConcreteProduct;
using FactoryPattern.ConcreteProduct.Ingredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.ConcreteFactory.Ingredient
{
    class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            Cheese cheese =  new ReggianoCheese();
            cheese.AddCheese();
            return cheese;
        }

        public Clams CreateClam()
        {
            Clams clams = new FreashClam();
            clams.AddClam();
            return clams;
        }

        public Dough CreateDough()
        {
            Dough dough = new ThinCrusatDough();
            dough.AddDouch();
            return dough;
        }

        public Pepperoni CreatePepperoni()
        {
            Pepperoni pepperoni = new SlicedPepperoni();
            pepperoni.AddPepperoni();
            return pepperoni;
        }

        public Sauce CreateSauce()
        {
            Sauce sauce = new MarinaraSauce();
            sauce.AddSauce();
            return sauce;
        }

        public Veggies[] CreateVaggies()
        {
            Veggies garlic = new Garlic();
            Veggies mashroom = new Mashroom();
            Veggies peeper = new RedPepper();
            Veggies[] veggies = { garlic, mashroom, peeper };
            return veggies;
        }
    }
}
