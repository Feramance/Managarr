using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// RatingChild
    /// </summary>
    [DataContract]
    public partial class RatingChild : IEquatable<RatingChild>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RatingChild" /> class.
        /// </summary>
        /// <param name="votes">votes.</param>
        /// <param name="value">value.</param>
        /// <param name="type">type.</param>
        public RatingChild(int? votes = default, double? value = default, RatingType type = default)
        {
            Votes = votes;
            Value = value;
            Type = type;
        }

        /// <summary>
        /// Gets or Sets Votes
        /// </summary>
        [DataMember(Name = "votes", EmitDefaultValue = false)]
        public int? Votes { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public double? Value { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public RatingType Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RatingChild {\n");
            sb.Append("  Votes: ").Append(Votes).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return Equals(input as RatingChild);
        }

        /// <summary>
        /// Returns true if RatingChild instances are equal
        /// </summary>
        /// <param name="input">Instance of RatingChild to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RatingChild input)
        {
            if (input == null)
                return false;

            return
                (
                    Votes == input.Votes ||
                    Votes != null &&
                    Votes.Equals(input.Votes)
                ) &&
                (
                    Value == input.Value ||
                    Value != null &&
                    Value.Equals(input.Value)
                ) &&
                (
                    Type == input.Type ||
                    Type.Equals(input.Type)
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
                if (Votes != null)
                    hashCode = hashCode * 59 + Votes.GetHashCode();
                if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                hashCode = hashCode * 59 + Type.GetHashCode();
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
