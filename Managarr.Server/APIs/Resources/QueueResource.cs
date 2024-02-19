using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// QueueResource
    /// </summary>
    [DataContract]
    public partial class QueueResource : IEquatable<QueueResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueResource" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="movieId">movieId.</param>
        /// <param name="movie">movie.</param>
        /// <param name="languages">languages.</param>
        /// <param name="quality">quality.</param>
        /// <param name="customFormats">customFormats.</param>
        /// <param name="customFormatScore">customFormatScore.</param>
        /// <param name="size">size.</param>
        /// <param name="title">title.</param>
        /// <param name="sizeleft">sizeleft.</param>
        /// <param name="timeleft">timeleft.</param>
        /// <param name="estimatedCompletionTime">estimatedCompletionTime.</param>
        /// <param name="added">added.</param>
        /// <param name="status">status.</param>
        /// <param name="trackedDownloadStatus">trackedDownloadStatus.</param>
        /// <param name="trackedDownloadState">trackedDownloadState.</param>
        /// <param name="statusMessages">statusMessages.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="downloadId">downloadId.</param>
        /// <param name="protocol">protocol.</param>
        /// <param name="downloadClient">downloadClient.</param>
        /// <param name="downloadClientHasPostImportCategory">downloadClientHasPostImportCategory.</param>
        /// <param name="indexer">indexer.</param>
        /// <param name="outputPath">outputPath.</param>
        public QueueResource(int? id = default, int? movieId = default, MovieResource movie = default, List<Language> languages = default, QualityModel quality = default, List<CustomFormatResource> customFormats = default, int? customFormatScore = default, double? size = default, string title = default, double? sizeleft = default, TimeSpan timeleft = default, DateTime? estimatedCompletionTime = default, DateTime? added = default, string status = default, TrackedDownloadStatus trackedDownloadStatus = default, TrackedDownloadState trackedDownloadState = default, List<TrackedDownloadStatusMessage> statusMessages = default, string errorMessage = default, string downloadId = default, DownloadProtocol protocol = default, string downloadClient = default, bool? downloadClientHasPostImportCategory = default, string indexer = default, string outputPath = default)
        {
            Id = id;
            MovieId = movieId;
            Movie = movie;
            Languages = languages;
            Quality = quality;
            CustomFormats = customFormats;
            CustomFormatScore = customFormatScore;
            Size = size;
            Title = title;
            Sizeleft = sizeleft;
            Timeleft = timeleft;
            EstimatedCompletionTime = estimatedCompletionTime;
            Added = added;
            Status = status;
            TrackedDownloadStatus = trackedDownloadStatus;
            TrackedDownloadState = trackedDownloadState;
            StatusMessages = statusMessages;
            ErrorMessage = errorMessage;
            DownloadId = downloadId;
            Protocol = protocol;
            DownloadClient = downloadClient;
            DownloadClientHasPostImportCategory = downloadClientHasPostImportCategory;
            Indexer = indexer;
            OutputPath = outputPath;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets MovieId
        /// </summary>
        [DataMember(Name = "movieId", EmitDefaultValue = false)]
        public int? MovieId { get; set; }

        /// <summary>
        /// Gets or Sets Movie
        /// </summary>
        [DataMember(Name = "movie", EmitDefaultValue = false)]
        public MovieResource Movie { get; set; }

        /// <summary>
        /// Gets or Sets Languages
        /// </summary>
        [DataMember(Name = "languages", EmitDefaultValue = false)]
        public List<Language> Languages { get; set; }

        /// <summary>
        /// Gets or Sets Quality
        /// </summary>
        [DataMember(Name = "quality", EmitDefaultValue = false)]
        public QualityModel Quality { get; set; }

        /// <summary>
        /// Gets or Sets CustomFormats
        /// </summary>
        [DataMember(Name = "customFormats", EmitDefaultValue = false)]
        public List<CustomFormatResource> CustomFormats { get; set; }

        /// <summary>
        /// Gets or Sets CustomFormatScore
        /// </summary>
        [DataMember(Name = "customFormatScore", EmitDefaultValue = false)]
        public int? CustomFormatScore { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public double? Size { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Sizeleft
        /// </summary>
        [DataMember(Name = "sizeleft", EmitDefaultValue = false)]
        public double? Sizeleft { get; set; }

        /// <summary>
        /// Gets or Sets Timeleft
        /// </summary>
        [DataMember(Name = "timeleft", EmitDefaultValue = false)]
        public TimeSpan Timeleft { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedCompletionTime
        /// </summary>
        [DataMember(Name = "estimatedCompletionTime", EmitDefaultValue = false)]
        public DateTime? EstimatedCompletionTime { get; set; }

        /// <summary>
        /// Gets or Sets Added
        /// </summary>
        [DataMember(Name = "added", EmitDefaultValue = false)]
        public DateTime? Added { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets TrackedDownloadStatus
        /// </summary>
        [DataMember(Name = "trackedDownloadStatus", EmitDefaultValue = false)]
        public TrackedDownloadStatus TrackedDownloadStatus { get; set; }

        /// <summary>
        /// Gets or Sets TrackedDownloadState
        /// </summary>
        [DataMember(Name = "trackedDownloadState", EmitDefaultValue = false)]
        public TrackedDownloadState TrackedDownloadState { get; set; }

        /// <summary>
        /// Gets or Sets StatusMessages
        /// </summary>
        [DataMember(Name = "statusMessages", EmitDefaultValue = false)]
        public List<TrackedDownloadStatusMessage> StatusMessages { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or Sets DownloadId
        /// </summary>
        [DataMember(Name = "downloadId", EmitDefaultValue = false)]
        public string DownloadId { get; set; }

        /// <summary>
        /// Gets or Sets Protocol
        /// </summary>
        [DataMember(Name = "protocol", EmitDefaultValue = false)]
        public DownloadProtocol Protocol { get; set; }

        /// <summary>
        /// Gets or Sets DownloadClient
        /// </summary>
        [DataMember(Name = "downloadClient", EmitDefaultValue = false)]
        public string DownloadClient { get; set; }

        /// <summary>
        /// Gets or Sets DownloadClientHasPostImportCategory
        /// </summary>
        [DataMember(Name = "downloadClientHasPostImportCategory", EmitDefaultValue = false)]
        public bool? DownloadClientHasPostImportCategory { get; set; }

        /// <summary>
        /// Gets or Sets Indexer
        /// </summary>
        [DataMember(Name = "indexer", EmitDefaultValue = false)]
        public string Indexer { get; set; }

        /// <summary>
        /// Gets or Sets OutputPath
        /// </summary>
        [DataMember(Name = "outputPath", EmitDefaultValue = false)]
        public string OutputPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MovieId: ").Append(MovieId).Append("\n");
            sb.Append("  Movie: ").Append(Movie).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
            sb.Append("  CustomFormats: ").Append(CustomFormats).Append("\n");
            sb.Append("  CustomFormatScore: ").Append(CustomFormatScore).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Sizeleft: ").Append(Sizeleft).Append("\n");
            sb.Append("  Timeleft: ").Append(Timeleft).Append("\n");
            sb.Append("  EstimatedCompletionTime: ").Append(EstimatedCompletionTime).Append("\n");
            sb.Append("  Added: ").Append(Added).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TrackedDownloadStatus: ").Append(TrackedDownloadStatus).Append("\n");
            sb.Append("  TrackedDownloadState: ").Append(TrackedDownloadState).Append("\n");
            sb.Append("  StatusMessages: ").Append(StatusMessages).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  DownloadId: ").Append(DownloadId).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  DownloadClient: ").Append(DownloadClient).Append("\n");
            sb.Append("  DownloadClientHasPostImportCategory: ").Append(DownloadClientHasPostImportCategory).Append("\n");
            sb.Append("  Indexer: ").Append(Indexer).Append("\n");
            sb.Append("  OutputPath: ").Append(OutputPath).Append("\n");
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
            return Equals(input as QueueResource);
        }

        /// <summary>
        /// Returns true if QueueResource instances are equal
        /// </summary>
        /// <param name="input">Instance of QueueResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueResource input)
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
                    MovieId == input.MovieId ||
                    MovieId != null &&
                    MovieId.Equals(input.MovieId)
                ) &&
                (
                    Movie == input.Movie ||
                    Movie != null &&
                    Movie.Equals(input.Movie)
                ) &&
                (
                    Languages == input.Languages ||
                    Languages != null &&
                    input.Languages != null &&
                    Languages.SequenceEqual(input.Languages)
                ) &&
                (
                    Quality == input.Quality ||
                    Quality != null &&
                    Quality.Equals(input.Quality)
                ) &&
                (
                    CustomFormats == input.CustomFormats ||
                    CustomFormats != null &&
                    input.CustomFormats != null &&
                    CustomFormats.SequenceEqual(input.CustomFormats)
                ) &&
                (
                    CustomFormatScore == input.CustomFormatScore ||
                    CustomFormatScore != null &&
                    CustomFormatScore.Equals(input.CustomFormatScore)
                ) &&
                (
                    Size == input.Size ||
                    Size != null &&
                    Size.Equals(input.Size)
                ) &&
                (
                    Title == input.Title ||
                    Title != null &&
                    Title.Equals(input.Title)
                ) &&
                (
                    Sizeleft == input.Sizeleft ||
                    Sizeleft != null &&
                    Sizeleft.Equals(input.Sizeleft)
                ) &&
                (
                    Timeleft == input.Timeleft ||
                    Timeleft != null &&
                    Timeleft.Equals(input.Timeleft)
                ) &&
                (
                    EstimatedCompletionTime == input.EstimatedCompletionTime ||
                    EstimatedCompletionTime != null &&
                    EstimatedCompletionTime.Equals(input.EstimatedCompletionTime)
                ) &&
                (
                    Added == input.Added ||
                    Added != null &&
                    Added.Equals(input.Added)
                ) &&
                (
                    Status == input.Status ||
                    Status != null &&
                    Status.Equals(input.Status)
                ) &&
                (
                    TrackedDownloadStatus == input.TrackedDownloadStatus ||
                    TrackedDownloadStatus.Equals(input.TrackedDownloadStatus)
                ) &&
                (
                    TrackedDownloadState == input.TrackedDownloadState ||
                    TrackedDownloadState.Equals(input.TrackedDownloadState)
                ) &&
                (
                    StatusMessages == input.StatusMessages ||
                    StatusMessages != null &&
                    input.StatusMessages != null &&
                    StatusMessages.SequenceEqual(input.StatusMessages)
                ) &&
                (
                    ErrorMessage == input.ErrorMessage ||
                    ErrorMessage != null &&
                    ErrorMessage.Equals(input.ErrorMessage)
                ) &&
                (
                    DownloadId == input.DownloadId ||
                    DownloadId != null &&
                    DownloadId.Equals(input.DownloadId)
                ) &&
                (
                    Protocol == input.Protocol ||
                    Protocol.Equals(input.Protocol)
                ) &&
                (
                    DownloadClient == input.DownloadClient ||
                    DownloadClient != null &&
                    DownloadClient.Equals(input.DownloadClient)
                ) &&
                (
                    DownloadClientHasPostImportCategory == input.DownloadClientHasPostImportCategory ||
                    DownloadClientHasPostImportCategory != null &&
                    DownloadClientHasPostImportCategory.Equals(input.DownloadClientHasPostImportCategory)
                ) &&
                (
                    Indexer == input.Indexer ||
                    Indexer != null &&
                    Indexer.Equals(input.Indexer)
                ) &&
                (
                    OutputPath == input.OutputPath ||
                    OutputPath != null &&
                    OutputPath.Equals(input.OutputPath)
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
                if (MovieId != null)
                    hashCode = hashCode * 59 + MovieId.GetHashCode();
                if (Movie != null)
                    hashCode = hashCode * 59 + Movie.GetHashCode();
                if (Languages != null)
                    hashCode = hashCode * 59 + Languages.GetHashCode();
                if (Quality != null)
                    hashCode = hashCode * 59 + Quality.GetHashCode();
                if (CustomFormats != null)
                    hashCode = hashCode * 59 + CustomFormats.GetHashCode();
                if (CustomFormatScore != null)
                    hashCode = hashCode * 59 + CustomFormatScore.GetHashCode();
                if (Size != null)
                    hashCode = hashCode * 59 + Size.GetHashCode();
                if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                if (Sizeleft != null)
                    hashCode = hashCode * 59 + Sizeleft.GetHashCode();
                if (Timeleft != null)
                    hashCode = hashCode * 59 + Timeleft.GetHashCode();
                if (EstimatedCompletionTime != null)
                    hashCode = hashCode * 59 + EstimatedCompletionTime.GetHashCode();
                if (Added != null)
                    hashCode = hashCode * 59 + Added.GetHashCode();
                if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                hashCode = hashCode * 59 + TrackedDownloadStatus.GetHashCode();
                hashCode = hashCode * 59 + TrackedDownloadState.GetHashCode();
                if (StatusMessages != null)
                    hashCode = hashCode * 59 + StatusMessages.GetHashCode();
                if (ErrorMessage != null)
                    hashCode = hashCode * 59 + ErrorMessage.GetHashCode();
                if (DownloadId != null)
                    hashCode = hashCode * 59 + DownloadId.GetHashCode();
                hashCode = hashCode * 59 + Protocol.GetHashCode();
                if (DownloadClient != null)
                    hashCode = hashCode * 59 + DownloadClient.GetHashCode();
                if (DownloadClientHasPostImportCategory != null)
                    hashCode = hashCode * 59 + DownloadClientHasPostImportCategory.GetHashCode();
                if (Indexer != null)
                    hashCode = hashCode * 59 + Indexer.GetHashCode();
                if (OutputPath != null)
                    hashCode = hashCode * 59 + OutputPath.GetHashCode();
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
