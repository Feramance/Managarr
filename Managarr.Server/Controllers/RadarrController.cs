using Managarr.Server.APIControllers;
using Managarr.Server.APIs;
using Managarr.Server.Types;
using Microsoft.AspNetCore.Mvc;

namespace Managarr.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RadarrController : ControllerBase
    {
        private List<RadarrAPI> radarrapis;
        private Radarr radarr;
        private List<Movie> movies;

        private readonly ILogger<RadarrController> _logger;

        public RadarrController(ILogger<RadarrController> logger)
        {
            _logger = logger;
            radarrapis =
            [
                new RadarrAPI(new Uri("http://192.168.0.172:7878"), "6f55c4d4ba984306b4750bf4825747dd", "Radarr"),
                new RadarrAPI(new Uri("http://192.168.0.172:7879"), "111cd69da1544173b0b95ed451fef632", "Radarr4K"),
            ];
            radarr = new Radarr(radarrapis);
        }

        [HttpGet("movies", Name = "GetMovies")]
        public IEnumerable<Movie> GetMovies(string instance = null)
        {
            List<Movie> movies = new List<Movie>();
            if (!string.IsNullOrEmpty(instance))
            {
                movies = radarr.radarrApis.FirstOrDefault(r => r.Name == instance).Movies;
            }
            else
            {
                foreach (RadarrAPI r in radarr.radarrApis)
                {
                    if (r.Movies != null || r.Movies.Count != 0)
                    {
                        movies.AddRange(r.Movies);
                    }
                }
            }
            foreach (Movie movie in movies)
            {
                yield return movie;
            }
        }

        [HttpGet("movie", Name = "GetMovie")]
        public IActionResult GetMovie(string instance, int id)
        {
            Movie movie = radarr.GetMovie(instance, id);
            return movie == null? NotFound() : Ok(movie);
        }

        [HttpPut("{instanceName}/{id}", Name = "UpdateMovie")]
        public IActionResult UpdateMovie(string instanceName, int id, Movie movie)
        {
            if (id != movie.id)
            {
                return BadRequest();
            }

            Movie existingMovie = radarr.GetMovie(instanceName, id);
            if (existingMovie is null)
            {
                return NotFound();
            }

            radarr.UpdateMovie(instanceName, id, existingMovie);

            return Ok(existingMovie);
        }
    }
}
