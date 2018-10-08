using FactoryPattern.AbstractFactory.Ingredient;
using FactoryPattern.AbstractProduct.Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.ConcreteProduct.Pizza
{
    class VeggiePizza : ProductPizza
    {
        IPizzaIngredientFactory pizzaIngredientFactory;

        public VeggiePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this.pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preaparing " + Name);
            dough = pizzaIngredientFactory.CreateDough();
            sauce = pizzaIngredientFactory.CreateSauce();
            cheese = pizzaIngredientFactory.CreateCheese();
        }
    }
}
