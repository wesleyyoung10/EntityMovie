using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies.Models;

namespace Movies.DataContext
{
    class MovieContext : DbContext
    {

        public MovieContext() : base(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=NewMoviesDatabase;Integrated Security=True")
        {

        }

        public DbSet<Movie> Movies { get; set; }

        internal void DeleteMovie()
        {
            throw new NotImplementedException();
        }
    }
}