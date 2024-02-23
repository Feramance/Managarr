namespace Managarr.Server.Types
{
    public class Movie
    {
        public string? Hash { get; set; }
        public int Id { get; set; }
        public string? Title { get; set; }
        public bool Monitored { get; set; }
        public int TmdbId { get; set; }
        public int Year { get; set; }
        public bool Searched { get; set; }
        public bool IsRequest { get; set; }
        public bool Upgrade { get; set; }
        public bool IsAvailable { get; set; }
        public List<MovieFile> MovieFiles { get; set; }
        public string InstanceName { get; set; }
        public Movie()
        {
            this.MovieFiles = new List<MovieFile>();
        }

        public Movie(string hash, int id, string title, bool monitored, int tmdbId, int year, bool searched, bool isRequest, bool upgrade, bool available, List<MovieFile> movieFiles, string instanceName)
        {
            this.Hash = hash;
            this.Id = id;
            this.Title = title;
            this.Monitored = monitored;
            this.TmdbId = tmdbId;
            this.Year = year;
            this.Searched = searched;
            this.IsRequest = isRequest;
            this.Upgrade = upgrade;
            this.IsAvailable = available;
            this.MovieFiles = movieFiles;
            this.InstanceName = instanceName;
        }
    }
}
