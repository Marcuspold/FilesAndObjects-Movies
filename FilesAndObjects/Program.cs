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
        }
    }
}
