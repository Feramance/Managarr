using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// Ratings
    /// </summary>
    [DataContract]
    public partial class Ratings : IEquatable<Ratings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ratings" /> class.
        /// </summary>
        /// <param name="imdb">imdb.</param>
        /// <param name="tmdb">tmdb.</param>
        /// <param name="metacritic">metacritic.</param>
        /// <param name="rottenTomatoes">rottenTomatoes.</param>
        public Ratings(RatingChild imdb = default, RatingChild tmdb = default, RatingChild metacritic = default, RatingChild rottenTomatoes = default)
        {
            Imdb = imdb;
            Tmdb = tmdb;
            Metacritic = metacritic;
            RottenTomatoes = rottenTomatoes;
        }

        /// <summary>
        /// Gets or Sets Imdb
        /// </summary>
        [DataMember(Name = "imdb", EmitDefaultValue = false)]
        public RatingChild Imdb { get; set; }

        /// <summary>
        /// Gets or Sets Tmdb
        /// </summary>
        [DataMember(Name = "tmdb", EmitDefaultValue = false)]
        public RatingChild Tmdb { get; set; }

        /// <summary>
        /// Gets or Sets Metacritic
        /// </summary>
        [DataMember(Name = "metacritic", EmitDefaultValue = false)]
        public RatingChild Metacritic { get; set; }

        /// <summary>
        /// Gets or Sets RottenTomatoes
        /// </summary>
        [DataMember(Name = "rottenTomatoes", EmitDefaultValue = false)]
        public RatingChild RottenTomatoes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ratings {\n");
            sb.Append("  Imdb: ").Append(Imdb).Append("\n");
            sb.Append("  Tmdb: ").Append(Tmdb).Append("\n");
            sb.Append("  Metacritic: ").Append(Metacritic).Append("\n");
            sb.Append("  RottenTomatoes: ").Append(RottenTomatoes).Append("\n");
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
            return Equals(input as Ratings);
        }

        /// <summary>
        /// Returns true if Ratings instances are equal
        /// </summary>
        /// <param name="input">Instance of Ratings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ratings input)
        {
            if (input == null)
                return false;

            return
                (
                    Imdb == input.Imdb ||
                    Imdb != null &&
                    Imdb.Equals(input.Imdb)
                ) &&
                (
                    Tmdb == input.Tmdb ||
                    Tmdb != null &&
                    Tmdb.Equals(input.Tmdb)
                ) &&
                (
                    Metacritic == input.Metacritic ||
                    Metacritic != null &&
                    Metacritic.Equals(input.Metacritic)
                ) &&
                (
                    RottenTomatoes == input.RottenTomatoes ||
                    RottenTomatoes != null &&
                    RottenTomatoes.Equals(input.RottenTomatoes)
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
                if (Imdb != null)
                    hashCode = hashCode * 59 + Imdb.GetHashCode();
                if (Tmdb != null)
                    hashCode = hashCode * 59 + Tmdb.GetHashCode();
                if (Metacritic != null)
                    hashCode = hashCode * 59 + Metacritic.GetHashCode();
                if (RottenTomatoes != null)
                    hashCode = hashCode * 59 + RottenTomatoes.GetHashCode();
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
