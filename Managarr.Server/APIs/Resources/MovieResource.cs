using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// MovieResource
    /// </summary>
    [DataContract]
    public partial class MovieResource : IEquatable<MovieResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MovieResource" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="title">title.</param>
        /// <param name="originalTitle">originalTitle.</param>
        /// <param name="originalLanguage">originalLanguage.</param>
        /// <param name="alternateTitles">alternateTitles.</param>
        /// <param name="secondaryYear">secondaryYear.</param>
        /// <param name="secondaryYearSourceId">secondaryYearSourceId.</param>
        /// <param name="sortTitle">sortTitle.</param>
        /// <param name="sizeOnDisk">sizeOnDisk.</param>
        /// <param name="status">status.</param>
        /// <param name="overview">overview.</param>
        /// <param name="inCinemas">inCinemas.</param>
        /// <param name="physicalRelease">physicalRelease.</param>
        /// <param name="digitalRelease">digitalRelease.</param>
        /// <param name="physicalReleaseNote">physicalReleaseNote.</param>
        /// <param name="images">images.</param>
        /// <param name="website">website.</param>
        /// <param name="remotePoster">remotePoster.</param>
        /// <param name="year">year.</param>
        /// <param name="youTubeTrailerId">youTubeTrailerId.</param>
        /// <param name="studio">studio.</param>
        /// <param name="path">path.</param>
        /// <param name="qualityProfileId">qualityProfileId.</param>
        /// <param name="hasFile">hasFile.</param>
        /// <param name="monitored">monitored.</param>
        /// <param name="minimumAvailability">minimumAvailability.</param>
        /// <param name="isAvailable">isAvailable.</param>
        /// <param name="folderName">folderName.</param>
        /// <param name="runtime">runtime.</param>
        /// <param name="cleanTitle">cleanTitle.</param>
        /// <param name="imdbId">imdbId.</param>
        /// <param name="tmdbId">tmdbId.</param>
        /// <param name="titleSlug">titleSlug.</param>
        /// <param name="rootFolderPath">rootFolderPath.</param>
        /// <param name="folder">folder.</param>
        /// <param name="certification">certification.</param>
        /// <param name="genres">genres.</param>
        /// <param name="tags">tags.</param>
        /// <param name="added">added.</param>
        /// <param name="addOptions">addOptions.</param>
        /// <param name="ratings">ratings.</param>
        /// <param name="movieFile">movieFile.</param>
        /// <param name="collection">collection.</param>
        /// <param name="popularity">popularity.</param>
        /// <param name="statistics">statistics.</param>
        public MovieResource(int? id = default, string title = default, string originalTitle = default, Language originalLanguage = default, List<AlternativeTitleResource> alternateTitles = default, int? secondaryYear = default, int? secondaryYearSourceId = default, string sortTitle = default, long? sizeOnDisk = default, MovieStatusType status = default, string overview = default, DateTime? inCinemas = default, DateTime? physicalRelease = default, DateTime? digitalRelease = default, string physicalReleaseNote = default, List<MediaCover> images = default, string website = default, string remotePoster = default, int? year = default, string youTubeTrailerId = default, string studio = default, string path = default, int? qualityProfileId = default, bool? hasFile = default, bool? monitored = default, MovieStatusType minimumAvailability = default, bool? isAvailable = default, string folderName = default, int? runtime = default, string cleanTitle = default, string imdbId = default, int? tmdbId = default, string titleSlug = default, string rootFolderPath = default, string folder = default, string certification = default, List<string> genres = default, List<int?> tags = default, DateTime? added = default, AddMovieOptions addOptions = default, Ratings ratings = default, MovieFileResource movieFile = default, MovieCollectionResource collection = default, float? popularity = default, MovieStatisticsResource statistics = default)
        {
            Id = id;
            Title = title;
            OriginalTitle = originalTitle;
            OriginalLanguage = originalLanguage;
            AlternateTitles = alternateTitles;
            SecondaryYear = secondaryYear;
            SecondaryYearSourceId = secondaryYearSourceId;
            SortTitle = sortTitle;
            SizeOnDisk = sizeOnDisk;
            Status = status;
            Overview = overview;
            InCinemas = inCinemas;
            PhysicalRelease = physicalRelease;
            DigitalRelease = digitalRelease;
            PhysicalReleaseNote = physicalReleaseNote;
            Images = images;
            Website = website;
            RemotePoster = remotePoster;
            Year = year;
            YouTubeTrailerId = youTubeTrailerId;
            Studio = studio;
            Path = path;
            QualityProfileId = qualityProfileId;
            HasFile = hasFile;
            Monitored = monitored;
            MinimumAvailability = minimumAvailability;
            IsAvailable = isAvailable;
            FolderName = folderName;
            Runtime = runtime;
            CleanTitle = cleanTitle;
            ImdbId = imdbId;
            TmdbId = tmdbId;
            TitleSlug = titleSlug;
            RootFolderPath = rootFolderPath;
            Folder = folder;
            Certification = certification;
            Genres = genres;
            Tags = tags;
            Added = added;
            AddOptions = addOptions;
            Ratings = ratings;
            MovieFile = movieFile;
            Collection = collection;
            Popularity = popularity;
            Statistics = statistics;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets OriginalTitle
        /// </summary>
        [DataMember(Name = "originalTitle", EmitDefaultValue = false)]
        public string OriginalTitle { get; set; }

        /// <summary>
        /// Gets or Sets OriginalLanguage
        /// </summary>
        [DataMember(Name = "originalLanguage", EmitDefaultValue = false)]
        public Language OriginalLanguage { get; set; }

        /// <summary>
        /// Gets or Sets AlternateTitles
        /// </summary>
        [DataMember(Name = "alternateTitles", EmitDefaultValue = false)]
        public List<AlternativeTitleResource> AlternateTitles { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryYear
        /// </summary>
        [DataMember(Name = "secondaryYear", EmitDefaultValue = false)]
        public int? SecondaryYear { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryYearSourceId
        /// </summary>
        [DataMember(Name = "secondaryYearSourceId", EmitDefaultValue = false)]
        public int? SecondaryYearSourceId { get; set; }

        /// <summary>
        /// Gets or Sets SortTitle
        /// </summary>
        [DataMember(Name = "sortTitle", EmitDefaultValue = false)]
        public string SortTitle { get; set; }

        /// <summary>
        /// Gets or Sets SizeOnDisk
        /// </summary>
        [DataMember(Name = "sizeOnDisk", EmitDefaultValue = false)]
        public long? SizeOnDisk { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public MovieStatusType Status { get; set; }

        /// <summary>
        /// Gets or Sets Overview
        /// </summary>
        [DataMember(Name = "overview", EmitDefaultValue = false)]
        public string Overview { get; set; }

        /// <summary>
        /// Gets or Sets InCinemas
        /// </summary>
        [DataMember(Name = "inCinemas", EmitDefaultValue = false)]
        public DateTime? InCinemas { get; set; }

        /// <summary>
        /// Gets or Sets PhysicalRelease
        /// </summary>
        [DataMember(Name = "physicalRelease", EmitDefaultValue = false)]
        public DateTime? PhysicalRelease { get; set; }

        /// <summary>
        /// Gets or Sets DigitalRelease
        /// </summary>
        [DataMember(Name = "digitalRelease", EmitDefaultValue = false)]
        public DateTime? DigitalRelease { get; set; }

        /// <summary>
        /// Gets or Sets PhysicalReleaseNote
        /// </summary>
        [DataMember(Name = "physicalReleaseNote", EmitDefaultValue = false)]
        public string PhysicalReleaseNote { get; set; }

        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        public List<MediaCover> Images { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name = "website", EmitDefaultValue = false)]
        public string Website { get; set; }

        /// <summary>
        /// Gets or Sets RemotePoster
        /// </summary>
        [DataMember(Name = "remotePoster", EmitDefaultValue = false)]
        public string RemotePoster { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name = "year", EmitDefaultValue = false)]
        public int? Year { get; set; }

        /// <summary>
        /// Gets or Sets YouTubeTrailerId
        /// </summary>
        [DataMember(Name = "youTubeTrailerId", EmitDefaultValue = false)]
        public string YouTubeTrailerId { get; set; }

        /// <summary>
        /// Gets or Sets Studio
        /// </summary>
        [DataMember(Name = "studio", EmitDefaultValue = false)]
        public string Studio { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets QualityProfileId
        /// </summary>
        [DataMember(Name = "qualityProfileId", EmitDefaultValue = false)]
        public int? QualityProfileId { get; set; }

        /// <summary>
        /// Gets or Sets HasFile
        /// </summary>
        [DataMember(Name = "hasFile", EmitDefaultValue = false)]
        public bool? HasFile { get; set; }

        /// <summary>
        /// Gets or Sets Monitored
        /// </summary>
        [DataMember(Name = "monitored", EmitDefaultValue = false)]
        public bool? Monitored { get; set; }

        /// <summary>
        /// Gets or Sets MinimumAvailability
        /// </summary>
        [DataMember(Name = "minimumAvailability", EmitDefaultValue = false)]
        public MovieStatusType MinimumAvailability { get; set; }

        /// <summary>
        /// Gets or Sets IsAvailable
        /// </summary>
        [DataMember(Name = "isAvailable", EmitDefaultValue = false)]
        public bool? IsAvailable { get; set; }

        /// <summary>
        /// Gets or Sets FolderName
        /// </summary>
        [DataMember(Name = "folderName", EmitDefaultValue = false)]
        public string FolderName { get; set; }

        /// <summary>
        /// Gets or Sets Runtime
        /// </summary>
        [DataMember(Name = "runtime", EmitDefaultValue = false)]
        public int? Runtime { get; set; }

        /// <summary>
        /// Gets or Sets CleanTitle
        /// </summary>
        [DataMember(Name = "cleanTitle", EmitDefaultValue = false)]
        public string CleanTitle { get; set; }

        /// <summary>
        /// Gets or Sets ImdbId
        /// </summary>
        [DataMember(Name = "imdbId", EmitDefaultValue = false)]
        public string ImdbId { get; set; }

        /// <summary>
        /// Gets or Sets TmdbId
        /// </summary>
        [DataMember(Name = "tmdbId", EmitDefaultValue = false)]
        public int? TmdbId { get; set; }

        /// <summary>
        /// Gets or Sets TitleSlug
        /// </summary>
        [DataMember(Name = "titleSlug", EmitDefaultValue = false)]
        public string TitleSlug { get; set; }

        /// <summary>
        /// Gets or Sets RootFolderPath
        /// </summary>
        [DataMember(Name = "rootFolderPath", EmitDefaultValue = false)]
        public string RootFolderPath { get; set; }

        /// <summary>
        /// Gets or Sets Folder
        /// </summary>
        [DataMember(Name = "folder", EmitDefaultValue = false)]
        public string Folder { get; set; }

        /// <summary>
        /// Gets or Sets Certification
        /// </summary>
        [DataMember(Name = "certification", EmitDefaultValue = false)]
        public string Certification { get; set; }

        /// <summary>
        /// Gets or Sets Genres
        /// </summary>
        [DataMember(Name = "genres", EmitDefaultValue = false)]
        public List<string> Genres { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<int?> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Added
        /// </summary>
        [DataMember(Name = "added", EmitDefaultValue = false)]
        public DateTime? Added { get; set; }

        /// <summary>
        /// Gets or Sets AddOptions
        /// </summary>
        [DataMember(Name = "addOptions", EmitDefaultValue = false)]
        public AddMovieOptions AddOptions { get; set; }

        /// <summary>
        /// Gets or Sets Ratings
        /// </summary>
        [DataMember(Name = "ratings", EmitDefaultValue = false)]
        public Ratings Ratings { get; set; }

        /// <summary>
        /// Gets or Sets MovieFile
        /// </summary>
        [DataMember(Name = "movieFile", EmitDefaultValue = false)]
        public MovieFileResource MovieFile { get; set; }

        /// <summary>
        /// Gets or Sets Collection
        /// </summary>
        [DataMember(Name = "collection", EmitDefaultValue = false)]
        public MovieCollectionResource Collection { get; set; }

        /// <summary>
        /// Gets or Sets Popularity
        /// </summary>
        [DataMember(Name = "popularity", EmitDefaultValue = false)]
        public float? Popularity { get; set; }

        /// <summary>
        /// Gets or Sets Statistics
        /// </summary>
        [DataMember(Name = "statistics", EmitDefaultValue = false)]
        public MovieStatisticsResource Statistics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MovieResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  OriginalTitle: ").Append(OriginalTitle).Append("\n");
            sb.Append("  OriginalLanguage: ").Append(OriginalLanguage).Append("\n");
            sb.Append("  AlternateTitles: ").Append(AlternateTitles).Append("\n");
            sb.Append("  SecondaryYear: ").Append(SecondaryYear).Append("\n");
            sb.Append("  SecondaryYearSourceId: ").Append(SecondaryYearSourceId).Append("\n");
            sb.Append("  SortTitle: ").Append(SortTitle).Append("\n");
            sb.Append("  SizeOnDisk: ").Append(SizeOnDisk).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Overview: ").Append(Overview).Append("\n");
            sb.Append("  InCinemas: ").Append(InCinemas).Append("\n");
            sb.Append("  PhysicalRelease: ").Append(PhysicalRelease).Append("\n");
            sb.Append("  DigitalRelease: ").Append(DigitalRelease).Append("\n");
            sb.Append("  PhysicalReleaseNote: ").Append(PhysicalReleaseNote).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  RemotePoster: ").Append(RemotePoster).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  YouTubeTrailerId: ").Append(YouTubeTrailerId).Append("\n");
            sb.Append("  Studio: ").Append(Studio).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  QualityProfileId: ").Append(QualityProfileId).Append("\n");
            sb.Append("  HasFile: ").Append(HasFile).Append("\n");
            sb.Append("  Monitored: ").Append(Monitored).Append("\n");
            sb.Append("  MinimumAvailability: ").Append(MinimumAvailability).Append("\n");
            sb.Append("  IsAvailable: ").Append(IsAvailable).Append("\n");
            sb.Append("  FolderName: ").Append(FolderName).Append("\n");
            sb.Append("  Runtime: ").Append(Runtime).Append("\n");
            sb.Append("  CleanTitle: ").Append(CleanTitle).Append("\n");
            sb.Append("  ImdbId: ").Append(ImdbId).Append("\n");
            sb.Append("  TmdbId: ").Append(TmdbId).Append("\n");
            sb.Append("  TitleSlug: ").Append(TitleSlug).Append("\n");
            sb.Append("  RootFolderPath: ").Append(RootFolderPath).Append("\n");
            sb.Append("  Folder: ").Append(Folder).Append("\n");
            sb.Append("  Certification: ").Append(Certification).Append("\n");
            sb.Append("  Genres: ").Append(Genres).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Added: ").Append(Added).Append("\n");
            sb.Append("  AddOptions: ").Append(AddOptions).Append("\n");
            sb.Append("  Ratings: ").Append(Ratings).Append("\n");
            sb.Append("  MovieFile: ").Append(MovieFile).Append("\n");
            sb.Append("  Collection: ").Append(Collection).Append("\n");
            sb.Append("  Popularity: ").Append(Popularity).Append("\n");
            sb.Append("  Statistics: ").Append(Statistics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as MovieResource);
        }

        /// <summary>
        /// Returns true if MovieResource instances are equal
        /// </summary>
        /// <param name="input">Instance of MovieResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MovieResource input)
        {
            if (input == null)
                return false;

            return
                (
                    Id == input.Id ||
                    Id != null &&
                    Id.Equals(input.Id)
                ) &&
                (
                    Title == input.Title ||
                    Title != null &&
                    Title.Equals(input.Title)
                ) &&
                (
                    OriginalTitle == input.OriginalTitle ||
                    OriginalTitle != null &&
                    OriginalTitle.Equals(input.OriginalTitle)
                ) &&
                (
                    OriginalLanguage == input.OriginalLanguage ||
                    OriginalLanguage != null &&
                    OriginalLanguage.Equals(input.OriginalLanguage)
                ) &&
                (
                    AlternateTitles == input.AlternateTitles ||
                    AlternateTitles != null &&
                    input.AlternateTitles != null &&
                    AlternateTitles.SequenceEqual(input.AlternateTitles)
                ) &&
                (
                    SecondaryYear == input.SecondaryYear ||
                    SecondaryYear != null &&
                    SecondaryYear.Equals(input.SecondaryYear)
                ) &&
                (
                    SecondaryYearSourceId == input.SecondaryYearSourceId ||
                    SecondaryYearSourceId != null &&
                    SecondaryYearSourceId.Equals(input.SecondaryYearSourceId)
                ) &&
                (
                    SortTitle == input.SortTitle ||
                    SortTitle != null &&
                    SortTitle.Equals(input.SortTitle)
                ) &&
                (
                    SizeOnDisk == input.SizeOnDisk ||
                    SizeOnDisk != null &&
                    SizeOnDisk.Equals(input.SizeOnDisk)
                ) &&
                (
                    Status == input.Status ||
                    Status.Equals(input.Status)
                ) &&
                (
                    Overview == input.Overview ||
                    Overview != null &&
                    Overview.Equals(input.Overview)
                ) &&
                (
                    InCinemas == input.InCinemas ||
                    InCinemas != null &&
                    InCinemas.Equals(input.InCinemas)
                ) &&
                (
                    PhysicalRelease == input.PhysicalRelease ||
                    PhysicalRelease != null &&
                    PhysicalRelease.Equals(input.PhysicalRelease)
                ) &&
                (
                    DigitalRelease == input.DigitalRelease ||
                    DigitalRelease != null &&
                    DigitalRelease.Equals(input.DigitalRelease)
                ) &&
                (
                    PhysicalReleaseNote == input.PhysicalReleaseNote ||
                    PhysicalReleaseNote != null &&
                    PhysicalReleaseNote.Equals(input.PhysicalReleaseNote)
                ) &&
                (
                    Images == input.Images ||
                    Images != null &&
                    input.Images != null &&
                    Images.SequenceEqual(input.Images)
                ) &&
                (
                    Website == input.Website ||
                    Website != null &&
                    Website.Equals(input.Website)
                ) &&
                (
                    RemotePoster == input.RemotePoster ||
                    RemotePoster != null &&
                    RemotePoster.Equals(input.RemotePoster)
                ) &&
                (
                    Year == input.Year ||
                    Year != null &&
                    Year.Equals(input.Year)
                ) &&
                (
                    YouTubeTrailerId == input.YouTubeTrailerId ||
                    YouTubeTrailerId != null &&
                    YouTubeTrailerId.Equals(input.YouTubeTrailerId)
                ) &&
                (
                    Studio == input.Studio ||
                    Studio != null &&
                    Studio.Equals(input.Studio)
                ) &&
                (
                    Path == input.Path ||
                    Path != null &&
                    Path.Equals(input.Path)
                ) &&
                (
                    QualityProfileId == input.QualityProfileId ||
                    QualityProfileId != null &&
                    QualityProfileId.Equals(input.QualityProfileId)
                ) &&
                (
                    HasFile == input.HasFile ||
                    HasFile != null &&
                    HasFile.Equals(input.HasFile)
                ) &&
                (
                    Monitored == input.Monitored ||
                    Monitored != null &&
                    Monitored.Equals(input.Monitored)
                ) &&
                (
                    MinimumAvailability == input.MinimumAvailability ||
                    MinimumAvailability.Equals(input.MinimumAvailability)
                ) &&
                (
                    IsAvailable == input.IsAvailable ||
                    IsAvailable != null &&
                    IsAvailable.Equals(input.IsAvailable)
                ) &&
                (
                    FolderName == input.FolderName ||
                    FolderName != null &&
                    FolderName.Equals(input.FolderName)
                ) &&
                (
                    Runtime == input.Runtime ||
                    Runtime != null &&
                    Runtime.Equals(input.Runtime)
                ) &&
                (
                    CleanTitle == input.CleanTitle ||
                    CleanTitle != null &&
                    CleanTitle.Equals(input.CleanTitle)
                ) &&
                (
                    ImdbId == input.ImdbId ||
                    ImdbId != null &&
                    ImdbId.Equals(input.ImdbId)
                ) &&
                (
                    TmdbId == input.TmdbId ||
                    TmdbId != null &&
                    TmdbId.Equals(input.TmdbId)
                ) &&
                (
                    TitleSlug == input.TitleSlug ||
                    TitleSlug != null &&
                    TitleSlug.Equals(input.TitleSlug)
                ) &&
                (
                    RootFolderPath == input.RootFolderPath ||
                    RootFolderPath != null &&
                    RootFolderPath.Equals(input.RootFolderPath)
                ) &&
                (
                    Folder == input.Folder ||
                    Folder != null &&
                    Folder.Equals(input.Folder)
                ) &&
                (
                    Certification == input.Certification ||
                    Certification != null &&
                    Certification.Equals(input.Certification)
                ) &&
                (
                    Genres == input.Genres ||
                    Genres != null &&
                    input.Genres != null &&
                    Genres.SequenceEqual(input.Genres)
                ) &&
                (
                    Tags == input.Tags ||
                    Tags != null &&
                    input.Tags != null &&
                    Tags.SequenceEqual(input.Tags)
                ) &&
                (
                    Added == input.Added ||
                    Added != null &&
                    Added.Equals(input.Added)
                ) &&
                (
                    AddOptions == input.AddOptions ||
                    AddOptions != null &&
                    AddOptions.Equals(input.AddOptions)
                ) &&
                (
                    Ratings == input.Ratings ||
                    Ratings != null &&
                    Ratings.Equals(input.Ratings)
                ) &&
                (
                    MovieFile == input.MovieFile ||
                    MovieFile != null &&
                    MovieFile.Equals(input.MovieFile)
                ) &&
                (
                    Collection == input.Collection ||
                    Collection != null &&
                    Collection.Equals(input.Collection)
                ) &&
                (
                    Popularity == input.Popularity ||
                    Popularity != null &&
                    Popularity.Equals(input.Popularity)
                ) &&
                (
                    Statistics == input.Statistics ||
                    Statistics != null &&
                    Statistics.Equals(input.Statistics)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                if (OriginalTitle != null)
                    hashCode = hashCode * 59 + OriginalTitle.GetHashCode();
                if (OriginalLanguage != null)
                    hashCode = hashCode * 59 + OriginalLanguage.GetHashCode();
                if (AlternateTitles != null)
                    hashCode = hashCode * 59 + AlternateTitles.GetHashCode();
                if (SecondaryYear != null)
                    hashCode = hashCode * 59 + SecondaryYear.GetHashCode();
                if (SecondaryYearSourceId != null)
                    hashCode = hashCode * 59 + SecondaryYearSourceId.GetHashCode();
                if (SortTitle != null)
                    hashCode = hashCode * 59 + SortTitle.GetHashCode();
                if (SizeOnDisk != null)
                    hashCode = hashCode * 59 + SizeOnDisk.GetHashCode();
                hashCode = hashCode * 59 + Status.GetHashCode();
                if (Overview != null)
                    hashCode = hashCode * 59 + Overview.GetHashCode();
                if (InCinemas != null)
                    hashCode = hashCode * 59 + InCinemas.GetHashCode();
                if (PhysicalRelease != null)
                    hashCode = hashCode * 59 + PhysicalRelease.GetHashCode();
                if (DigitalRelease != null)
                    hashCode = hashCode * 59 + DigitalRelease.GetHashCode();
                if (PhysicalReleaseNote != null)
                    hashCode = hashCode * 59 + PhysicalReleaseNote.GetHashCode();
                if (Images != null)
                    hashCode = hashCode * 59 + Images.GetHashCode();
                if (Website != null)
                    hashCode = hashCode * 59 + Website.GetHashCode();
                if (RemotePoster != null)
                    hashCode = hashCode * 59 + RemotePoster.GetHashCode();
                if (Year != null)
                    hashCode = hashCode * 59 + Year.GetHashCode();
                if (YouTubeTrailerId != null)
                    hashCode = hashCode * 59 + YouTubeTrailerId.GetHashCode();
                if (Studio != null)
                    hashCode = hashCode * 59 + Studio.GetHashCode();
                if (Path != null)
                    hashCode = hashCode * 59 + Path.GetHashCode();
                if (QualityProfileId != null)
                    hashCode = hashCode * 59 + QualityProfileId.GetHashCode();
                if (HasFile != null)
                    hashCode = hashCode * 59 + HasFile.GetHashCode();
                if (Monitored != null)
                    hashCode = hashCode * 59 + Monitored.GetHashCode();
                hashCode = hashCode * 59 + MinimumAvailability.GetHashCode();
                if (IsAvailable != null)
                    hashCode = hashCode * 59 + IsAvailable.GetHashCode();
                if (FolderName != null)
                    hashCode = hashCode * 59 + FolderName.GetHashCode();
                if (Runtime != null)
                    hashCode = hashCode * 59 + Runtime.GetHashCode();
                if (CleanTitle != null)
                    hashCode = hashCode * 59 + CleanTitle.GetHashCode();
                if (ImdbId != null)
                    hashCode = hashCode * 59 + ImdbId.GetHashCode();
                if (TmdbId != null)
                    hashCode = hashCode * 59 + TmdbId.GetHashCode();
                if (TitleSlug != null)
                    hashCode = hashCode * 59 + TitleSlug.GetHashCode();
                if (RootFolderPath != null)
                    hashCode = hashCode * 59 + RootFolderPath.GetHashCode();
                if (Folder != null)
                    hashCode = hashCode * 59 + Folder.GetHashCode();
                if (Certification != null)
                    hashCode = hashCode * 59 + Certification.GetHashCode();
                if (Genres != null)
                    hashCode = hashCode * 59 + Genres.GetHashCode();
                if (Tags != null)
                    hashCode = hashCode * 59 + Tags.GetHashCode();
                if (Added != null)
                    hashCode = hashCode * 59 + Added.GetHashCode();
                if (AddOptions != null)
                    hashCode = hashCode * 59 + AddOptions.GetHashCode();
                if (Ratings != null)
                    hashCode = hashCode * 59 + Ratings.GetHashCode();
                if (MovieFile != null)
                    hashCode = hashCode * 59 + MovieFile.GetHashCode();
                if (Collection != null)
                    hashCode = hashCode * 59 + Collection.GetHashCode();
                if (Popularity != null)
                    hashCode = hashCode * 59 + Popularity.GetHashCode();
                if (Statistics != null)
                    hashCode = hashCode * 59 + Statistics.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
