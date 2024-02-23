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
            radarrapis = new List<RadarrAPI>();
            movies = new List<Movie>();
            radarrapis.Add(new RadarrAPI("http://192.168.0.172:7878", "6f55c4d4ba984306b4750bf4825747dd", "Radarr"));
            radarrapis.Add(new RadarrAPI("http://192.168.0.172:7879", "111cd69da1544173b0b95ed451fef632", "Radarr4K"));
            radarr = new Radarr(radarrapis);
        }

        [HttpGet(Name = "GetMovies")]
        public IEnumerable<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>();
            foreach (RadarrAPI r in radarr.radarrApis)
            {
                movies.AddRange(r.Movies);
            }
            return movies;
        }

        [HttpGet("{hash}",Name = "GetMovie")]
        public IEnumerable<Movie> GetMovie(string hash)
        {
            Movie finalMovie = null;
            foreach (RadarrAPI r in radarr.radarrApis)
            {
                Movie movie = r.Movies.Where(r => r.Hash == hash).FirstOrDefault();
                if (movie.Hash == hash)
                {
                    finalMovie = movie;
                    break;
                }
            }
            yield return finalMovie;
        }

        [HttpPut("{hash}", Name = "UpdateMovie")]
        public IActionResult UpdateMovie(string hash, Movie movie)
        {
            if (hash != movie.Hash)
            {
                return BadRequest();
            }

            Movie existingMovie = radarr.GetMovie(hash);
            if (existingMovie is null)
            {
                return NotFound();
            }

            radarr.UpdateMovie(existingMovie);

            return Ok(existingMovie);
        }
    }
}
