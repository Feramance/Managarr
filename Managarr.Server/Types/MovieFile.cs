namespace Managarr.Server.Types
{
    public class MovieFile
    {
        public int MovieFileId { get; set; }
        public bool QualityMet { get; set; }
        public bool CustomFormatMet { get; set; }
        public int CustomFormatScore { get; set; }

        public MovieFile() { }

        public MovieFile(int movieFileId, bool qualityMet, bool customFormatMet, int customFormatScore)
        {
            MovieFileId = movieFileId;
            QualityMet = qualityMet;
            CustomFormatMet = customFormatMet;
            CustomFormatScore = customFormatScore;
        }
    }
}
