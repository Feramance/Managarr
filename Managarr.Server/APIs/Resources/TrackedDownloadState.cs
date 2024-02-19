using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// Defines TrackedDownloadState
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TrackedDownloadState
    {
        /// <summary>
        /// Enum Downloading for value: downloading
        /// </summary>
        [EnumMember(Value = "downloading")]
        Downloading = 1,
        /// <summary>
        /// Enum ImportPending for value: importPending
        /// </summary>
        [EnumMember(Value = "importPending")]
        ImportPending = 2,
        /// <summary>
        /// Enum Importing for value: importing
        /// </summary>
        [EnumMember(Value = "importing")]
        Importing = 3,
        /// <summary>
        /// Enum Imported for value: imported
        /// </summary>
        [EnumMember(Value = "imported")]
        Imported = 4,
        /// <summary>
        /// Enum FailedPending for value: failedPending
        /// </summary>
        [EnumMember(Value = "failedPending")]
        FailedPending = 5,
        /// <summary>
        /// Enum Failed for value: failed
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed = 6,
        /// <summary>
        /// Enum Ignored for value: ignored
        /// </summary>
        [EnumMember(Value = "ignored")]
        Ignored = 7
    }
}
