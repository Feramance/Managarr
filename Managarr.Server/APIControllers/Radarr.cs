using Newtonsoft.Json.Linq;
using Managarr.Server.Types;
using Managarr.Server.APIs;

namespace Managarr.Server.APIControllers
{
    public class Radarr
    {
        public List<RadarrAPI> radarrApis { get; set; }
        public Radarr(List<RadarrAPI> radarrAPIs)
        {
            radarrApis = radarrAPIs;
            Initialise();
        }

        public void Initialise()
        {
            foreach (RadarrAPI r in  radarrApis)
            {
                if (r.Movies == null || r.Movies.Count == 0)
                {
                    r.Movies = new List<Movie>();
                    InitialiseDatabase(r);
                }
            }
        }
        public void InitialiseDatabase(RadarrAPI radarr)
        {
            JArray movieResources = radarr.GetMoviesJson().Result;
            foreach (JObject m in movieResources)
            {
                Movie movie = new Movie();
                movie.Id = (int)m.GetValue("id");
                movie.Title = (string)m.GetValue("title");
                movie.Monitored = (bool)m.GetValue("monitored");
                movie.TmdbId = (int)m.GetValue("tmdbId");
                movie.Year = (int)m.GetValue("year");
                movie.Searched = false;
                movie.IsRequest = false;
                movie.Upgrade = false;
                movie.IsAvailable = (bool)m.GetValue("isAvailable");
                if ((bool)m.GetValue("hasFile"))
                {
                    JArray files = radarr.GetMovieFile(id: movie.Id).Result;
                    foreach (JObject f in files)
                    {
                        MovieFile movieFile = new MovieFile();
                        movieFile.MovieFileId = (int)f.GetValue("id");
                        movieFile.QualityMet = (bool)f.GetValue("qualityCutoffNotMet");
                        movieFile.CustomFormatScore = (int)f.GetValue("customFormatScore");
                        JObject quality = radarr.GetQualityProfile((int)m.GetValue("qualityProfileId")).Result;
                        if (movieFile.CustomFormatScore >= (int)quality.GetValue("minFormatScore"))
                        {
                            movieFile.CustomFormatMet = true;
                        }
                        else
                        {
                            movieFile.CustomFormatMet = false;
                        }
                        movie.MovieFiles.Add(movieFile);
                    }
                }
                else
                {
                    MovieFile movieFile = new MovieFile();
                    movieFile.MovieFileId = 0;
                    movieFile.CustomFormatScore = 0;
                    movieFile.QualityMet = false;
                    movieFile.CustomFormatMet = false;
                    movie.MovieFiles.Add(movieFile);
                }
                movie.InstanceName = radarr.Name;
                movie.Hash = movie.Id+"-"+movie.InstanceName;
                radarr.Movies.Add(movie);
            }
        }

        internal void UpdateMovie(Movie movie)
        {
            Movie existingMovie = (Movie)Movies.Where(x => x.Hash == movie.Hash);
            var index = Movies.IndexOf(existingMovie);
            Movies[index] = movie;
        }

        internal Movie GetMovie(string hash)
        {
            return (Movie)Movies.Where(x => x.Hash == hash);
        }
    }
}
