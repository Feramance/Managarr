using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// CustomFormatSpecificationSchema
    /// </summary>
    [DataContract]
    public partial class CustomFormatSpecificationSchema : IEquatable<CustomFormatSpecificationSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFormatSpecificationSchema" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="implementation">implementation.</param>
        /// <param name="implementationName">implementationName.</param>
        /// <param name="infoLink">infoLink.</param>
        /// <param name="negate">negate.</param>
        /// <param name="required">required.</param>
        /// <param name="fields">fields.</param>
        /// <param name="presets">presets.</param>
        public CustomFormatSpecificationSchema(int? id = default, string name = default, string implementation = default, string implementationName = default, string infoLink = default, bool? negate = default, bool? required = default, List<Field> fields = default, List<CustomFormatSpecificationSchema> presets = default)
        {
            Id = id;
            Name = name;
            Implementation = implementation;
            ImplementationName = implementationName;
            InfoLink = infoLink;
            Negate = negate;
            Required = required;
            Fields = fields;
            Presets = presets;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Implementation
        /// </summary>
        [DataMember(Name = "implementation", EmitDefaultValue = false)]
        public string Implementation { get; set; }

        /// <summary>
        /// Gets or Sets ImplementationName
        /// </summary>
        [DataMember(Name = "implementationName", EmitDefaultValue = false)]
        public string ImplementationName { get; set; }

        /// <summary>
        /// Gets or Sets InfoLink
        /// </summary>
        [DataMember(Name = "infoLink", EmitDefaultValue = false)]
        public string InfoLink { get; set; }

        /// <summary>
        /// Gets or Sets Negate
        /// </summary>
        [DataMember(Name = "negate", EmitDefaultValue = false)]
        public bool? Negate { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name = "required", EmitDefaultValue = false)]
        public bool? Required { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", EmitDefaultValue = false)]
        public List<Field> Fields { get; set; }

        /// <summary>
        /// Gets or Sets Presets
        /// </summary>
        [DataMember(Name = "presets", EmitDefaultValue = false)]
        public List<CustomFormatSpecificationSchema> Presets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomFormatSpecificationSchema {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Implementation: ").Append(Implementation).Append("\n");
            sb.Append("  ImplementationName: ").Append(ImplementationName).Append("\n");
            sb.Append("  InfoLink: ").Append(InfoLink).Append("\n");
            sb.Append("  Negate: ").Append(Negate).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Presets: ").Append(Presets).Append("\n");
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
            return Equals(input as CustomFormatSpecificationSchema);
        }

        /// <summary>
        /// Returns true if CustomFormatSpecificationSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomFormatSpecificationSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomFormatSpecificationSchema input)
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
                    Name == input.Name ||
                    Name != null &&
                    Name.Equals(input.Name)
                ) &&
                (
                    Implementation == input.Implementation ||
                    Implementation != null &&
                    Implementation.Equals(input.Implementation)
                ) &&
                (
                    ImplementationName == input.ImplementationName ||
                    ImplementationName != null &&
                    ImplementationName.Equals(input.ImplementationName)
                ) &&
                (
                    InfoLink == input.InfoLink ||
                    InfoLink != null &&
                    InfoLink.Equals(input.InfoLink)
                ) &&
                (
                    Negate == input.Negate ||
                    Negate != null &&
                    Negate.Equals(input.Negate)
                ) &&
                (
                    Required == input.Required ||
                    Required != null &&
                    Required.Equals(input.Required)
                ) &&
                (
                    Fields == input.Fields ||
                    Fields != null &&
                    input.Fields != null &&
                    Fields.SequenceEqual(input.Fields)
                ) &&
                (
                    Presets == input.Presets ||
                    Presets != null &&
                    input.Presets != null &&
                    Presets.SequenceEqual(input.Presets)
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
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Implementation != null)
                    hashCode = hashCode * 59 + Implementation.GetHashCode();
                if (ImplementationName != null)
                    hashCode = hashCode * 59 + ImplementationName.GetHashCode();
                if (InfoLink != null)
                    hashCode = hashCode * 59 + InfoLink.GetHashCode();
                if (Negate != null)
                    hashCode = hashCode * 59 + Negate.GetHashCode();
                if (Required != null)
                    hashCode = hashCode * 59 + Required.GetHashCode();
                if (Fields != null)
                    hashCode = hashCode * 59 + Fields.GetHashCode();
                if (Presets != null)
                    hashCode = hashCode * 59 + Presets.GetHashCode();
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
