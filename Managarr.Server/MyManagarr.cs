using Extensions.Hosting.AsyncInitialization;
using Managarr.Server.APIControllers;
using Managarr.Server.APIs;

namespace Managarr.Server
{
    public class MyManagarr
    {
        private Radarr radarr;
        public MyManagarr()
        {
            radarr = new Radarr(
            [
                new RadarrAPI(new Uri("http://192.168.0.172:7878"), "6f55c4d4ba984306b4750bf4825747dd", "Radarr"),
                new RadarrAPI(new Uri("http://192.168.0.172:7879"), "111cd69da1544173b0b95ed451fef632", "Radarr4K"),
            ]
            );
        }

        public void Run()
        {
            while (true)
            {
                var random = new Random().NextDouble();
            }
        }
    }
}
