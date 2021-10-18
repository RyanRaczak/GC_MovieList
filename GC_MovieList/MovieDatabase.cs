using System;
using System.Collections.Generic;
using System.Text;

namespace GC_MovieList
{
    class MovieDatabase
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public MovieDatabase()
        {
            //Populating Database
            Movies.Add(new Movie("Wall-E", "Animated"));
            Movies.Add(new Movie("Godfather", "Drama"));
            Movies.Add(new Movie("Interstellar", "Scifi"));
            Movies.Add(new Movie("Pulp Fiction", "Drama"));
            Movies.Add(new Movie("Jurassic Park", "Scifi"));
            Movies.Add(new Movie("The Strangers", "Horror"));
            Movies.Add(new Movie("Big Hero 6", "Animated"));
            Movies.Add(new Movie("Paranormal Activity", "Horror"));
            Movies.Add(new Movie("The Departed", "Drama"));
            Movies.Add(new Movie("Cabin in the Woods", "Horror"));
        }

        public string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        public void DisplayMovies(int input)
        {
            //Takes the input and assigns a category.
            List<string> sortedMovies = new List<string>();
            string category = "";
            switch (input)
            {
                case 1:
                    category = "Animated";
                    break;
                case 2:
                    category = "Scifi";
                    break;
                case 3:
                    category = "Horror";
                    break;
                case 4:
                    category = "Drama";
                    break;
                default:
                    break;
            }
            //Using assigned category, searches the list
            //And adds any matches to a list of strings
            for (int i = 0; i < Movies.Count; i++)
            {
                if (Movies[i].Category.Equals(category))
                {
                    sortedMovies.Add(Movies[i].Title);
                }
            }

            //Sorts the list
            sortedMovies.Sort();

            //Prints the sorted list
            Console.WriteLine($"\nTitle\t\tGenre: {category}" +
                $"\n===============================");
            foreach (var item in sortedMovies)
            {
                Console.WriteLine(item);
            }
        }
        public int DisplayMenu()
        {
            //Loops menu until valid input is detected.
            //Then calls the DisplayMovies method
            string input;
            int num;
            while (true)
            {
                input = GetInput("\n::Please a category from the menu::\n" +
                "\n::MENU::" +
                "\n1) Animated" +
                "\n2) Scifi" +
                "\n3) Horror" +
                "\n4) Drama" +
                "\n5) Exit" +
                "\n:: ");
                try
                {
                    num = int.Parse(input);
                    if (num >= 1 && num <= 5)
                    {
                        return num;
                    }
                    else
                    {
                        Console.WriteLine("\n~Invalid Input: Please select a number from the menu~");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\n~Invalid Input: Please select a number from the menu~");
                }
            }
        }
    }
}
