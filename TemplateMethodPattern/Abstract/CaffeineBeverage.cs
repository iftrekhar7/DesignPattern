using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Abstract
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()// Template Method
        {
            //the template method defines the steps of an algorithm and allow
            // subclasses to provide the implementation for one or more steps.
            BoilWater();
            Brew();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
            PourInCup();
           
        }

        public virtual bool CustomerWantsCondiments()
        {
            //this is a hook because the subclass can override this but doesn't have to
            return true;
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring Into Cup");
        }

        public abstract void Brew();


        public abstract void AddCondiments();
    }
}
