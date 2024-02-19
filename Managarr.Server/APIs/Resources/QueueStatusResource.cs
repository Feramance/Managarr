using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// QueueStatusResource
    /// </summary>
    [DataContract]
    public partial class QueueStatusResource : IEquatable<QueueStatusResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueStatusResource" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="totalCount">totalCount.</param>
        /// <param name="count">count.</param>
        /// <param name="unknownCount">unknownCount.</param>
        /// <param name="errors">errors.</param>
        /// <param name="warnings">warnings.</param>
        /// <param name="unknownErrors">unknownErrors.</param>
        /// <param name="unknownWarnings">unknownWarnings.</param>
        public QueueStatusResource(int? id = default, int? totalCount = default, int? count = default, int? unknownCount = default, bool? errors = default, bool? warnings = default, bool? unknownErrors = default, bool? unknownWarnings = default)
        {
            Id = id;
            TotalCount = totalCount;
            Count = count;
            UnknownCount = unknownCount;
            Errors = errors;
            Warnings = warnings;
            UnknownErrors = unknownErrors;
            UnknownWarnings = unknownWarnings;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets TotalCount
        /// </summary>
        [DataMember(Name = "totalCount", EmitDefaultValue = false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or Sets UnknownCount
        /// </summary>
        [DataMember(Name = "unknownCount", EmitDefaultValue = false)]
        public int? UnknownCount { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public bool? Errors { get; set; }

        /// <summary>
        /// Gets or Sets Warnings
        /// </summary>
        [DataMember(Name = "warnings", EmitDefaultValue = false)]
        public bool? Warnings { get; set; }

        /// <summary>
        /// Gets or Sets UnknownErrors
        /// </summary>
        [DataMember(Name = "unknownErrors", EmitDefaultValue = false)]
        public bool? UnknownErrors { get; set; }

        /// <summary>
        /// Gets or Sets UnknownWarnings
        /// </summary>
        [DataMember(Name = "unknownWarnings", EmitDefaultValue = false)]
        public bool? UnknownWarnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueStatusResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  UnknownCount: ").Append(UnknownCount).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
            sb.Append("  UnknownErrors: ").Append(UnknownErrors).Append("\n");
            sb.Append("  UnknownWarnings: ").Append(UnknownWarnings).Append("\n");
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
            return Equals(input as QueueStatusResource);
        }

        /// <summary>
        /// Returns true if QueueStatusResource instances are equal
        /// </summary>
        /// <param name="input">Instance of QueueStatusResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueStatusResource input)
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
                    TotalCount == input.TotalCount ||
                    TotalCount != null &&
                    TotalCount.Equals(input.TotalCount)
                ) &&
                (
                    Count == input.Count ||
                    Count != null &&
                    Count.Equals(input.Count)
                ) &&
                (
                    UnknownCount == input.UnknownCount ||
                    UnknownCount != null &&
                    UnknownCount.Equals(input.UnknownCount)
                ) &&
                (
                    Errors == input.Errors ||
                    Errors != null &&
                    Errors.Equals(input.Errors)
                ) &&
                (
                    Warnings == input.Warnings ||
                    Warnings != null &&
                    Warnings.Equals(input.Warnings)
                ) &&
                (
                    UnknownErrors == input.UnknownErrors ||
                    UnknownErrors != null &&
                    UnknownErrors.Equals(input.UnknownErrors)
                ) &&
                (
                    UnknownWarnings == input.UnknownWarnings ||
                    UnknownWarnings != null &&
                    UnknownWarnings.Equals(input.UnknownWarnings)
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
                if (TotalCount != null)
                    hashCode = hashCode * 59 + TotalCount.GetHashCode();
                if (Count != null)
                    hashCode = hashCode * 59 + Count.GetHashCode();
                if (UnknownCount != null)
                    hashCode = hashCode * 59 + UnknownCount.GetHashCode();
                if (Errors != null)
                    hashCode = hashCode * 59 + Errors.GetHashCode();
                if (Warnings != null)
                    hashCode = hashCode * 59 + Warnings.GetHashCode();
                if (UnknownErrors != null)
                    hashCode = hashCode * 59 + UnknownErrors.GetHashCode();
                if (UnknownWarnings != null)
                    hashCode = hashCode * 59 + UnknownWarnings.GetHashCode();
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
