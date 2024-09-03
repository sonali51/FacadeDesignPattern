/******************************************************************************
* Filename    = Client.cs
*
* Author      = Sonali
*
* Product     = Software Design Patterns
* 
* Project     = Facade Design Pattern
*
* Description = The 'Client' class
*****************************************************************************/

using HomeTheaterManager;
namespace Client
{
    internal class program
    {
        static void Main(string[] args)
        {
            var projector = new Projector();
            var soundSystem = new SoundSystem();
            var dvdPlayer = new DVDPlayer();

            // Create the facade
            var homeTheater = new HomeTheaterFacade(projector, soundSystem, dvdPlayer);

            Console.WriteLine("Enter the movie name:");
            string movie = Console.ReadLine();

            if (!string.IsNullOrEmpty(movie))
            {
                homeTheater.WatchMovie(movie);
                homeTheater.EndMovie();
            }
            else
            {
                Console.WriteLine("No movie name entered. Exiting...");
            }
        }
    }
}