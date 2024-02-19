using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// Defines MovieStatusType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MovieStatusType
    {
        /// <summary>
        /// Enum Tba for value: tba
        /// </summary>
        [EnumMember(Value = "tba")]
        Tba = 1,
        /// <summary>
        /// Enum Announced for value: announced
        /// </summary>
        [EnumMember(Value = "announced")]
        Announced = 2,
        /// <summary>
        /// Enum InCinemas for value: inCinemas
        /// </summary>
        [EnumMember(Value = "inCinemas")]
        InCinemas = 3,
        /// <summary>
        /// Enum Released for value: released
        /// </summary>
        [EnumMember(Value = "released")]
        Released = 4,
        /// <summary>
        /// Enum Deleted for value: deleted
        /// </summary>
        [EnumMember(Value = "deleted")]
        Deleted = 5
    }
}
