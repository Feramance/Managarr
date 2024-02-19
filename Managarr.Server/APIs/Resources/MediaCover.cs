using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// MediaCover
    /// </summary>
    [DataContract]
    public partial class MediaCover : IEquatable<MediaCover>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaCover" /> class.
        /// </summary>
        /// <param name="coverType">coverType.</param>
        /// <param name="url">url.</param>
        /// <param name="remoteUrl">remoteUrl.</param>
        public MediaCover(MediaCoverTypes coverType = default, string url = default, string remoteUrl = default)
        {
            CoverType = coverType;
            Url = url;
            RemoteUrl = remoteUrl;
        }

        /// <summary>
        /// Gets or Sets CoverType
        /// </summary>
        [DataMember(Name = "coverType", EmitDefaultValue = false)]
        public MediaCoverTypes CoverType { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets RemoteUrl
        /// </summary>
        [DataMember(Name = "remoteUrl", EmitDefaultValue = false)]
        public string RemoteUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaCover {\n");
            sb.Append("  CoverType: ").Append(CoverType).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  RemoteUrl: ").Append(RemoteUrl).Append("\n");
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
            return Equals(input as MediaCover);
        }

        /// <summary>
        /// Returns true if MediaCover instances are equal
        /// </summary>
        /// <param name="input">Instance of MediaCover to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaCover input)
        {
            if (input == null)
                return false;

            return
                (
                    CoverType == input.CoverType ||
                    CoverType.Equals(input.CoverType)
                ) &&
                (
                    Url == input.Url ||
                    Url != null &&
                    Url.Equals(input.Url)
                ) &&
                (
                    RemoteUrl == input.RemoteUrl ||
                    RemoteUrl != null &&
                    RemoteUrl.Equals(input.RemoteUrl)
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
                hashCode = hashCode * 59 + CoverType.GetHashCode();
                if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
                if (RemoteUrl != null)
                    hashCode = hashCode * 59 + RemoteUrl.GetHashCode();
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
