using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// Revision
    /// </summary>
    [DataContract]
    public partial class Revision : IEquatable<Revision>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Revision" /> class.
        /// </summary>
        /// <param name="version">version.</param>
        /// <param name="real">real.</param>
        /// <param name="isRepack">isRepack.</param>
        public Revision(int? version = default, int? real = default, bool? isRepack = default)
        {
            Version = version;
            Real = real;
            IsRepack = isRepack;
        }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int? Version { get; set; }

        /// <summary>
        /// Gets or Sets Real
        /// </summary>
        [DataMember(Name = "real", EmitDefaultValue = false)]
        public int? Real { get; set; }

        /// <summary>
        /// Gets or Sets IsRepack
        /// </summary>
        [DataMember(Name = "isRepack", EmitDefaultValue = false)]
        public bool? IsRepack { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Revision {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Real: ").Append(Real).Append("\n");
            sb.Append("  IsRepack: ").Append(IsRepack).Append("\n");
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
            return Equals(input as Revision);
        }

        /// <summary>
        /// Returns true if Revision instances are equal
        /// </summary>
        /// <param name="input">Instance of Revision to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Revision input)
        {
            if (input == null)
                return false;

            return
                (
                    Version == input.Version ||
                    Version != null &&
                    Version.Equals(input.Version)
                ) &&
                (
                    Real == input.Real ||
                    Real != null &&
                    Real.Equals(input.Real)
                ) &&
                (
                    IsRepack == input.IsRepack ||
                    IsRepack != null &&
                    IsRepack.Equals(input.IsRepack)
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
                if (Version != null)
                    hashCode = hashCode * 59 + Version.GetHashCode();
                if (Real != null)
                    hashCode = hashCode * 59 + Real.GetHashCode();
                if (IsRepack != null)
                    hashCode = hashCode * 59 + IsRepack.GetHashCode();
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
