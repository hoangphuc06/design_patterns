using System.Text;

namespace FacadeDesignPattern
{
    /// <summary>
    /// Summary description for HomeTheaterFacade.
    /// </summary>
    public class HomeTheaterFacade
    {
        readonly Amplifier amp;
        readonly Tuner tuner;
        readonly DvdPlayer dvd;
        readonly CdPlayer cd;
        readonly Projector projector;
        readonly TheaterLights lights;
        readonly Screen screen;
        readonly PopcornPopper popper;

        public HomeTheaterFacade(Amplifier amp,
            Tuner tuner,
            DvdPlayer dvd,
            CdPlayer cd,
            Projector projector,
            Screen screen,
            TheaterLights lights,
            PopcornPopper popper)
        {
            this.amp = amp;
            this.tuner = tuner;
            this.dvd = dvd;
            this.cd = cd;
            this.projector = projector;
            this.screen = screen;
            this.lights = lights;
            this.popper = popper;
        }

        public object WatchMovie(string movie)
        {
            StringBuilder watchMovieString = new();

            watchMovieString.Append("Get ready to watch a movie...\n");
            watchMovieString.Append(popper.On());
            watchMovieString.Append(popper.Pop());
            watchMovieString.Append(lights.Dim(10));
            watchMovieString.Append(screen.Down());
            watchMovieString.Append(projector.On());
            watchMovieString.Append(projector.WideScreenMode());
            watchMovieString.Append(amp.On());
            watchMovieString.Append(amp.SetDvd(dvd));
            watchMovieString.Append(amp.SetSurroundSound());
            watchMovieString.Append(amp.SetVolume(5));
            watchMovieString.Append(dvd.On());
            watchMovieString.Append(dvd.Play(movie));
            Console.WriteLine(watchMovieString.ToString());
            return watchMovieString.ToString();
        }


        public object EndMovie()
        {
            StringBuilder endMovieString = new();

            endMovieString.Append("Shutting movie theater down...\n");
            endMovieString.Append(popper.Off());
            endMovieString.Append(lights.On());
            endMovieString.Append(screen.Up());
            endMovieString.Append(projector.Off());
            endMovieString.Append(amp.Off());
            endMovieString.Append(dvd.Stop());
            endMovieString.Append(dvd.Eject());
            endMovieString.Append(dvd.Off());
            Console.WriteLine(endMovieString.ToString());

            return endMovieString.ToString();
        }

        public object ListenToCd(string cdTitle)
        {
            StringBuilder listenToCdString = new();

            listenToCdString.Append("Get ready for an audio experence...\n");
            listenToCdString.Append(lights.On());
            listenToCdString.Append(amp.On());
            listenToCdString.Append(amp.SetVolume(5));
            listenToCdString.Append(amp.SetCd(cd));
            listenToCdString.Append(amp.SetStereoSound());
            listenToCdString.Append(cd.On());
            listenToCdString.Append(cd.Play(cdTitle));
            Console.WriteLine(listenToCdString.ToString());

            return listenToCdString.ToString();
        }

        public object EndCd()
        {
            StringBuilder endCdString = new();

            endCdString.Append("Shutting down CD...\n");
            endCdString.Append(amp.Off());
            endCdString.Append(amp.SetCd(cd));
            endCdString.Append(cd.Eject());
            endCdString.Append(cd.Off());
            Console.WriteLine(endCdString.ToString());

            return endCdString.ToString();
        }

        public object ListenToRadio(double frequency)
        {
            StringBuilder listenToRadioString = new();

            listenToRadioString.Append("Tuning in the airwaves...\n");
            listenToRadioString.Append(tuner.On());
            listenToRadioString.Append(tuner.SetFrequency(frequency));
            listenToRadioString.Append(amp.On());
            listenToRadioString.Append(amp.SetVolume(5));
            listenToRadioString.Append(amp.SetTuner(tuner));
            Console.WriteLine(listenToRadioString.ToString());

            return listenToRadioString.ToString();
        }

        public object EndRadio()
        {
            StringBuilder endRadioString = new();

            endRadioString.Append("Shutting down the tuner...\n");
            endRadioString.Append(tuner.Off());
            endRadioString.Append(amp.Off());
            Console.WriteLine(endRadioString.ToString());

            return endRadioString.ToString();
        }
    }
}
