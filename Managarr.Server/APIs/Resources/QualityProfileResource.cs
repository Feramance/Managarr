using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// QualityProfileResource
    /// </summary>
    [DataContract]
    public partial class QualityProfileResource : IEquatable<QualityProfileResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QualityProfileResource" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="upgradeAllowed">upgradeAllowed.</param>
        /// <param name="cutoff">cutoff.</param>
        /// <param name="items">items.</param>
        /// <param name="minFormatScore">minFormatScore.</param>
        /// <param name="cutoffFormatScore">cutoffFormatScore.</param>
        /// <param name="formatItems">formatItems.</param>
        /// <param name="language">language.</param>
        public QualityProfileResource(int? id = default, string name = default, bool? upgradeAllowed = default, int? cutoff = default, List<QualityProfileQualityItemResource> items = default, int? minFormatScore = default, int? cutoffFormatScore = default, List<ProfileFormatItemResource> formatItems = default, Language language = default)
        {
            Id = id;
            Name = name;
            UpgradeAllowed = upgradeAllowed;
            Cutoff = cutoff;
            Items = items;
            MinFormatScore = minFormatScore;
            CutoffFormatScore = cutoffFormatScore;
            FormatItems = formatItems;
            Language = language;
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
        /// Gets or Sets UpgradeAllowed
        /// </summary>
        [DataMember(Name = "upgradeAllowed", EmitDefaultValue = false)]
        public bool? UpgradeAllowed { get; set; }

        /// <summary>
        /// Gets or Sets Cutoff
        /// </summary>
        [DataMember(Name = "cutoff", EmitDefaultValue = false)]
        public int? Cutoff { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<QualityProfileQualityItemResource> Items { get; set; }

        /// <summary>
        /// Gets or Sets MinFormatScore
        /// </summary>
        [DataMember(Name = "minFormatScore", EmitDefaultValue = false)]
        public int? MinFormatScore { get; set; }

        /// <summary>
        /// Gets or Sets CutoffFormatScore
        /// </summary>
        [DataMember(Name = "cutoffFormatScore", EmitDefaultValue = false)]
        public int? CutoffFormatScore { get; set; }

        /// <summary>
        /// Gets or Sets FormatItems
        /// </summary>
        [DataMember(Name = "formatItems", EmitDefaultValue = false)]
        public List<ProfileFormatItemResource> FormatItems { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public Language Language { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QualityProfileResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UpgradeAllowed: ").Append(UpgradeAllowed).Append("\n");
            sb.Append("  Cutoff: ").Append(Cutoff).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  MinFormatScore: ").Append(MinFormatScore).Append("\n");
            sb.Append("  CutoffFormatScore: ").Append(CutoffFormatScore).Append("\n");
            sb.Append("  FormatItems: ").Append(FormatItems).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
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
            return Equals(input as QualityProfileResource);
        }

        /// <summary>
        /// Returns true if QualityProfileResource instances are equal
        /// </summary>
        /// <param name="input">Instance of QualityProfileResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QualityProfileResource input)
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
                    UpgradeAllowed == input.UpgradeAllowed ||
                    UpgradeAllowed != null &&
                    UpgradeAllowed.Equals(input.UpgradeAllowed)
                ) &&
                (
                    Cutoff == input.Cutoff ||
                    Cutoff != null &&
                    Cutoff.Equals(input.Cutoff)
                ) &&
                (
                    Items == input.Items ||
                    Items != null &&
                    input.Items != null &&
                    Items.SequenceEqual(input.Items)
                ) &&
                (
                    MinFormatScore == input.MinFormatScore ||
                    MinFormatScore != null &&
                    MinFormatScore.Equals(input.MinFormatScore)
                ) &&
                (
                    CutoffFormatScore == input.CutoffFormatScore ||
                    CutoffFormatScore != null &&
                    CutoffFormatScore.Equals(input.CutoffFormatScore)
                ) &&
                (
                    FormatItems == input.FormatItems ||
                    FormatItems != null &&
                    input.FormatItems != null &&
                    FormatItems.SequenceEqual(input.FormatItems)
                ) &&
                (
                    Language == input.Language ||
                    Language != null &&
                    Language.Equals(input.Language)
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
                if (UpgradeAllowed != null)
                    hashCode = hashCode * 59 + UpgradeAllowed.GetHashCode();
                if (Cutoff != null)
                    hashCode = hashCode * 59 + Cutoff.GetHashCode();
                if (Items != null)
                    hashCode = hashCode * 59 + Items.GetHashCode();
                if (MinFormatScore != null)
                    hashCode = hashCode * 59 + MinFormatScore.GetHashCode();
                if (CutoffFormatScore != null)
                    hashCode = hashCode * 59 + CutoffFormatScore.GetHashCode();
                if (FormatItems != null)
                    hashCode = hashCode * 59 + FormatItems.GetHashCode();
                if (Language != null)
                    hashCode = hashCode * 59 + Language.GetHashCode();
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
