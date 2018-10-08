using FactoryPattern.AbstractProduct.Pizza;

namespace FactoryPattern.AbstractFactory.Pizza
{
    public abstract class PizzaStore
    {
        public ProductPizza Orderpizza (string type)
        {
            ProductPizza pizza;

            pizza = CreatePizza(type);
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        } 

        public abstract ProductPizza CreatePizza(string item);
    }
}
