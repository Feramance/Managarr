using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// CustomFormatResource
    /// </summary>
    [DataContract]
    public partial class CustomFormatResource : IEquatable<CustomFormatResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFormatResource" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="includeCustomFormatWhenRenaming">includeCustomFormatWhenRenaming.</param>
        /// <param name="specifications">specifications.</param>
        public CustomFormatResource(int? id = default, string name = default, bool? includeCustomFormatWhenRenaming = default, List<CustomFormatSpecificationSchema> specifications = default)
        {
            Id = id;
            Name = name;
            IncludeCustomFormatWhenRenaming = includeCustomFormatWhenRenaming;
            Specifications = specifications;
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
        /// Gets or Sets IncludeCustomFormatWhenRenaming
        /// </summary>
        [DataMember(Name = "includeCustomFormatWhenRenaming", EmitDefaultValue = false)]
        public bool? IncludeCustomFormatWhenRenaming { get; set; }

        /// <summary>
        /// Gets or Sets Specifications
        /// </summary>
        [DataMember(Name = "specifications", EmitDefaultValue = false)]
        public List<CustomFormatSpecificationSchema> Specifications { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomFormatResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IncludeCustomFormatWhenRenaming: ").Append(IncludeCustomFormatWhenRenaming).Append("\n");
            sb.Append("  Specifications: ").Append(Specifications).Append("\n");
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
            return Equals(input as CustomFormatResource);
        }

        /// <summary>
        /// Returns true if CustomFormatResource instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomFormatResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomFormatResource input)
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
                    IncludeCustomFormatWhenRenaming == input.IncludeCustomFormatWhenRenaming ||
                    IncludeCustomFormatWhenRenaming != null &&
                    IncludeCustomFormatWhenRenaming.Equals(input.IncludeCustomFormatWhenRenaming)
                ) &&
                (
                    Specifications == input.Specifications ||
                    Specifications != null &&
                    input.Specifications != null &&
                    Specifications.SequenceEqual(input.Specifications)
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
                if (IncludeCustomFormatWhenRenaming != null)
                    hashCode = hashCode * 59 + IncludeCustomFormatWhenRenaming.GetHashCode();
                if (Specifications != null)
                    hashCode = hashCode * 59 + Specifications.GetHashCode();
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
