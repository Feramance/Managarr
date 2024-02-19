using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using Managarr.Server.APIs.Resources;
using Managarr.Server.Types;

namespace Managarr.Server.APIs
{
    public class Radarr
    {
        string apiBase;
        RestClient client;
        public List<MovieResource> MovieResources { get; set; }
        public List<Movies> Movies { get; set; }
        public Radarr(string url, string apiKey)
        {
            client = new RestClient(url);
            client.AddDefaultQueryParameter("apikey", apiKey);
            var request = new RestRequest("api");
            var response = client.Get(request);
            JObject data = JsonConvert.DeserializeObject<JObject>(response.Content);
            apiBase = "api/" + data.Value<string>("current") + "/";
        }

        public bool Initialise()
        {
            if (MovieResources == null || MovieResources.Count == 0)
            {
                MovieResources = GetMovies().Result;
            }

            return true;
        }

        public async Task<MovieResource> GetMovie(int id = -1, int tmdbid = -1)
        {
            var request = new RestRequest(apiBase + "movie");
            if (id == -1 & tmdbid == -1)
            {
            }
            else if (id != -1)
            {
                request = new RestRequest(apiBase + "movie/" + id);
            }
            else if (tmdbid != -1)
            {
                request.AddQueryParameter("tmdbid", tmdbid);
            }
            var response = await client.GetAsync(request);
            var movieResource = JsonConvert.DeserializeObject<MovieResource>(response.Content.Trim());
            return movieResource;
        }
        public async Task<List<MovieResource>> GetMovies()
        {
            var request = new RestRequest(apiBase + "movie");
            var response = await client.GetAsync(request);
            var movieResources = JsonConvert.DeserializeObject<List<MovieResource>>(response.Content.Trim());
            return movieResources;
        }
    }
}
