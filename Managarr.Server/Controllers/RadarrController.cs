using Managarr.Server.APIs;
using Managarr.Server.APIs.Resources;
using Managarr.Server.Types;
using Microsoft.AspNetCore.Mvc;

namespace Managarr.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RadarrController : ControllerBase
    {
        List<Radarr> radarrs;
        List<Movies> movies;

        private readonly ILogger<RadarrController> _logger;

        public RadarrController(ILogger<RadarrController> logger)
        {
            _logger = logger;
            radarrs = new List<Radarr>();
            movies = new List<Movies>();
            radarrs.Add(new Radarr("http://192.168.0.172:7878", "6f55c4d4ba984306b4750bf4825747dd"));
            for (int i = 0; i < radarrs.Count; i++)
            {
                radarrs[i].Initialise();
            }
        }

        [HttpGet(Name = "GetMoviesList")]
        public IEnumerable<MovieResource> Get()
        {
            return 
        }
    }
}
