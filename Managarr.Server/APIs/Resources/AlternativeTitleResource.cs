using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// AlternativeTitleResource
    /// </summary>
    [DataContract]
    public partial class AlternativeTitleResource : IEquatable<AlternativeTitleResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeTitleResource" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="sourceType">sourceType.</param>
        /// <param name="movieMetadataId">movieMetadataId.</param>
        /// <param name="title">title.</param>
        /// <param name="cleanTitle">cleanTitle.</param>
        public AlternativeTitleResource(int? id = default, SourceType sourceType = default, int? movieMetadataId = default, string title = default, string cleanTitle = default)
        {
            Id = id;
            SourceType = sourceType;
            MovieMetadataId = movieMetadataId;
            Title = title;
            CleanTitle = cleanTitle;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets SourceType
        /// </summary>
        [DataMember(Name = "sourceType", EmitDefaultValue = false)]
        public SourceType SourceType { get; set; }

        /// <summary>
        /// Gets or Sets MovieMetadataId
        /// </summary>
        [DataMember(Name = "movieMetadataId", EmitDefaultValue = false)]
        public int? MovieMetadataId { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets CleanTitle
        /// </summary>
        [DataMember(Name = "cleanTitle", EmitDefaultValue = false)]
        public string CleanTitle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlternativeTitleResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  MovieMetadataId: ").Append(MovieMetadataId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  CleanTitle: ").Append(CleanTitle).Append("\n");
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
            return Equals(input as AlternativeTitleResource);
        }

        /// <summary>
        /// Returns true if AlternativeTitleResource instances are equal
        /// </summary>
        /// <param name="input">Instance of AlternativeTitleResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlternativeTitleResource input)
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
                    SourceType == input.SourceType ||
                    SourceType.Equals(input.SourceType)
                ) &&
                (
                    MovieMetadataId == input.MovieMetadataId ||
                    MovieMetadataId != null &&
                    MovieMetadataId.Equals(input.MovieMetadataId)
                ) &&
                (
                    Title == input.Title ||
                    Title != null &&
                    Title.Equals(input.Title)
                ) &&
                (
                    CleanTitle == input.CleanTitle ||
                    CleanTitle != null &&
                    CleanTitle.Equals(input.CleanTitle)
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
                hashCode = hashCode * 59 + SourceType.GetHashCode();
                if (MovieMetadataId != null)
                    hashCode = hashCode * 59 + MovieMetadataId.GetHashCode();
                if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                if (CleanTitle != null)
                    hashCode = hashCode * 59 + CleanTitle.GetHashCode();
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
