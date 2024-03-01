using Managarr.Server.Types;
using Managarr.Server.APIs;

namespace Managarr.Server.APIControllers
{
    public class Radarr
    {
        public List<RadarrAPI> radarrApis { get; set; }
        public Radarr()
        {
            radarrApis = new List<RadarrAPI>();
        }
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
            radarr.InitialiseDatabase();
        }

        internal void AddInstance(RadarrAPI radarr)
        {
            radarrApis.Add(radarr);
            InitialiseDatabase(radarrApis.Last());
        }

        internal void UpdateMovie(string instanceName, int id, Movie movie)
        {
            RadarrAPI radarr = radarrApis.FirstOrDefault(r => r.Name == instanceName);
            Movie existingMovie = radarr.Movies.FirstOrDefault(x => x.id == id);
            var index = radarr.Movies.IndexOf(existingMovie);
            radarr.Movies[index] = movie;
        }

        internal Movie GetMovie(string instanceName, int id)
        {
            RadarrAPI radarr = radarrApis.FirstOrDefault(r => r.Name == instanceName);
            return radarr.Movies.FirstOrDefault(x => x.id == id);
        }
    }
}
