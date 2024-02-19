using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// Defines SortDirection
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortDirection
    {
        /// <summary>
        /// Enum Default for value: default
        /// </summary>
        [EnumMember(Value = "default")]
        Default = 1,
        /// <summary>
        /// Enum Ascending for value: ascending
        /// </summary>
        [EnumMember(Value = "ascending")]
        Ascending = 2,
        /// <summary>
        /// Enum Descending for value: descending
        /// </summary>
        [EnumMember(Value = "descending")]
        Descending = 3
    }
}
