using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// Defines Modifier
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Modifier
    {
        /// <summary>
        /// Enum None for value: none
        /// </summary>
        [EnumMember(Value = "none")]
        None = 1,
        /// <summary>
        /// Enum Regional for value: regional
        /// </summary>
        [EnumMember(Value = "regional")]
        Regional = 2,
        /// <summary>
        /// Enum Screener for value: screener
        /// </summary>
        [EnumMember(Value = "screener")]
        Screener = 3,
        /// <summary>
        /// Enum Rawhd for value: rawhd
        /// </summary>
        [EnumMember(Value = "rawhd")]
        Rawhd = 4,
        /// <summary>
        /// Enum Brdisk for value: brdisk
        /// </summary>
        [EnumMember(Value = "brdisk")]
        Brdisk = 5,
        /// <summary>
        /// Enum Remux for value: remux
        /// </summary>
        [EnumMember(Value = "remux")]
        Remux = 6
    }
}
