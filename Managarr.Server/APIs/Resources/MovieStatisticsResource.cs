using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// MovieStatisticsResource
    /// </summary>
    [DataContract]
    public partial class MovieStatisticsResource : IEquatable<MovieStatisticsResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MovieStatisticsResource" /> class.
        /// </summary>
        /// <param name="movieFileCount">movieFileCount.</param>
        /// <param name="sizeOnDisk">sizeOnDisk.</param>
        /// <param name="releaseGroups">releaseGroups.</param>
        public MovieStatisticsResource(int? movieFileCount = default, long? sizeOnDisk = default, List<string> releaseGroups = default)
        {
            MovieFileCount = movieFileCount;
            SizeOnDisk = sizeOnDisk;
            ReleaseGroups = releaseGroups;
        }

        /// <summary>
        /// Gets or Sets MovieFileCount
        /// </summary>
        [DataMember(Name = "movieFileCount", EmitDefaultValue = false)]
        public int? MovieFileCount { get; set; }

        /// <summary>
        /// Gets or Sets SizeOnDisk
        /// </summary>
        [DataMember(Name = "sizeOnDisk", EmitDefaultValue = false)]
        public long? SizeOnDisk { get; set; }

        /// <summary>
        /// Gets or Sets ReleaseGroups
        /// </summary>
        [DataMember(Name = "releaseGroups", EmitDefaultValue = false)]
        public List<string> ReleaseGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MovieStatisticsResource {\n");
            sb.Append("  MovieFileCount: ").Append(MovieFileCount).Append("\n");
            sb.Append("  SizeOnDisk: ").Append(SizeOnDisk).Append("\n");
            sb.Append("  ReleaseGroups: ").Append(ReleaseGroups).Append("\n");
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
            return Equals(input as MovieStatisticsResource);
        }

        /// <summary>
        /// Returns true if MovieStatisticsResource instances are equal
        /// </summary>
        /// <param name="input">Instance of MovieStatisticsResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MovieStatisticsResource input)
        {
            if (input == null)
                return false;

            return
                (
                    MovieFileCount == input.MovieFileCount ||
                    MovieFileCount != null &&
                    MovieFileCount.Equals(input.MovieFileCount)
                ) &&
                (
                    SizeOnDisk == input.SizeOnDisk ||
                    SizeOnDisk != null &&
                    SizeOnDisk.Equals(input.SizeOnDisk)
                ) &&
                (
                    ReleaseGroups == input.ReleaseGroups ||
                    ReleaseGroups != null &&
                    input.ReleaseGroups != null &&
                    ReleaseGroups.SequenceEqual(input.ReleaseGroups)
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
                if (MovieFileCount != null)
                    hashCode = hashCode * 59 + MovieFileCount.GetHashCode();
                if (SizeOnDisk != null)
                    hashCode = hashCode * 59 + SizeOnDisk.GetHashCode();
                if (ReleaseGroups != null)
                    hashCode = hashCode * 59 + ReleaseGroups.GetHashCode();
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
