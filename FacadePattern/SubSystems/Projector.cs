using System;

namespace FacadePattern.SubSystems
{
    public class Projector
    {
        internal void On()
        {
            Console.WriteLine(" Projector on");
        }

        internal void WideScreenMode()
        {
            Console.WriteLine("Projector in WideScreen Mode");
        }

        internal void Off()
        {
            Console.WriteLine("Projector off");
        }
    }

}
