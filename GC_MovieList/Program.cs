using System;

namespace GC_MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieDatabase movieDatabase = new MovieDatabase();
            int selection;
            while (true)
            {
                selection = movieDatabase.DisplayMenu();
                if (selection == 5)
                {
                    Console.WriteLine("\n::GOODBYE::");
                    break;
                }
                else
                {
                    movieDatabase.DisplayMovies(selection);
                }
            }

        }
    }
}
