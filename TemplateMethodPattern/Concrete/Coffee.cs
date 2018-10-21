using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodPattern.Abstract;

namespace TemplateMethodPattern.Concrete
{
    public class Cofee : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Dripping coffee through filter");
        }

        public override void Brew()
        {
            Console.WriteLine("Adding suger and milk");
        }
    }
}
