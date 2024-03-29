﻿namespace Managarr.Server.Types
{
    public class Movie
    {
        public int id { get; set; }
        public string? title { get; set; }
        public bool monitored { get; set; }
        public int tmdbId { get; set; }
        public int year { get; set; }
        public bool searched { get; set; }
        public bool isRequest { get; set; }
        public bool upgrade { get; set; }
        public bool isAvailable { get; set; }
        public bool hasFile { get; set; }
        public int minCustomFormatScore { get; set; }
        public ICollection<MediaFile> movieFiles { get; set; }
        public string instanceName { get; set; }
        public Movie()
        {
            this.movieFiles = [];
        }

        public Movie(int id, string title, bool monitored, int tmdbId, int year, bool searched, bool isRequest, bool upgrade, bool isAvailable, bool hasFile, int minCustomFormatScore, ICollection<MediaFile> movieFiles, string instanceName)
        {
            this.id = id;
            this.title = title;
            this.monitored = monitored;
            this.tmdbId = tmdbId;
            this.year = year;
            this.searched = searched;
            this.isRequest = isRequest;
            this.upgrade = upgrade;
            this.isAvailable = isAvailable;
            this.hasFile = hasFile;
            this.minCustomFormatScore = minCustomFormatScore;
            this.movieFiles = movieFiles;
            this.instanceName = instanceName;
        }
    }
}
