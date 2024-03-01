using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Managarr.Server.Types;
using System.Security.Policy;

namespace Managarr.Server.APIs
{
    public class RadarrAPI
    {
        public string Name;
        public List<Movie> Movies { get; set; }
        string APIBase;
        RestClient client;
        public RadarrAPI(Uri url, string apiKey, string name)
        {
            this.Name = name;
            Movies = new List<Movie>();
            client = new RestClient(url);
            client.AddDefaultHeader("X-Api-Key", apiKey);
            var request = new RestRequest("api");
            var response = client.Get(request);
            JObject data = JsonConvert.DeserializeObject<JObject>(response.Content);
            APIBase = "api/" + data.Value<string>("current") + "/";
        }
        public void InitialiseDatabase()
        {
            JArray movieResources = GetMoviesJson().Result;
            foreach (JObject m in movieResources)
            {
                Movie movie = new Movie();
                movie.id = (int)m.GetValue("id");
                movie.title = (string)m.GetValue("title");
                movie.monitored = (bool)m.GetValue("monitored");
                movie.tmdbId = (int)m.GetValue("tmdbId");
                movie.year = (int)m.GetValue("year");
                movie.searched = false;
                movie.isRequest = false;
                movie.upgrade = false;
                movie.isAvailable = (bool)m.GetValue("isAvailable");
                if ((bool)m.GetValue("hasFile"))
                {
                    movie.hasFile = true;
                    JArray files = GetMovieFile(id: movie.id).Result;
                    foreach (JObject f in files)
                    {
                        MediaFile movieFile = new MediaFile();
                        movieFile.movieFileId = (int)f.GetValue("id");
                        movieFile.qualityMet = (bool)f.GetValue("qualityCutoffNotMet");
                        movieFile.customFormatScore = (int)f.GetValue("customFormatScore");
                        JObject quality = GetQualityProfile(id: (int)m.GetValue("qualityProfileId")).Result;
                        movie.minCustomFormatScore = (int)quality.GetValue("minFormatScore");
                        if (movieFile.customFormatScore >= (int)quality.GetValue("minFormatScore"))
                        {
                            movieFile.customFormatMet = true;
                        }
                        else
                        {
                            movieFile.customFormatMet = false;
                        }
                        movie.movieFiles.Add(movieFile);
                    }
                }
                else
                {
                    movie.hasFile = false;
                    MediaFile movieFile = new MediaFile();
                    movieFile.movieFileId = 0;
                    movieFile.customFormatScore = 0;
                    movieFile.qualityMet = false;
                    movieFile.customFormatMet = false;
                    movie.movieFiles.Add(movieFile);
                }
                movie.instanceName = Name;
                Movies.Add(movie);
            }
        }

        public async Task<JObject> GetMovie(int id = -1, int tmdbid = -1)
        {
            var request = new RestRequest(APIBase + "movie");
            if (id != -1)
            {
                request = new RestRequest(APIBase + "movie/" + id);
            }
            else if (tmdbid != -1)
            {
                request.AddQueryParameter("tmdbid", tmdbid);
            }
            else
            {
                return null;
            }
            var response = await client.GetAsync(request);
            var movie = JsonConvert.DeserializeObject<JObject>(response.Content.Trim());
            return movie;
        }
        public async Task<JArray> GetMoviesJson()
        {
            var request = new RestRequest(APIBase + "movie");
            var response = await client.GetAsync(request);
            var movies = JsonConvert.DeserializeObject<JArray>(response.Content.Trim());
            return movies;
        }

        public async Task<JArray> GetMovieFile(int id = -1, int fileid = -1)
        {
            var request = new RestRequest(APIBase + "moviefile");
            if (id != -1)
            {
                request.AddQueryParameter("movieId", id);
            }
            else if (fileid != -1)
            {
                request = new RestRequest(APIBase + "moviefile/" + id);
            }
            else
            {
                return null;
            }
            var response = await client.GetAsync(request);
            var movieFile = JsonConvert.DeserializeObject<JArray>(response.Content.Trim());
            return movieFile;
        }

        public async Task<JObject> GetQualityProfile(int id)
        {
            var request = new RestRequest(APIBase + "qualityprofile/" + id);
            var response = await client.GetAsync(request);
            var qualityProfile = JsonConvert.DeserializeObject<JObject>(response.Content.Trim());
            return qualityProfile;
        }
    }
}
