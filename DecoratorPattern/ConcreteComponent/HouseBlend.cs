using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteComponent
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "HouseBlend";
        }

        public override double cost()
        {
            return 0.99;
        }
    }
}
