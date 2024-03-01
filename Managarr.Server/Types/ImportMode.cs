using System.ComponentModel;

namespace Managarr.Server.Types
{
    public enum ImportMode
    {
        [Description("Auto")]
        Auto,
        [Description("Copy")]
        Copy,
        [Description("Move")]
        Move
    }
}
