using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// MovieCollectionResource
    /// </summary>
    [DataContract]
    public partial class MovieCollectionResource : IEquatable<MovieCollectionResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MovieCollectionResource" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="tmdbId">tmdbId.</param>
        public MovieCollectionResource(string title = default, int? tmdbId = default)
        {
            Title = title;
            TmdbId = tmdbId;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets TmdbId
        /// </summary>
        [DataMember(Name = "tmdbId", EmitDefaultValue = false)]
        public int? TmdbId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MovieCollectionResource {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  TmdbId: ").Append(TmdbId).Append("\n");
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
            return Equals(input as MovieCollectionResource);
        }

        /// <summary>
        /// Returns true if MovieCollectionResource instances are equal
        /// </summary>
        /// <param name="input">Instance of MovieCollectionResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MovieCollectionResource input)
        {
            if (input == null)
                return false;

            return
                (
                    Title == input.Title ||
                    Title != null &&
                    Title.Equals(input.Title)
                ) &&
                (
                    TmdbId == input.TmdbId ||
                    TmdbId != null &&
                    TmdbId.Equals(input.TmdbId)
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
                if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                if (TmdbId != null)
                    hashCode = hashCode * 59 + TmdbId.GetHashCode();
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
