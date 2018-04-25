using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Controllers
{
    public class MovieController : ApiController
    {
        [HttpGet]
        [Route("api/movies/findallmovies")]
        public List<MovieViewModel> FindAllMovies()
        {
            var db = new DataContext();

            Select(b => new MovieViewModel
            {
                Id = b.Id,
                BookName = b.Title,
                YearPublished = b.YearPublished,
                AuthorName = b.Author.Name,
                GenreName = b.Genre.Name,
                IsCheckedOut = b.IsCheckedOut
            }).ToList();

            return movie;
        }
    }
}
