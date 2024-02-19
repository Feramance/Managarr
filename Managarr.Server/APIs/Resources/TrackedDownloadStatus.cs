using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// Defines TrackedDownloadStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TrackedDownloadStatus
    {
        /// <summary>
        /// Enum Ok for value: ok
        /// </summary>
        [EnumMember(Value = "ok")]
        Ok = 1,
        /// <summary>
        /// Enum Warning for value: warning
        /// </summary>
        [EnumMember(Value = "warning")]
        Warning = 2,
        /// <summary>
        /// Enum Error for value: error
        /// </summary>
        [EnumMember(Value = "error")]
        Error = 3
    }
}
