// See https://aka.ms/new-console-template for more information
using FacadeDesignPattern;

Amplifier amp = new("My amplifier");
Tuner tuner = new("My tuner", amp);
DvdPlayer dvdPlayer = new("My dvd", amp);
CdPlayer cdPlayer = new("My cd", amp);
Projector projector = new("My projector", dvdPlayer);
Screen screen = new("My sceen");
TheaterLights theaterLights = new("My theater lights");
PopcornPopper popcornPopper = new("My popcorn popper");

HomeTheaterFacade facade = new(amp, tuner, dvdPlayer, cdPlayer, projector, screen, theaterLights, popcornPopper);
facade.WatchMovie("Harry Potter");
facade.EndMovie();
