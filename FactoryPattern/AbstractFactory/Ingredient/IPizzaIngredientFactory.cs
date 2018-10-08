using FactoryPattern.AbstractProduct.Ingredient;

namespace FactoryPattern.AbstractFactory.Ingredient
{
    public interface IPizzaIngredientFactory
    {
        Dough  CreateDough();
        Sauce  CreateSauce();
        Cheese CreateCheese();
        Veggies[] CreateVaggies();
        Pepperoni CreatePepperoni();
        Clams CreateClam();
    }
}
