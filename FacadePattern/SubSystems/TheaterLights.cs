using System;

namespace FacadePattern.SubSystems
{
    public class TheaterLights
    {
        internal void Dim(int lightPower)
        {
            Console.WriteLine("Theater Ceiling Lights is dimming to" + lightPower);
        }

        internal void On()
        {
            Console.WriteLine("Theater Ceiling Lights off");
        }
    }

}
