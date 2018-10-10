using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receiver
{
    public class GarageDoor
    {
        internal void Up()
        {
            Console.WriteLine("Garage door is open");
        }

        internal void Down()
        {
            Console.WriteLine("Garage door is close");
        }

        internal void Stop()
        {
            Console.WriteLine("Garage door is stop");
        }
    }
}
