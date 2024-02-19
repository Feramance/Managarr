using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// TrackedDownloadStatusMessage
    /// </summary>
    [DataContract]
    public partial class TrackedDownloadStatusMessage : IEquatable<TrackedDownloadStatusMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedDownloadStatusMessage" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="messages">messages.</param>
        public TrackedDownloadStatusMessage(string title = default, List<string> messages = default)
        {
            Title = title;
            Messages = messages;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name = "messages", EmitDefaultValue = false)]
        public List<string> Messages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackedDownloadStatusMessage {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
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
            return Equals(input as TrackedDownloadStatusMessage);
        }

        /// <summary>
        /// Returns true if TrackedDownloadStatusMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackedDownloadStatusMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackedDownloadStatusMessage input)
        {
            if (input == null)
                return false;

            return
                (
                    Title == input.Title ||
                    Title != null &&
                    Title.Equals(input.Title)
                ) &&
                (
                    Messages == input.Messages ||
                    Messages != null &&
                    input.Messages != null &&
                    Messages.SequenceEqual(input.Messages)
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
                if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                if (Messages != null)
                    hashCode = hashCode * 59 + Messages.GetHashCode();
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
