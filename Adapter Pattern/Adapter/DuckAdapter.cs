using Adapter_Pattern.Adaptee;
using Adapter_Pattern.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Adapter
{
    public class DuckAdapter : ITurkey
    {
        //the adapter implements target interface (ITurkey) and holds an instance of adaptee (IDuck)
        IDuck duck;

        public DuckAdapter(IDuck duck)
        {
            this.duck = duck ?? throw new ArgumentNullException(nameof(duck));
        }

        public void Fly()
        {
            duck.Fly();
        }

        public void Gobble()
        {
            duck.Quack();
        }
    }
}
