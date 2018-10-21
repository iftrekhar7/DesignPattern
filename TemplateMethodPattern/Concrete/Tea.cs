using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodPattern.Abstract;

namespace TemplateMethodPattern.Concrete
{
    public class Tea : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }
        public override bool CustomerWantsCondiments()
        {
            string answer = GetUserInput();
             if (answer.ToLower() == "y")
            {
                return true;
            }
            return false;
        }

        private string GetUserInput()
        {
            Console.WriteLine("Do you want to Lemon in your tre? (Y/N)");
            return Console.ReadLine();
        }
    }
}
