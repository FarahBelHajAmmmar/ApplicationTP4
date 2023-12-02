using ApplicationTP4.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationTP4.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetMoviesByGenre(string genreName)
        {
            var movies = _movieService.GetMoviesByGenre(genreName);
            return View(movies);
        }
        public IActionResult GetMovieord()
        {
            var movies = _movieService.GetMovieord();

            return View(movies);
        }
        [HttpGet]
        public IActionResult GetMoviesByID(int id)
        {
            var movies = _movieService.GetMoviesByID( id);
            return View(movies);
        }
    }
}
