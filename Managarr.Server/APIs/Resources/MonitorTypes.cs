using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// Defines MonitorTypes
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MonitorTypes
    {
        /// <summary>
        /// Enum MovieOnly for value: movieOnly
        /// </summary>
        [EnumMember(Value = "movieOnly")]
        MovieOnly = 1,
        /// <summary>
        /// Enum MovieAndCollection for value: movieAndCollection
        /// </summary>
        [EnumMember(Value = "movieAndCollection")]
        MovieAndCollection = 2,
        /// <summary>
        /// Enum None for value: none
        /// </summary>
        [EnumMember(Value = "none")]
        None = 3
    }
}
