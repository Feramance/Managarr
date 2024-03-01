using Extensions.Hosting.AsyncInitialization;

namespace Managarr.Server.Initializers
{
    public class InitDatabase : IAsyncInitializer
    {
        public InitDatabase()
        {

        }

        public Task InitializeAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
