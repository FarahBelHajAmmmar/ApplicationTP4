using ApplicationTP4.Models.Repositories;
namespace ApplicationTP4.Models.Services
{ 
	public interface IMovieService
{
	IEnumerable<Movies> GetMoviesByGenre(string genreName);
	IEnumerable<Movies> GetMovieord();
	IEnumerable<Movies> GetMoviesByID(int id);
}


	public class MovieService : IMovieService
	{
		private readonly IMovieRepository _movieRepository;

		public MovieService(IMovieRepository movieRepository)
		{
			_movieRepository = movieRepository;
		}

		public IEnumerable<Movies> GetMoviesByGenre(string genreName)
		{
			// Récupérer l'ID du genre par le nom en utilisant le repository
			var genre = _movieRepository.GetAllGenres()
				.FirstOrDefault(g => g.GenreName == genreName);


			// Récupérer les films par genre ID en utilisant le repository
			return _movieRepository.GetAllMoviesByGenre(genre.Id);
		}
		public IEnumerable<Movies> GetMovieord()
		{
			return _movieRepository.GetAllord();
		}
        public IEnumerable<Movies> GetMoviesByID(int id)
        {
            /*var movies = _movieRepository.GetAll()
                .Where(g => g.genres_Id == id)
                .ToList();

            return movies;*/
            return _movieRepository.GetAllMoviesByGenre(id);

        }


    }
}