namespace Managarr.Server.Types
{
    public class Season
    {
        public int seasonNumber { get; set; }
        public ICollection<Episode> episodes { get; set; }

        public Season()
        {
            episodes = [];
        }

        public Season(int seasonNumber, ICollection<Episode> episodes)
        {
            this.seasonNumber = seasonNumber;
            this.episodes = episodes;
        }
    }
}
