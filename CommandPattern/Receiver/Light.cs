using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receiver
{
    public class Light
    {
        private string v;

        public Light(string v)
        {
            this.v = v;
        }

        internal void On()
        {
            Console.WriteLine(v + " Light is on");
        }

        internal void Off()
        {
            Console.WriteLine(v + "Light is off");
        }
    }
}
