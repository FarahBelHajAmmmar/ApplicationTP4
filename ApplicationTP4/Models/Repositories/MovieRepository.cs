using ApplicationTP4_.Models;

namespace ApplicationTP4.Models.Repositories
{

    public interface IMovieRepository
    {
		IEnumerable<Movies> GetAll();
		IEnumerable<Genres> GetAllGenres(); // Ajout de la méthode pour récupérer tous les genres
		
		IEnumerable<Movies> GetAllMoviesByGenre(int genreId); // Ajout de la méthode pour récupérer les films par ID de genre
		IEnumerable<Movies> GetAllord();
	}

    public class MovieRepository: IMovieRepository

    {
        private readonly ApplicationDbContext _db;
        public MovieRepository(ApplicationDbContext db)
        {
            _db = db;
        }

		public IEnumerable<Movies> GetAll()
		{
			return _db.Movies.ToList();
		}
		public IEnumerable <Movies> GetAllord()
		{
			return _db.Movies.OrderBy(movie => movie.Name).ToList();
		}

		public IEnumerable<Genres> GetAllGenres()
		{
			return _db.Genres.ToList();
		}

		public IEnumerable<Movies> GetAllMoviesByGenre(int genreId)
		{
			return _db.Movies.Where(movie => movie.genres_Id == genreId).ToList();
		}

	}
   
}
