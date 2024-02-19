using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// Defines QualitySource
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QualitySource
    {
        /// <summary>
        /// Enum Unknown for value: unknown
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown = 1,
        /// <summary>
        /// Enum Cam for value: cam
        /// </summary>
        [EnumMember(Value = "cam")]
        Cam = 2,
        /// <summary>
        /// Enum Telesync for value: telesync
        /// </summary>
        [EnumMember(Value = "telesync")]
        Telesync = 3,
        /// <summary>
        /// Enum Telecine for value: telecine
        /// </summary>
        [EnumMember(Value = "telecine")]
        Telecine = 4,
        /// <summary>
        /// Enum Workprint for value: workprint
        /// </summary>
        [EnumMember(Value = "workprint")]
        Workprint = 5,
        /// <summary>
        /// Enum Dvd for value: dvd
        /// </summary>
        [EnumMember(Value = "dvd")]
        Dvd = 6,
        /// <summary>
        /// Enum Tv for value: tv
        /// </summary>
        [EnumMember(Value = "tv")]
        Tv = 7,
        /// <summary>
        /// Enum Webdl for value: webdl
        /// </summary>
        [EnumMember(Value = "webdl")]
        Webdl = 8,
        /// <summary>
        /// Enum Webrip for value: webrip
        /// </summary>
        [EnumMember(Value = "webrip")]
        Webrip = 9,
        /// <summary>
        /// Enum Bluray for value: bluray
        /// </summary>
        [EnumMember(Value = "bluray")]
        Bluray = 10
    }
}
