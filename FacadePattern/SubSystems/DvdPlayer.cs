using System;

namespace FacadePattern.SubSystems
{
    public class DvdPlayer
    {
        internal void On()
        {
            Console.WriteLine("DvdPlayer on");
        }

        internal void Play(string movieName)
        {
            Console.WriteLine("DvdPlayer playing " + movieName);
        }

        internal void Stop()
        {
            Console.WriteLine("DvdPlayer stopped playing movie ");
        }

        internal void Eject()
        {
            Console.WriteLine("DvdPlayer eject");
        }

        internal void Off()
        {
            Console.WriteLine("DvdPlayer Off");
        }

        public void StopPlayingDvd()
        {
            Stop();
            Eject();
            Off();
        }
    }

}
