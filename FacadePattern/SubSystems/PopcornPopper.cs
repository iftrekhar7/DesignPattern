using System;

namespace FacadePattern.SubSystems
{
    public class PopcornPopper
    {
        internal void On()
        {
            Console.WriteLine("Popcorn Popper On");
        }

        internal void Pop()
        {
            Console.WriteLine("Popcorn Popper popping Popcorn");
        }

        internal void Off()
        {
            Console.WriteLine("Popcorn Popper off");
        }
    }

}
