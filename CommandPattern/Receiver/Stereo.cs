using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receiver
{
    public class Stereo
    {
        private string v;

        public Stereo(string v)
        {
            this.v = v;
        }

        internal void SetCD()
        {
            Console.WriteLine("Set"+ v + " Stereo CD");
        }

        internal void On()
        {
            Console.WriteLine(v + "Stereo is on");
        }

        internal void Off()
        {
            Console.WriteLine(v + " Stereo is off");
        }

        internal void SetVolume(int volume)
        {
            Console.WriteLine(v +  "Stereo Volume is set to " + volume );
        }
    }
}
