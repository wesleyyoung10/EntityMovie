using Movies.DataContext;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new MovieContext();

      

            var movie1 = new Movie
            {
                Title = "Star Wars",
                YearReleased = 1977,
                Genre = "Sci-fi",
                Tagline = "A long time ago in a galaxy far far away....",
                Rating = 10
            };
            db.Movies.Add(movie1);
            db.SaveChanges();

            var h1 = new Movie
            {
                Title = "Indiana Jones",
                YearReleased = 1988,
                Genre = "Adventure",
                Tagline = "Raiders of the Lost Ark",
                Rating = 9
            };
            db.Movies.Add(h1);
            db.SaveChanges();

            var h2 = new Movie
            {
                Title = "The Neverending Story",
                YearReleased = 2016,
                Genre = "Horror",
                Tagline = "Not actually horror",
                Rating = 8
            };
            db.Movies.Add(h2);
            db.SaveChanges();

            var movies = db.Movies.ToList();

            Console.WriteLine("Printing movies");
            Console.WriteLine("Printing 1988 Movies with new rating of 10");

            foreach (var movie in movies)
            {
                Console.WriteLine(movie.Title + " - " + movie.YearReleased + " - " + movie.Rating);
            }

            Update1988Movies();
            DeleteMovie("The Neverending Story");
            var horrormovies = FindAllHorrorMovies();

            foreach (var movie in horrormovies)
            {
                Console.WriteLine(movie.Title + " - " + movie.YearReleased + " - " + movie.Rating);
            }

            Console.ReadLine();

            
        } 
           

        private static void Update1988Movies()
        {
            var db = new MovieContext();

            var movies = db.Movies.Where(m => m.YearReleased == 1988);

            foreach (var movie in movies)
            {
                movie.Rating = 10; 
            }
            db.SaveChanges();
        }

        private static void DeleteMovie(string title)
        {
            var db = new MovieContext();

            var movie = db.Movies.Where(m => m.Title == title).FirstOrDefault();

            db.Movies.Remove(movie);

            db.SaveChanges();
        }
        private static List<Movie> FindAllHorrorMovies()
        {
            var db = new MovieContext();

            var movies = db.Movies.Where(m => m.Genre == "Horror").ToList();

            return movies;

        }     

            
    }
}
