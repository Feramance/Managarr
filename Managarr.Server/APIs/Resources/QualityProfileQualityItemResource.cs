using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// QualityProfileQualityItemResource
    /// </summary>
    [DataContract]
    public partial class QualityProfileQualityItemResource : IEquatable<QualityProfileQualityItemResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QualityProfileQualityItemResource" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="quality">quality.</param>
        /// <param name="items">items.</param>
        /// <param name="allowed">allowed.</param>
        public QualityProfileQualityItemResource(int? id = default, string name = default, Quality quality = default, List<QualityProfileQualityItemResource> items = default, bool? allowed = default)
        {
            Id = id;
            Name = name;
            Quality = quality;
            Items = items;
            Allowed = allowed;
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
        /// Gets or Sets Quality
        /// </summary>
        [DataMember(Name = "quality", EmitDefaultValue = false)]
        public Quality Quality { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<QualityProfileQualityItemResource> Items { get; set; }

        /// <summary>
        /// Gets or Sets Allowed
        /// </summary>
        [DataMember(Name = "allowed", EmitDefaultValue = false)]
        public bool? Allowed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QualityProfileQualityItemResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Allowed: ").Append(Allowed).Append("\n");
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
            return Equals(input as QualityProfileQualityItemResource);
        }

        /// <summary>
        /// Returns true if QualityProfileQualityItemResource instances are equal
        /// </summary>
        /// <param name="input">Instance of QualityProfileQualityItemResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QualityProfileQualityItemResource input)
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
                    Quality == input.Quality ||
                    Quality != null &&
                    Quality.Equals(input.Quality)
                ) &&
                (
                    Items == input.Items ||
                    Items != null &&
                    input.Items != null &&
                    Items.SequenceEqual(input.Items)
                ) &&
                (
                    Allowed == input.Allowed ||
                    Allowed != null &&
                    Allowed.Equals(input.Allowed)
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
                if (Quality != null)
                    hashCode = hashCode * 59 + Quality.GetHashCode();
                if (Items != null)
                    hashCode = hashCode * 59 + Items.GetHashCode();
                if (Allowed != null)
                    hashCode = hashCode * 59 + Allowed.GetHashCode();
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
