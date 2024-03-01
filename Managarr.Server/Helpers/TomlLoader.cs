using Tomlyn;
using Tomlyn.Model;

namespace Managarr.Server.Helpers
{
    public class TomlLoader
    {
        public TomlTable config { get; set; }
        public TomlLoader(string path)
        {
            string configString = File.ReadAllText(path);
            config = Toml.ToModel(configString);
        }
    }
}
