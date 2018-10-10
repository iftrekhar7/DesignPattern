using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receiver
{
    public class CeilingFan
    {
        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;

        private string location;
        public int speed = 0; 

        public CeilingFan(string v)
        {
            this.location = v;
        }

        internal void High()
        {
            speed = HIGH;
            Console.WriteLine(location + " Ceiling Fan is on HIGH Speed");
        }
        internal void Medium()
        {
            speed = MEDIUM;
            Console.WriteLine(location + " Ceiling Fan is on Medium Speed");
        }
        internal void Low()
        {
            speed = LOW;
            Console.WriteLine(location + " Ceiling Fan is on LOW Speed");
        }
        internal void Off()
        {
            speed = OFF;
            Console.WriteLine(location + " Ceiling Fan is off");
        }

        internal void On()
        {
            Console.WriteLine(location + " Ceiling Fan is on");
        }

        public int GetSpeed()
        {
            return speed;
        }

        public void GoToPreviousState(int prevSpeed)
        {
            if (prevSpeed == HIGH)
            {
                High();
            }
            else if (prevSpeed == MEDIUM)
            {
                Medium();
            }
            else if (prevSpeed == LOW)
            {
                Low();
            }
            else if (prevSpeed == OFF)
            {
                Off();
            }
        }
    }
}
