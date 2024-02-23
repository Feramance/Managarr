using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Managarr.Server.Types;

namespace Managarr.Server.APIs
{
    public class RadarrAPI
    {
        public string Name;
        public List<Movie> Movies { get; set; }
        string APIBase;
        RestClient client;
        public RadarrAPI(string url, string apiKey, string name)
        {
            this.Name = name;
            client = new RestClient(url);
            client.AddDefaultHeader("X-Api-Key", apiKey);
            var request = new RestRequest("api");
            var response = client.Get(request);
            JObject data = JsonConvert.DeserializeObject<JObject>(response.Content);
            APIBase = "api/" + data.Value<string>("current") + "/";
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
