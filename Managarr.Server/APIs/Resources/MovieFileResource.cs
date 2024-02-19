using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// MovieFileResource
    /// </summary>
    [DataContract]
    public partial class MovieFileResource : IEquatable<MovieFileResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MovieFileResource" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="movieId">movieId.</param>
        /// <param name="relativePath">relativePath.</param>
        /// <param name="path">path.</param>
        /// <param name="size">size.</param>
        /// <param name="dateAdded">dateAdded.</param>
        /// <param name="sceneName">sceneName.</param>
        /// <param name="indexerFlags">indexerFlags.</param>
        /// <param name="quality">quality.</param>
        /// <param name="customFormats">customFormats.</param>
        /// <param name="customFormatScore">customFormatScore.</param>
        /// <param name="mediaInfo">mediaInfo.</param>
        /// <param name="originalFilePath">originalFilePath.</param>
        /// <param name="qualityCutoffNotMet">qualityCutoffNotMet.</param>
        /// <param name="languages">languages.</param>
        /// <param name="releaseGroup">releaseGroup.</param>
        /// <param name="edition">edition.</param>
        public MovieFileResource(int? id = default, int? movieId = default, string relativePath = default, string path = default, long? size = default, DateTime? dateAdded = default, string sceneName = default, int? indexerFlags = default, QualityModel quality = default, List<CustomFormatResource> customFormats = default, int? customFormatScore = default, MediaInfoResource mediaInfo = default, string originalFilePath = default, bool? qualityCutoffNotMet = default, List<Language> languages = default, string releaseGroup = default, string edition = default)
        {
            Id = id;
            MovieId = movieId;
            RelativePath = relativePath;
            Path = path;
            Size = size;
            DateAdded = dateAdded;
            SceneName = sceneName;
            IndexerFlags = indexerFlags;
            Quality = quality;
            CustomFormats = customFormats;
            CustomFormatScore = customFormatScore;
            MediaInfo = mediaInfo;
            OriginalFilePath = originalFilePath;
            QualityCutoffNotMet = qualityCutoffNotMet;
            Languages = languages;
            ReleaseGroup = releaseGroup;
            Edition = edition;
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
        /// Gets or Sets RelativePath
        /// </summary>
        [DataMember(Name = "relativePath", EmitDefaultValue = false)]
        public string RelativePath { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public long? Size { get; set; }

        /// <summary>
        /// Gets or Sets DateAdded
        /// </summary>
        [DataMember(Name = "dateAdded", EmitDefaultValue = false)]
        public DateTime? DateAdded { get; set; }

        /// <summary>
        /// Gets or Sets SceneName
        /// </summary>
        [DataMember(Name = "sceneName", EmitDefaultValue = false)]
        public string SceneName { get; set; }

        /// <summary>
        /// Gets or Sets IndexerFlags
        /// </summary>
        [DataMember(Name = "indexerFlags", EmitDefaultValue = false)]
        public int? IndexerFlags { get; set; }

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
        /// Gets or Sets MediaInfo
        /// </summary>
        [DataMember(Name = "mediaInfo", EmitDefaultValue = false)]
        public MediaInfoResource MediaInfo { get; set; }

        /// <summary>
        /// Gets or Sets OriginalFilePath
        /// </summary>
        [DataMember(Name = "originalFilePath", EmitDefaultValue = false)]
        public string OriginalFilePath { get; set; }

        /// <summary>
        /// Gets or Sets QualityCutoffNotMet
        /// </summary>
        [DataMember(Name = "qualityCutoffNotMet", EmitDefaultValue = false)]
        public bool? QualityCutoffNotMet { get; set; }

        /// <summary>
        /// Gets or Sets Languages
        /// </summary>
        [DataMember(Name = "languages", EmitDefaultValue = false)]
        public List<Language> Languages { get; set; }

        /// <summary>
        /// Gets or Sets ReleaseGroup
        /// </summary>
        [DataMember(Name = "releaseGroup", EmitDefaultValue = false)]
        public string ReleaseGroup { get; set; }

        /// <summary>
        /// Gets or Sets Edition
        /// </summary>
        [DataMember(Name = "edition", EmitDefaultValue = false)]
        public string Edition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MovieFileResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MovieId: ").Append(MovieId).Append("\n");
            sb.Append("  RelativePath: ").Append(RelativePath).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  DateAdded: ").Append(DateAdded).Append("\n");
            sb.Append("  SceneName: ").Append(SceneName).Append("\n");
            sb.Append("  IndexerFlags: ").Append(IndexerFlags).Append("\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
            sb.Append("  CustomFormats: ").Append(CustomFormats).Append("\n");
            sb.Append("  CustomFormatScore: ").Append(CustomFormatScore).Append("\n");
            sb.Append("  MediaInfo: ").Append(MediaInfo).Append("\n");
            sb.Append("  OriginalFilePath: ").Append(OriginalFilePath).Append("\n");
            sb.Append("  QualityCutoffNotMet: ").Append(QualityCutoffNotMet).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  ReleaseGroup: ").Append(ReleaseGroup).Append("\n");
            sb.Append("  Edition: ").Append(Edition).Append("\n");
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
            return Equals(input as MovieFileResource);
        }

        /// <summary>
        /// Returns true if MovieFileResource instances are equal
        /// </summary>
        /// <param name="input">Instance of MovieFileResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MovieFileResource input)
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
                    RelativePath == input.RelativePath ||
                    RelativePath != null &&
                    RelativePath.Equals(input.RelativePath)
                ) &&
                (
                    Path == input.Path ||
                    Path != null &&
                    Path.Equals(input.Path)
                ) &&
                (
                    Size == input.Size ||
                    Size != null &&
                    Size.Equals(input.Size)
                ) &&
                (
                    DateAdded == input.DateAdded ||
                    DateAdded != null &&
                    DateAdded.Equals(input.DateAdded)
                ) &&
                (
                    SceneName == input.SceneName ||
                    SceneName != null &&
                    SceneName.Equals(input.SceneName)
                ) &&
                (
                    IndexerFlags == input.IndexerFlags ||
                    IndexerFlags != null &&
                    IndexerFlags.Equals(input.IndexerFlags)
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
                    MediaInfo == input.MediaInfo ||
                    MediaInfo != null &&
                    MediaInfo.Equals(input.MediaInfo)
                ) &&
                (
                    OriginalFilePath == input.OriginalFilePath ||
                    OriginalFilePath != null &&
                    OriginalFilePath.Equals(input.OriginalFilePath)
                ) &&
                (
                    QualityCutoffNotMet == input.QualityCutoffNotMet ||
                    QualityCutoffNotMet != null &&
                    QualityCutoffNotMet.Equals(input.QualityCutoffNotMet)
                ) &&
                (
                    Languages == input.Languages ||
                    Languages != null &&
                    input.Languages != null &&
                    Languages.SequenceEqual(input.Languages)
                ) &&
                (
                    ReleaseGroup == input.ReleaseGroup ||
                    ReleaseGroup != null &&
                    ReleaseGroup.Equals(input.ReleaseGroup)
                ) &&
                (
                    Edition == input.Edition ||
                    Edition != null &&
                    Edition.Equals(input.Edition)
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
                if (RelativePath != null)
                    hashCode = hashCode * 59 + RelativePath.GetHashCode();
                if (Path != null)
                    hashCode = hashCode * 59 + Path.GetHashCode();
                if (Size != null)
                    hashCode = hashCode * 59 + Size.GetHashCode();
                if (DateAdded != null)
                    hashCode = hashCode * 59 + DateAdded.GetHashCode();
                if (SceneName != null)
                    hashCode = hashCode * 59 + SceneName.GetHashCode();
                if (IndexerFlags != null)
                    hashCode = hashCode * 59 + IndexerFlags.GetHashCode();
                if (Quality != null)
                    hashCode = hashCode * 59 + Quality.GetHashCode();
                if (CustomFormats != null)
                    hashCode = hashCode * 59 + CustomFormats.GetHashCode();
                if (CustomFormatScore != null)
                    hashCode = hashCode * 59 + CustomFormatScore.GetHashCode();
                if (MediaInfo != null)
                    hashCode = hashCode * 59 + MediaInfo.GetHashCode();
                if (OriginalFilePath != null)
                    hashCode = hashCode * 59 + OriginalFilePath.GetHashCode();
                if (QualityCutoffNotMet != null)
                    hashCode = hashCode * 59 + QualityCutoffNotMet.GetHashCode();
                if (Languages != null)
                    hashCode = hashCode * 59 + Languages.GetHashCode();
                if (ReleaseGroup != null)
                    hashCode = hashCode * 59 + ReleaseGroup.GetHashCode();
                if (Edition != null)
                    hashCode = hashCode * 59 + Edition.GetHashCode();
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
