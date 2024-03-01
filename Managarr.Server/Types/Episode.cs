namespace Managarr.Server.Types
{
    public class Episode
    {
        public int id { get; set; }
        public string? title { get; set; }
        public int episodeNumber { get; set; }
        public bool monitored { get; set; }
        public int tvdbId { get; set; }
        public int airDateUtc { get; set; }
        public bool searched { get; set; }
        public bool isRequest { get; set; }
        public bool upgrade { get; set; }
        public bool isAvailable { get; set; }
        public bool hasFile { get; set; }
        public int minCustomFormatScore { get; set; }
        public ICollection<MediaFile> episodeFiles { get; set; }
        public string instanceName { get; set; }
        public Episode()
        {
            this.episodeFiles = [];
        }

        public Episode(int id, string title, int seasonNumber, int episodeNumber, bool monitored, int tvdbId, int airDateUtc, bool searched, bool isRequest, bool upgrade, bool isAvailable, bool hasFile, int minCustomFormatScore, ICollection<MediaFile> episodeFiles, string instanceName)
        {
            this.id = id;
            this.title = title;
            this.episodeNumber = episodeNumber;
            this.monitored = monitored;
            this.tvdbId = tvdbId;
            this.airDateUtc = airDateUtc;
            this.searched = searched;
            this.isRequest = isRequest;
            this.upgrade = upgrade;
            this.isAvailable = isAvailable;
            this.hasFile = hasFile;
            this.minCustomFormatScore = minCustomFormatScore;
            this.episodeFiles = episodeFiles;
            this.instanceName = instanceName;
        }
    }
}
