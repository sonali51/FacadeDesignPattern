/******************************************************************************
* Filename    = HomeTheaterFacade.cs
*
* Author      = Sonali
*
* Product     = Software Design Patterns
* 
* Project     = Facade Design Pattern
*
* Description = The 'HomeTheaterFacade' Class
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheaterManager
{
    public class HomeTheaterFacade
    {
        private readonly Projector _projector;
        private readonly SoundSystem _soundSystem;
        private readonly DVDPlayer _dvdPlayer;

        public HomeTheaterFacade(Projector projector, SoundSystem soundSystem, DVDPlayer dvdPlayer)
        {
            _projector = projector;
            _soundSystem = soundSystem;
            _dvdPlayer = dvdPlayer;
        }

        /// <summary>
        /// Plays the specified movie.
        /// </summary>
        /// <param name="movie">The name of the movie to play.</param>

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Getting ready to watch a movie...");
            _projector.On();
            _soundSystem.On();
            _soundSystem.SetVolume(5);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        /// <summary>
        /// Turns off all components of the home theater system.
        /// </summary>

        public void EndMovie()
        {
            Console.WriteLine("Shutting down the Home theater...");
            _dvdPlayer.Off();
            _soundSystem.Off();
            _projector.Off();
        }

    }
}