namespace Managarr.Server.Types
{
    public class Settings
    {
        public string logLevel { get; set; }
        public string completedDownloadFolder { get; set; }
        public float freeSpace { get; set; }
        public TimeSpan noInternetSleepTimer { get; set; }
        public TimeSpan loopSleepTimer { get; set;}
        public TimeSpan searchLoopDelay { get; set; }
        public string failedCategory { get; set; }
        public string recheckCategory { get; set; }
        public int ignoreTorrentsYoungerThan { get; set; }
        public ICollection<Uri> pingUrls { get; set; }

        public Settings()
        {
            pingUrls = [];
        }
    }
}
