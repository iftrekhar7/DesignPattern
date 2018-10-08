using FactoryPattern.AbstractFactory.Ingredient;
using FactoryPattern.AbstractFactory.Pizza;
using FactoryPattern.AbstractProduct.Pizza;
using FactoryPattern.ConcreteFactory.Ingredient;
using FactoryPattern.ConcreteProduct.Pizza;
using System;

namespace FactoryPattern.ConcreteFactory.Pizza
{
    public class NYPizzaStore : PizzaStore
    {
        public override ProductPizza CreatePizza(string item)
        {
            ProductPizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (item.Equals("Cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "New York Style Cheese Pizza";
                Console.WriteLine("Iftekhar odered a " + pizza.Name);
                pizza.Prepare();
            }
            else if (item.Equals("Veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.Name = "New York Style Veggie Pizza";
                pizza.Prepare();
            }
            else if (item.Equals("Clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.Name = "New York Style Clam Pizza";
                pizza.Prepare();
            }
            else if (item.Equals("Pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.Name = "New York Style Pepperoni Pizza";
                pizza.Prepare();
            }

            return pizza;
        }

    }
}
