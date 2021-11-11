using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList
{
   public class MovieDatabse
    {
        //The main job of this class is to manage a list of Movie objects
        public List<Movie> movies { get; set; } = new List<Movie>();

        //This is the constructor, it matches the class name
        public MovieDatabse()
        {
            movies.Add(new Movie("Star Wars", "scifi"));
            movies.Add(new Movie("Annabelle", "horror"));
            movies.Add(new Movie("A Clockwork Orange", "scifi"));
            movies.Add(new Movie("E.T. The Extra-terrestrial", "scifi"));
            movies.Add(new Movie("Minions", "animated"));
            movies.Add(new Movie("Halloween Kills", "horror"));
            movies.Add(new Movie("The Guilty", "drama"));
            movies.Add(new Movie("The bridges of Madison county", "drama"));
            movies.Add(new Movie("Frozen", "animated"));
            movies.Add(new Movie("Conjuring", "horror"));            
        }
       
        public string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            return input;
        }  
        
        
        //A method to search the movies based on a category and print the movies
        public string SearchByCategory(List<Movie> movies, string name)
        {
            //using this string to return output and replaced Console.Write and ReadLine with the output variable.
            string output = "";
            for (int i = 0; i < movies.Count; i++)
            {
                Movie mv = movies[i];
                if (mv.category.ToLower() == name.ToLower())
                {
                    //adding a new line
                    output += (mv.title + "\n");
                }                               
            }
           output += ("\nPlease enter a valid category. scifi/drama/animated/horror");

            return output;
        }      
    }
}
