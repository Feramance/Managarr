using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// SelectOption
    /// </summary>
    [DataContract]
    public partial class SelectOption : IEquatable<SelectOption>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectOption" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="name">name.</param>
        /// <param name="order">order.</param>
        /// <param name="hint">hint.</param>
        /// <param name="dividerAfter">dividerAfter.</param>
        public SelectOption(int? value = default, string name = default, int? order = default, string hint = default, bool? dividerAfter = default)
        {
            Value = value;
            Name = name;
            Order = order;
            Hint = hint;
            DividerAfter = dividerAfter;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public int? Value { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int? Order { get; set; }

        /// <summary>
        /// Gets or Sets Hint
        /// </summary>
        [DataMember(Name = "hint", EmitDefaultValue = false)]
        public string Hint { get; set; }

        /// <summary>
        /// Gets or Sets DividerAfter
        /// </summary>
        [DataMember(Name = "dividerAfter", EmitDefaultValue = false)]
        public bool? DividerAfter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelectOption {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Hint: ").Append(Hint).Append("\n");
            sb.Append("  DividerAfter: ").Append(DividerAfter).Append("\n");
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
            return Equals(input as SelectOption);
        }

        /// <summary>
        /// Returns true if SelectOption instances are equal
        /// </summary>
        /// <param name="input">Instance of SelectOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectOption input)
        {
            if (input == null)
                return false;

            return
                (
                    Value == input.Value ||
                    Value != null &&
                    Value.Equals(input.Value)
                ) &&
                (
                    Name == input.Name ||
                    Name != null &&
                    Name.Equals(input.Name)
                ) &&
                (
                    Order == input.Order ||
                    Order != null &&
                    Order.Equals(input.Order)
                ) &&
                (
                    Hint == input.Hint ||
                    Hint != null &&
                    Hint.Equals(input.Hint)
                ) &&
                (
                    DividerAfter == input.DividerAfter ||
                    DividerAfter != null &&
                    DividerAfter.Equals(input.DividerAfter)
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
                if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Order != null)
                    hashCode = hashCode * 59 + Order.GetHashCode();
                if (Hint != null)
                    hashCode = hashCode * 59 + Hint.GetHashCode();
                if (DividerAfter != null)
                    hashCode = hashCode * 59 + DividerAfter.GetHashCode();
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
