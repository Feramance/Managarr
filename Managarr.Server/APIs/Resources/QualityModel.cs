using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// QualityModel
    /// </summary>
    [DataContract]
    public partial class QualityModel : IEquatable<QualityModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QualityModel" /> class.
        /// </summary>
        /// <param name="quality">quality.</param>
        /// <param name="revision">revision.</param>
        public QualityModel(Quality quality = default, Revision revision = default)
        {
            Quality = quality;
            Revision = revision;
        }

        /// <summary>
        /// Gets or Sets Quality
        /// </summary>
        [DataMember(Name = "quality", EmitDefaultValue = false)]
        public Quality Quality { get; set; }

        /// <summary>
        /// Gets or Sets Revision
        /// </summary>
        [DataMember(Name = "revision", EmitDefaultValue = false)]
        public Revision Revision { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QualityModel {\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
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
            return Equals(input as QualityModel);
        }

        /// <summary>
        /// Returns true if QualityModel instances are equal
        /// </summary>
        /// <param name="input">Instance of QualityModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QualityModel input)
        {
            if (input == null)
                return false;

            return
                (
                    Quality == input.Quality ||
                    Quality != null &&
                    Quality.Equals(input.Quality)
                ) &&
                (
                    Revision == input.Revision ||
                    Revision != null &&
                    Revision.Equals(input.Revision)
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
                if (Quality != null)
                    hashCode = hashCode * 59 + Quality.GetHashCode();
                if (Revision != null)
                    hashCode = hashCode * 59 + Revision.GetHashCode();
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
