using Extensions.Hosting.AsyncInitialization;
using Managarr.Server.Helpers;

namespace Managarr.Server.Initializers
{
    public class InitConfig : IAsyncInitializer
    {
        public Task InitializeAsync(CancellationToken cancellationToken)
        {
            new TomlLoader(@"G:\Managarr\Managarr.Server\config.toml");
            return Task.CompletedTask;
        }
    }
}
