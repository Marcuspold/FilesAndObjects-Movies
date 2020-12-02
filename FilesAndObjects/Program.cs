using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FilesAndObjects
{
    class Program
    {
        class Movie
        {
            public string title;
            public string rating;
            public string year;


            public Movie(string _title, string _rating, string _year)
            {
                title = _title;
                rating = _rating;
                year = _year;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sir Yes Sir!!!!");
            string filePath = @"C:\Users\opilane\Samples";
            string fileName = @"imdb.txt";
            //a list to store the movies from the file
            List<string> movielist = File.ReadAllLines(Path.Combine(filePath, fileName)).ToList();
            List<Movie> listOfMovies = new List<Movie>();

            foreach (string movieItem in movielist)
            {
                string[] temparray = movieItem.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                Movie newMovie = new Movie(temparray[0], temparray[1], temparray[2]);

                listOfMovies.Add(newMovie);
            }
            foreach(Movie movie in listOfMovies)
            {
                Console.WriteLine($"Title: {movie.title}: Rating: {movie.rating}; Year: {movie.year}");
            }
            Console.WriteLine("What is your favorite movie? ENTER NOW OR BE TERMINATED");
            string FavMovieTitle = Console.ReadLine();
            Console.WriteLine("Enter yout favorite movie rating");
            string FavMovieRating = Console.ReadLine();
            Console.WriteLine("Enter the Release Year ");
            string FavMovieYear = Console.ReadLine();

            Movie FavMovie = new Movie(FavMovieTitle, FavMovieRating, FavMovieYear);
            string FavMovieLine = $"{FavMovie.title};{FavMovie.rating};{FavMovie.year}";

            movielist.Add(FavMovieLine);
            File.WriteAllLines(Path.Combine(filePath, fileName), movielist);

        }
    }
}
