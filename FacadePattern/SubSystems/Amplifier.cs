using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.SubSystems
{
    public class Amplifier
    {
        internal void On()
        {
            Console.WriteLine("Amplifier on");
        }

        internal void SetDvd()
        {
            Console.WriteLine("Amplifier setting DVD player to DVD Player");
        }

        internal void SetSurrondSound()
        {
            Console.WriteLine("Amplifier Surrond Sound On");
        }

        internal void SetVolume(int volume)
        {
            Console.WriteLine("Amplifier setting volume to " + volume);
        }

        internal void Off()
        {
            Console.WriteLine("Amplifier off");
        }

        internal void StartAmplifier()
        {
            On();
            SetDvd();
            SetSurrondSound();
            SetVolume(5);
        }
    }

}
