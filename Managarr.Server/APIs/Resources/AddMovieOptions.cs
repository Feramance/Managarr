using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// AddMovieOptions
    /// </summary>
    [DataContract]
    public partial class AddMovieOptions : IEquatable<AddMovieOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddMovieOptions" /> class.
        /// </summary>
        /// <param name="ignoreEpisodesWithFiles">ignoreEpisodesWithFiles.</param>
        /// <param name="ignoreEpisodesWithoutFiles">ignoreEpisodesWithoutFiles.</param>
        /// <param name="monitor">monitor.</param>
        /// <param name="searchForMovie">searchForMovie.</param>
        /// <param name="addMethod">addMethod.</param>
        public AddMovieOptions(bool? ignoreEpisodesWithFiles = default, bool? ignoreEpisodesWithoutFiles = default, MonitorTypes monitor = default, bool? searchForMovie = default, AddMovieMethod addMethod = default)
        {
            IgnoreEpisodesWithFiles = ignoreEpisodesWithFiles;
            IgnoreEpisodesWithoutFiles = ignoreEpisodesWithoutFiles;
            Monitor = monitor;
            SearchForMovie = searchForMovie;
            AddMethod = addMethod;
        }

        /// <summary>
        /// Gets or Sets IgnoreEpisodesWithFiles
        /// </summary>
        [DataMember(Name = "ignoreEpisodesWithFiles", EmitDefaultValue = false)]
        public bool? IgnoreEpisodesWithFiles { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreEpisodesWithoutFiles
        /// </summary>
        [DataMember(Name = "ignoreEpisodesWithoutFiles", EmitDefaultValue = false)]
        public bool? IgnoreEpisodesWithoutFiles { get; set; }

        /// <summary>
        /// Gets or Sets Monitor
        /// </summary>
        [DataMember(Name = "monitor", EmitDefaultValue = false)]
        public MonitorTypes Monitor { get; set; }

        /// <summary>
        /// Gets or Sets SearchForMovie
        /// </summary>
        [DataMember(Name = "searchForMovie", EmitDefaultValue = false)]
        public bool? SearchForMovie { get; set; }

        /// <summary>
        /// Gets or Sets AddMethod
        /// </summary>
        [DataMember(Name = "addMethod", EmitDefaultValue = false)]
        public AddMovieMethod AddMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddMovieOptions {\n");
            sb.Append("  IgnoreEpisodesWithFiles: ").Append(IgnoreEpisodesWithFiles).Append("\n");
            sb.Append("  IgnoreEpisodesWithoutFiles: ").Append(IgnoreEpisodesWithoutFiles).Append("\n");
            sb.Append("  Monitor: ").Append(Monitor).Append("\n");
            sb.Append("  SearchForMovie: ").Append(SearchForMovie).Append("\n");
            sb.Append("  AddMethod: ").Append(AddMethod).Append("\n");
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
            return Equals(input as AddMovieOptions);
        }

        /// <summary>
        /// Returns true if AddMovieOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of AddMovieOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddMovieOptions input)
        {
            if (input == null)
                return false;

            return
                (
                    IgnoreEpisodesWithFiles == input.IgnoreEpisodesWithFiles ||
                    IgnoreEpisodesWithFiles != null &&
                    IgnoreEpisodesWithFiles.Equals(input.IgnoreEpisodesWithFiles)
                ) &&
                (
                    IgnoreEpisodesWithoutFiles == input.IgnoreEpisodesWithoutFiles ||
                    IgnoreEpisodesWithoutFiles != null &&
                    IgnoreEpisodesWithoutFiles.Equals(input.IgnoreEpisodesWithoutFiles)
                ) &&
                (
                    Monitor == input.Monitor ||
                    Monitor.Equals(input.Monitor)
                ) &&
                (
                    SearchForMovie == input.SearchForMovie ||
                    SearchForMovie != null &&
                    SearchForMovie.Equals(input.SearchForMovie)
                ) &&
                (
                    AddMethod == input.AddMethod ||
                    AddMethod.Equals(input.AddMethod)
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
                if (IgnoreEpisodesWithFiles != null)
                    hashCode = hashCode * 59 + IgnoreEpisodesWithFiles.GetHashCode();
                if (IgnoreEpisodesWithoutFiles != null)
                    hashCode = hashCode * 59 + IgnoreEpisodesWithoutFiles.GetHashCode();
                hashCode = hashCode * 59 + Monitor.GetHashCode();
                if (SearchForMovie != null)
                    hashCode = hashCode * 59 + SearchForMovie.GetHashCode();
                hashCode = hashCode * 59 + AddMethod.GetHashCode();
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
