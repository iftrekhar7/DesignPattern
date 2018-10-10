using Adapter_Pattern.Adaptee;
using Adapter_Pattern.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Adapter
{
    public class TurkeyAdapter : IDuck
    {
        //the adapter implements target interface (IDuck) and holds an instance of adaptee (ITurkey)
        ITurkey turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public void Fly()
        {
            turkey.Fly();
        }

        public void Quack()
        {
            turkey.Gobble();
        }
    }
}
