using System.Security.Policy;
using System.Text.RegularExpressions;

namespace Managarr.Server.Types
{
    public class Arrs
    {
        //--------------------------------------------------------------- General
        public string name { get; set; }
        public Uri url { get; set; }
        public string apiKey { get; set; }
        public bool enabled { get; set; }
        public string category { get; set; }
        public bool reSearch { get; set; }
        public ImportMode importMode { get; set; }
        public TimeSpan rssSyncTimer { get; set; }
        public TimeSpan refreshDownloadsTimer { get; set; }
        public ICollection<string> errorCodeBlocklist { get; set; }
        //--------------------------------------------------------------- Entry Search
        public bool searchMissing { get; set; }
        public bool alsoSearrchSpecials { get; set; }
        public int searchLimit { get; set; }
        public bool searchByYear { get; set; }
        public bool searchInReverse { get; set; }
        public TimeSpan requestSearchTimer { get; set; }
        public bool upgradeSearch { get; set; }
        public bool qualityUnmetSearch { get; set; }
        public bool customFormatUnmetSearch { get; set; }
        public bool searchBySeries { get; set; }
        public bool priorotiseTodaysReleases { get; set; }
        public ICollection<RequestService> requestServices { get; set; }
        //--------------------------------------------------------------- Torrent Handling
        public bool caseSensitiveMatches { get; set; }
        public ICollection<Regex> folderExclusions { get; set; }
        public ICollection<Regex> filenameExclusions { get; set; }
        public ICollection<Regex> fileExtensionAllow { get; set; }
        public bool autoDeleteUnplayable { get; set; }
        public int ignoreTorrentsYoungerThan { get; set; }
        public int maximumETA { get; set; }
        public float maxDeletablePercentage { get; set; }
        public bool removeSlow { get; set; }
        //--------------------------------------------------------------- Seeding Handling
        public int downLimitPerTorrent { get; set; }
        public int upLimitPerTorrent { get; set; }
        public int maxUploadRatio { get; set; }
        public int maxSeedingTime { get; set; }
        public bool removeDeadTrackers { get; set; }
        public ICollection<string> removeTrackerMessages { get; set; }
        //--------------------------------------------------------------- Trackers
        public ICollection<Trackers> trackers { get; set; }

        public Arrs()
        {
            errorCodeBlocklist = [];
            requestServices = [];
            folderExclusions = [];
            filenameExclusions = [];
            fileExtensionAllow = [];
            removeTrackerMessages = [];
        }

        public Arrs(string name, Uri url, string apiKey, bool enabled, string category, bool reSearch, ImportMode importMode, TimeSpan rssSyncTimer, TimeSpan refreshDownloadsTimer, ICollection<string> errorCodeBlocklist, bool searchMissing, bool alsoSearrchSpecials, int searchLimit, bool searchByYear, bool searchInReverse, TimeSpan requestSearchTimer, bool upgradeSearch, bool qualityUnmetSearch, bool customFormatUnmetSearch, bool searchBySeries, bool priorotiseTodaysReleases, ICollection<RequestService> requestServices, bool caseSensitiveMatches, ICollection<Regex> folderExclusions, ICollection<Regex> filenameExclusions, ICollection<Regex> fileExtensionAllow, bool autoDeleteUnplayable, int ignoreTorrentsYoungerThan, int maximumETA, float maxDeletablePercentage, bool removeSlow, int downLimitPerTorrent, int upLimitPerTorrent, int maxUploadRatio, int maxSeedingTime, bool removeDeadTrackers, ICollection<string> removeTrackerMessages, ICollection<Trackers> trackers)
        {
            this.name = name;
            this.url = url;
            this.apiKey = apiKey;
            this.enabled = enabled;
            this.category = category;
            this.reSearch = reSearch;
            this.importMode = importMode;
            this.rssSyncTimer = rssSyncTimer;
            this.refreshDownloadsTimer = refreshDownloadsTimer;
            this.errorCodeBlocklist = errorCodeBlocklist;
            this.searchMissing = searchMissing;
            this.alsoSearrchSpecials = alsoSearrchSpecials;
            this.searchLimit = searchLimit;
            this.searchByYear = searchByYear;
            this.searchInReverse = searchInReverse;
            this.requestSearchTimer = requestSearchTimer;
            this.upgradeSearch = upgradeSearch;
            this.qualityUnmetSearch = qualityUnmetSearch;
            this.customFormatUnmetSearch = customFormatUnmetSearch;
            this.searchBySeries = searchBySeries;
            this.priorotiseTodaysReleases = priorotiseTodaysReleases;
            this.requestServices = requestServices;
            this.caseSensitiveMatches = caseSensitiveMatches;
            this.folderExclusions = folderExclusions;
            this.filenameExclusions = filenameExclusions;
            this.fileExtensionAllow = fileExtensionAllow;
            this.autoDeleteUnplayable = autoDeleteUnplayable;
            this.ignoreTorrentsYoungerThan = ignoreTorrentsYoungerThan;
            this.maximumETA = maximumETA;
            this.maxDeletablePercentage = maxDeletablePercentage;
            this.removeSlow = removeSlow;
            this.downLimitPerTorrent = downLimitPerTorrent;
            this.upLimitPerTorrent = upLimitPerTorrent;
            this.maxUploadRatio = maxUploadRatio;
            this.maxSeedingTime = maxSeedingTime;
            this.removeDeadTrackers = removeDeadTrackers;
            this.removeTrackerMessages = removeTrackerMessages;
            this.trackers = trackers;
        }
    }
}
