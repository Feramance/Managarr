namespace Managarr.Server.Types
{
    public class Series
    {
        public int id { get; set; }
        public string? title { get; set; }
        public int tvdbId { get; set; }
        public bool monitored { get; set; }
        public bool searched { get; set; }
        public int minCustomFormatScore { get; set; }
        public ICollection<Season> seasons { get; set; }
        public string? instanceName { get; set; }

        public Series()
        {
            seasons = [];
        }

        public Series(int id, string? title, int tvdbId, bool monitored, bool searched, int minCustomFormatScore, ICollection<Season> seasons, string? instanceName)
        {
            this.id = id;
            this.title = title;
            this.tvdbId = tvdbId;
            this.monitored = monitored;
            this.searched = searched;
            this.minCustomFormatScore = minCustomFormatScore;
            this.seasons = seasons;
            this.instanceName = instanceName;
        }
    }
}
