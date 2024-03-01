using System.ComponentModel;

namespace Managarr.Server.Types
{
    public enum QueueType
    {
        [Description("Movie")]
        Movie,
        [Description("Series")]
        Series,
        [Description("Episode")]
        Episode
    }
}
