using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// Field
    /// </summary>
    [DataContract]
    public partial class Field : IEquatable<Field>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Field" /> class.
        /// </summary>
        /// <param name="order">order.</param>
        /// <param name="name">name.</param>
        /// <param name="label">label.</param>
        /// <param name="unit">unit.</param>
        /// <param name="helpText">helpText.</param>
        /// <param name="helpTextWarning">helpTextWarning.</param>
        /// <param name="helpLink">helpLink.</param>
        /// <param name="value">value.</param>
        /// <param name="type">type.</param>
        /// <param name="advanced">advanced.</param>
        /// <param name="selectOptions">selectOptions.</param>
        /// <param name="selectOptionsProviderAction">selectOptionsProviderAction.</param>
        /// <param name="section">section.</param>
        /// <param name="hidden">hidden.</param>
        /// <param name="privacy">privacy.</param>
        /// <param name="placeholder">placeholder.</param>
        /// <param name="isFloat">isFloat.</param>
        public Field(int? order = default, string name = default, string label = default, string unit = default, string helpText = default, string helpTextWarning = default, string helpLink = default, object value = default, string type = default, bool? advanced = default, List<SelectOption> selectOptions = default, string selectOptionsProviderAction = default, string section = default, string hidden = default, PrivacyLevel privacy = default, string placeholder = default, bool? isFloat = default)
        {
            Order = order;
            Name = name;
            Label = label;
            Unit = unit;
            HelpText = helpText;
            HelpTextWarning = helpTextWarning;
            HelpLink = helpLink;
            Value = value;
            Type = type;
            Advanced = advanced;
            SelectOptions = selectOptions;
            SelectOptionsProviderAction = selectOptionsProviderAction;
            Section = section;
            Hidden = hidden;
            Privacy = privacy;
            Placeholder = placeholder;
            IsFloat = isFloat;
        }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int? Order { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name = "unit", EmitDefaultValue = false)]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or Sets HelpText
        /// </summary>
        [DataMember(Name = "helpText", EmitDefaultValue = false)]
        public string HelpText { get; set; }

        /// <summary>
        /// Gets or Sets HelpTextWarning
        /// </summary>
        [DataMember(Name = "helpTextWarning", EmitDefaultValue = false)]
        public string HelpTextWarning { get; set; }

        /// <summary>
        /// Gets or Sets HelpLink
        /// </summary>
        [DataMember(Name = "helpLink", EmitDefaultValue = false)]
        public string HelpLink { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public object Value { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Advanced
        /// </summary>
        [DataMember(Name = "advanced", EmitDefaultValue = false)]
        public bool? Advanced { get; set; }

        /// <summary>
        /// Gets or Sets SelectOptions
        /// </summary>
        [DataMember(Name = "selectOptions", EmitDefaultValue = false)]
        public List<SelectOption> SelectOptions { get; set; }

        /// <summary>
        /// Gets or Sets SelectOptionsProviderAction
        /// </summary>
        [DataMember(Name = "selectOptionsProviderAction", EmitDefaultValue = false)]
        public string SelectOptionsProviderAction { get; set; }

        /// <summary>
        /// Gets or Sets Section
        /// </summary>
        [DataMember(Name = "section", EmitDefaultValue = false)]
        public string Section { get; set; }

        /// <summary>
        /// Gets or Sets Hidden
        /// </summary>
        [DataMember(Name = "hidden", EmitDefaultValue = false)]
        public string Hidden { get; set; }

        /// <summary>
        /// Gets or Sets Privacy
        /// </summary>
        [DataMember(Name = "privacy", EmitDefaultValue = false)]
        public PrivacyLevel Privacy { get; set; }

        /// <summary>
        /// Gets or Sets Placeholder
        /// </summary>
        [DataMember(Name = "placeholder", EmitDefaultValue = false)]
        public string Placeholder { get; set; }

        /// <summary>
        /// Gets or Sets IsFloat
        /// </summary>
        [DataMember(Name = "isFloat", EmitDefaultValue = false)]
        public bool? IsFloat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Field {\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  HelpText: ").Append(HelpText).Append("\n");
            sb.Append("  HelpTextWarning: ").Append(HelpTextWarning).Append("\n");
            sb.Append("  HelpLink: ").Append(HelpLink).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Advanced: ").Append(Advanced).Append("\n");
            sb.Append("  SelectOptions: ").Append(SelectOptions).Append("\n");
            sb.Append("  SelectOptionsProviderAction: ").Append(SelectOptionsProviderAction).Append("\n");
            sb.Append("  Section: ").Append(Section).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
            sb.Append("  Placeholder: ").Append(Placeholder).Append("\n");
            sb.Append("  IsFloat: ").Append(IsFloat).Append("\n");
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
            return Equals(input as Field);
        }

        /// <summary>
        /// Returns true if Field instances are equal
        /// </summary>
        /// <param name="input">Instance of Field to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Field input)
        {
            if (input == null)
                return false;

            return
                (
                    Order == input.Order ||
                    Order != null &&
                    Order.Equals(input.Order)
                ) &&
                (
                    Name == input.Name ||
                    Name != null &&
                    Name.Equals(input.Name)
                ) &&
                (
                    Label == input.Label ||
                    Label != null &&
                    Label.Equals(input.Label)
                ) &&
                (
                    Unit == input.Unit ||
                    Unit != null &&
                    Unit.Equals(input.Unit)
                ) &&
                (
                    HelpText == input.HelpText ||
                    HelpText != null &&
                    HelpText.Equals(input.HelpText)
                ) &&
                (
                    HelpTextWarning == input.HelpTextWarning ||
                    HelpTextWarning != null &&
                    HelpTextWarning.Equals(input.HelpTextWarning)
                ) &&
                (
                    HelpLink == input.HelpLink ||
                    HelpLink != null &&
                    HelpLink.Equals(input.HelpLink)
                ) &&
                (
                    Value == input.Value ||
                    Value != null &&
                    Value.Equals(input.Value)
                ) &&
                (
                    Type == input.Type ||
                    Type != null &&
                    Type.Equals(input.Type)
                ) &&
                (
                    Advanced == input.Advanced ||
                    Advanced != null &&
                    Advanced.Equals(input.Advanced)
                ) &&
                (
                    SelectOptions == input.SelectOptions ||
                    SelectOptions != null &&
                    input.SelectOptions != null &&
                    SelectOptions.SequenceEqual(input.SelectOptions)
                ) &&
                (
                    SelectOptionsProviderAction == input.SelectOptionsProviderAction ||
                    SelectOptionsProviderAction != null &&
                    SelectOptionsProviderAction.Equals(input.SelectOptionsProviderAction)
                ) &&
                (
                    Section == input.Section ||
                    Section != null &&
                    Section.Equals(input.Section)
                ) &&
                (
                    Hidden == input.Hidden ||
                    Hidden != null &&
                    Hidden.Equals(input.Hidden)
                ) &&
                (
                    Privacy == input.Privacy ||
                    Privacy.Equals(input.Privacy)
                ) &&
                (
                    Placeholder == input.Placeholder ||
                    Placeholder != null &&
                    Placeholder.Equals(input.Placeholder)
                ) &&
                (
                    IsFloat == input.IsFloat ||
                    IsFloat != null &&
                    IsFloat.Equals(input.IsFloat)
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
                if (Order != null)
                    hashCode = hashCode * 59 + Order.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Label != null)
                    hashCode = hashCode * 59 + Label.GetHashCode();
                if (Unit != null)
                    hashCode = hashCode * 59 + Unit.GetHashCode();
                if (HelpText != null)
                    hashCode = hashCode * 59 + HelpText.GetHashCode();
                if (HelpTextWarning != null)
                    hashCode = hashCode * 59 + HelpTextWarning.GetHashCode();
                if (HelpLink != null)
                    hashCode = hashCode * 59 + HelpLink.GetHashCode();
                if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                if (Advanced != null)
                    hashCode = hashCode * 59 + Advanced.GetHashCode();
                if (SelectOptions != null)
                    hashCode = hashCode * 59 + SelectOptions.GetHashCode();
                if (SelectOptionsProviderAction != null)
                    hashCode = hashCode * 59 + SelectOptionsProviderAction.GetHashCode();
                if (Section != null)
                    hashCode = hashCode * 59 + Section.GetHashCode();
                if (Hidden != null)
                    hashCode = hashCode * 59 + Hidden.GetHashCode();
                hashCode = hashCode * 59 + Privacy.GetHashCode();
                if (Placeholder != null)
                    hashCode = hashCode * 59 + Placeholder.GetHashCode();
                if (IsFloat != null)
                    hashCode = hashCode * 59 + IsFloat.GetHashCode();
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
