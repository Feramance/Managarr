using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// QueueResourcePagingResource
    /// </summary>
    [DataContract]
    public partial class QueueResourcePagingResource : IEquatable<QueueResourcePagingResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueResourcePagingResource" /> class.
        /// </summary>
        /// <param name="page">page.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="sortKey">sortKey.</param>
        /// <param name="sortDirection">sortDirection.</param>
        /// <param name="totalRecords">totalRecords.</param>
        /// <param name="records">records.</param>
        public QueueResourcePagingResource(int? page = default, int? pageSize = default, string sortKey = default, SortDirection sortDirection = SortDirection.Default, int? totalRecords = default, List<QueueResource> records = default)
        {
            Page = page;
            PageSize = pageSize;
            SortKey = sortKey;
            SortDirection = sortDirection;
            TotalRecords = totalRecords;
            Records = records;
        }

        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public int? Page { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name = "pageSize", EmitDefaultValue = false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Gets or Sets SortKey
        /// </summary>
        [DataMember(Name = "sortKey", EmitDefaultValue = false)]
        public string SortKey { get; set; }

        /// <summary>
        /// Gets or Sets SortDirection
        /// </summary>
        [DataMember(Name = "sortDirection", EmitDefaultValue = false)]
        public SortDirection SortDirection { get; set; }

        /// <summary>
        /// Gets or Sets TotalRecords
        /// </summary>
        [DataMember(Name = "totalRecords", EmitDefaultValue = false)]
        public int? TotalRecords { get; set; }

        /// <summary>
        /// Gets or Sets Records
        /// </summary>
        [DataMember(Name = "records", EmitDefaultValue = false)]
        public List<QueueResource> Records { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueResourcePagingResource {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  SortKey: ").Append(SortKey).Append("\n");
            sb.Append("  SortDirection: ").Append(SortDirection).Append("\n");
            sb.Append("  TotalRecords: ").Append(TotalRecords).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
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
            return Equals(input as QueueResourcePagingResource);
        }

        /// <summary>
        /// Returns true if QueueResourcePagingResource instances are equal
        /// </summary>
        /// <param name="input">Instance of QueueResourcePagingResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueResourcePagingResource input)
        {
            if (input == null)
                return false;

            return
                (
                    Page == input.Page ||
                    Page != null &&
                    Page.Equals(input.Page)
                ) &&
                (
                    PageSize == input.PageSize ||
                    PageSize != null &&
                    PageSize.Equals(input.PageSize)
                ) &&
                (
                    SortKey == input.SortKey ||
                    SortKey != null &&
                    SortKey.Equals(input.SortKey)
                ) &&
                (
                    SortDirection == input.SortDirection ||
                    SortDirection.Equals(input.SortDirection)
                ) &&
                (
                    TotalRecords == input.TotalRecords ||
                    TotalRecords != null &&
                    TotalRecords.Equals(input.TotalRecords)
                ) &&
                (
                    Records == input.Records ||
                    Records != null &&
                    input.Records != null &&
                    Records.SequenceEqual(input.Records)
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
                if (Page != null)
                    hashCode = hashCode * 59 + Page.GetHashCode();
                if (PageSize != null)
                    hashCode = hashCode * 59 + PageSize.GetHashCode();
                if (SortKey != null)
                    hashCode = hashCode * 59 + SortKey.GetHashCode();
                hashCode = hashCode * 59 + SortDirection.GetHashCode();
                if (TotalRecords != null)
                    hashCode = hashCode * 59 + TotalRecords.GetHashCode();
                if (Records != null)
                    hashCode = hashCode * 59 + Records.GetHashCode();
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
