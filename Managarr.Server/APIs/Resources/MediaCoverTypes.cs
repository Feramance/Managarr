using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// Defines MediaCoverTypes
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MediaCoverTypes
    {
        /// <summary>
        /// Enum Unknown for value: unknown
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown = 1,
        /// <summary>
        /// Enum Poster for value: poster
        /// </summary>
        [EnumMember(Value = "poster")]
        Poster = 2,
        /// <summary>
        /// Enum Banner for value: banner
        /// </summary>
        [EnumMember(Value = "banner")]
        Banner = 3,
        /// <summary>
        /// Enum Fanart for value: fanart
        /// </summary>
        [EnumMember(Value = "fanart")]
        Fanart = 4,
        /// <summary>
        /// Enum Screenshot for value: screenshot
        /// </summary>
        [EnumMember(Value = "screenshot")]
        Screenshot = 5,
        /// <summary>
        /// Enum Headshot for value: headshot
        /// </summary>
        [EnumMember(Value = "headshot")]
        Headshot = 6,
        /// <summary>
        /// Enum Clearlogo for value: clearlogo
        /// </summary>
        [EnumMember(Value = "clearlogo")]
        Clearlogo = 7
    }
}
