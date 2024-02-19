using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// Defines SourceType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SourceType
    {
        /// <summary>
        /// Enum Tmdb for value: tmdb
        /// </summary>
        [EnumMember(Value = "tmdb")]
        Tmdb = 1,
        /// <summary>
        /// Enum Mappings for value: mappings
        /// </summary>
        [EnumMember(Value = "mappings")]
        Mappings = 2,
        /// <summary>
        /// Enum User for value: user
        /// </summary>
        [EnumMember(Value = "user")]
        User = 3,
        /// <summary>
        /// Enum Indexer for value: indexer
        /// </summary>
        [EnumMember(Value = "indexer")]
        Indexer = 4
    }
}
