using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Component
{
    public abstract class Beverage
    {
        public string description = "fucking 7 up";

       
        public string GetDiscription()
        {
            return description;
        }

        public abstract double cost();
    }
}
