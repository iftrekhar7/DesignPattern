using FactoryPattern.AbstractProduct.Ingredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AbstractProduct.Pizza
{
    public abstract class ProductPizza
    {
        private string name;
        public Dough dough;
        public Sauce sauce;
        public Veggies vaggies;
        public Cheese cheese;
        public Pepperoni pepperoni;
        public Clams clams;

        public abstract void Prepare();

        public List<string> toppings = new List<string>();

        public string Name { get => name; set => name = value; }

        //public virtual void Prepare()
        //{
        //    Console.WriteLine("preparing " + Name);
        //    Console.WriteLine("Adding sauce...");
        //    Console.WriteLine("Adding douch...");
        //    Console.WriteLine("Adding topping:");
        //    foreach ( var item in toppings)
        //    {
        //        Console.WriteLine("  " + item.ToString());
        //    }
        //}

        internal virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        internal virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into Diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place Pizza in the officeal pizzaStore box");
        }

        public String toString()
        {
            return "";
        }
    }
}
