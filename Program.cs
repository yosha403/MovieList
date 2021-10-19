using System;


//DevBuild Lab : Movie List
//Author: Yosha Kunnummal
//Date: 10/18/2021

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieDatabse MovieDb = new MovieDatabse();

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine();
            Console.WriteLine("There are 10 movies in this list.");
            bool goOn = true;
            while (goOn)
            {
                try
                {                    
                    string category = MovieDb.GetUserInput("What category are you interested in? ");
                    Console.WriteLine();

                    MovieDb.SearchByCategory(MovieDb.movies, category);
                    goOn = Continue();
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);                   
                }
            }
        }

        //A method to continue the application
        public static bool Continue()
        {
            Console.Write("\nContinue? (y/n): ");
            string answer = Console.ReadLine().ToLower();

            if (answer.ToLower() == "y")
            {
                return true;
            }
            else if (answer.ToLower() == "n")
            {
                Console.WriteLine("Thanks!");
                return false;
            }
            else
            {
                Console.WriteLine("\nThis is not a valid selection. ");
                Console.WriteLine("Please try again!");

                //This is recursion, calling a method inside itself
                return Continue();
            }
        }
    }
}
