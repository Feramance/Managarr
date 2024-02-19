using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// Defines PrivacyLevel
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrivacyLevel
    {
        /// <summary>
        /// Enum Normal for value: normal
        /// </summary>
        [EnumMember(Value = "normal")]
        Normal = 1,
        /// <summary>
        /// Enum Password for value: password
        /// </summary>
        [EnumMember(Value = "password")]
        Password = 2,
        /// <summary>
        /// Enum ApiKey for value: apiKey
        /// </summary>
        [EnumMember(Value = "apiKey")]
        ApiKey = 3,
        /// <summary>
        /// Enum UserName for value: userName
        /// </summary>
        [EnumMember(Value = "userName")]
        UserName = 4
    }
}
