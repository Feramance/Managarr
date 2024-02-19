using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// Quality
    /// </summary>
    [DataContract]
    public partial class Quality : IEquatable<Quality>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Quality" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="source">source.</param>
        /// <param name="resolution">resolution.</param>
        /// <param name="modifier">modifier.</param>
        public Quality(int? id = default, string name = default, QualitySource source = default, int? resolution = default, Modifier modifier = default)
        {
            Id = id;
            Name = name;
            Source = source;
            Resolution = resolution;
            Modifier = modifier;
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
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public QualitySource Source { get; set; }

        /// <summary>
        /// Gets or Sets Resolution
        /// </summary>
        [DataMember(Name = "resolution", EmitDefaultValue = false)]
        public int? Resolution { get; set; }

        /// <summary>
        /// Gets or Sets Modifier
        /// </summary>
        [DataMember(Name = "modifier", EmitDefaultValue = false)]
        public Modifier Modifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Quality {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  Modifier: ").Append(Modifier).Append("\n");
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
            return Equals(input as Quality);
        }

        /// <summary>
        /// Returns true if Quality instances are equal
        /// </summary>
        /// <param name="input">Instance of Quality to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Quality input)
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
                    Source == input.Source ||
                    Source.Equals(input.Source)
                ) &&
                (
                    Resolution == input.Resolution ||
                    Resolution != null &&
                    Resolution.Equals(input.Resolution)
                ) &&
                (
                    Modifier == input.Modifier ||
                    Modifier.Equals(input.Modifier)
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
                hashCode = hashCode * 59 + Source.GetHashCode();
                if (Resolution != null)
                    hashCode = hashCode * 59 + Resolution.GetHashCode();
                hashCode = hashCode * 59 + Modifier.GetHashCode();
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
