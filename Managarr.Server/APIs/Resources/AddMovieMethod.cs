using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// Defines AddMovieMethod
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AddMovieMethod
    {
        /// <summary>
        /// Enum Manual for value: manual
        /// </summary>
        [EnumMember(Value = "manual")]
        Manual = 1,
        /// <summary>
        /// Enum List for value: list
        /// </summary>
        [EnumMember(Value = "list")]
        List = 2,
        /// <summary>
        /// Enum Collection for value: collection
        /// </summary>
        [EnumMember(Value = "collection")]
        Collection = 3
    }
}
