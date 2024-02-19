using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// Defines RatingType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RatingType
    {
        /// <summary>
        /// Enum User for value: user
        /// </summary>
        [EnumMember(Value = "user")]
        User = 1,
        /// <summary>
        /// Enum Critic for value: critic
        /// </summary>
        [EnumMember(Value = "critic")]
        Critic = 2
    }
}
