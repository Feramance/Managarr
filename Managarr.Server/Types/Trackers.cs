namespace Managarr.Server.Types
{
    public class Trackers
    {
        public string name { get; set; }
        public Uri url { get; set; }
        public int priority { get; set; }
        public int maximumETA { get; set; }
        public int downLimitPerTorrent { get; set; }
        public int upLimitPerTorrent { get; set; }
        public int maxUploadRatio { get; set; }
        public int maxSeedingTime { get; set; }
        public bool addTrackerIfMissing { get; set; }
        public bool removeTrackerIfExists { get; set; }
        public bool superSeed { get; set; }
        public List<string> addtags { get; set; }

        public Trackers()
        {
            addtags = [];
        }

        public Trackers(string name, Uri url, int priority, int maximumETA, int downLimitPerTorrent, int upLimitPerTorrent, int maxUploadRatio, int maxSeedingTime, bool addTrackerIfMissing, bool removeTrackerIfExists, bool superSeed, List<string> addtags)
        {
            this.name = name;
            this.url = url;
            this.priority = priority;
            this.maximumETA = maximumETA;
            this.downLimitPerTorrent = downLimitPerTorrent;
            this.upLimitPerTorrent = upLimitPerTorrent;
            this.maxUploadRatio = maxUploadRatio;
            this.maxSeedingTime = maxSeedingTime;
            this.addTrackerIfMissing = addTrackerIfMissing;
            this.removeTrackerIfExists = removeTrackerIfExists;
            this.superSeed = superSeed;
            this.addtags = addtags;
        }
    }
}