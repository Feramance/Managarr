namespace Managarr.Server.Types
{
    public class MediaFile
    {
        public int movieFileId { get; set; }
        public bool qualityMet { get; set; }
        public bool customFormatMet { get; set; }
        public int customFormatScore { get; set; }

        public MediaFile() { }

        public MediaFile(int movieFileId, bool qualityMet, bool customFormatMet, int customFormatScore)
        {
            this.movieFileId = movieFileId;
            this.qualityMet = qualityMet;
            this.customFormatMet = customFormatMet;
            this.customFormatScore = customFormatScore;
        }
    }
}
