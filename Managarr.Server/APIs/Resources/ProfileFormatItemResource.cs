using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// ProfileFormatItemResource
    /// </summary>
    [DataContract]
    public partial class ProfileFormatItemResource : IEquatable<ProfileFormatItemResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileFormatItemResource" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="format">format.</param>
        /// <param name="name">name.</param>
        /// <param name="score">score.</param>
        public ProfileFormatItemResource(int? id = default, int? format = default, string name = default, int? score = default)
        {
            Id = id;
            Format = format;
            Name = name;
            Score = score;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name = "format", EmitDefaultValue = false)]
        public int? Format { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public int? Score { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfileFormatItemResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
            return Equals(input as ProfileFormatItemResource);
        }

        /// <summary>
        /// Returns true if ProfileFormatItemResource instances are equal
        /// </summary>
        /// <param name="input">Instance of ProfileFormatItemResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfileFormatItemResource input)
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
                    Format == input.Format ||
                    Format != null &&
                    Format.Equals(input.Format)
                ) &&
                (
                    Name == input.Name ||
                    Name != null &&
                    Name.Equals(input.Name)
                ) &&
                (
                    Score == input.Score ||
                    Score != null &&
                    Score.Equals(input.Score)
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
                if (Format != null)
                    hashCode = hashCode * 59 + Format.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Score != null)
                    hashCode = hashCode * 59 + Score.GetHashCode();
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
