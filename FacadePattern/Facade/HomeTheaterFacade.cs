using FacadePattern.SubSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Facade
{
    public class HomeTheaterFacade
    {
        Amplifier amplifier;
        Tuner tuner;
        DvdPlayer dvdPlayer;
        CdPlayer cdPlayer;
        Projector projector;
        TheaterLights lights;
        Screen screem;
        PopcornPopper popper;

        public HomeTheaterFacade(Tuner tuner, Amplifier amplifier, DvdPlayer dvdPlayer, CdPlayer cdPlayer, Projector projector, TheaterLights lights, Screen screem, PopcornPopper popper)
        {
            this.amplifier = amplifier ?? throw new ArgumentNullException(nameof(amplifier));
            this.tuner = tuner ?? throw new ArgumentNullException(nameof(tuner));
            this.dvdPlayer = dvdPlayer ?? throw new ArgumentNullException(nameof(dvdPlayer));
            this.cdPlayer = cdPlayer ?? throw new ArgumentNullException(nameof(cdPlayer));
            this.projector = projector ?? throw new ArgumentNullException(nameof(projector));
            this.lights = lights ?? throw new ArgumentNullException(nameof(lights));
            this.screem = screem ?? throw new ArgumentNullException(nameof(screem));
            this.popper = popper ?? throw new ArgumentNullException(nameof(popper));
        }

        public void WatchMovies(string movie)
        {
            Console.WriteLine("Get Ready to watch a movie");

            popper.On();
            popper.Pop();
            lights.Dim(10);
            screem.Down();
            projector.On();
            projector.WideScreenMode();
            amplifier.StartAmplifier();
            dvdPlayer.On();
            dvdPlayer.Play(movie);

        }
        
        public void EndMovie()
        {
            Console.WriteLine("Shutting Movie Theater Down");

            popper.Off();
            lights.On();
            screem.Up();
            projector.Off();
            amplifier.Off();
            dvdPlayer.StopPlayingDvd();
        }

        
    }
}
