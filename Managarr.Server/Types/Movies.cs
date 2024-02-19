namespace Managarr.Server.Types
{
    public class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Monitored { get; set; }
        public int TmdbId { get; set; }
        public int Year { get; set; }
        public bool Searched { get; set; }
        public int MovieFileId { get; set; }
        public bool IsRequest { get; set; }
        public bool QualityUnmet { get; set; }
        public bool CustomFOrmatMet { get; set; }
        public bool Upgrade { get; set; }
        public int CustomFormatScore { get; set; }
    }
}
