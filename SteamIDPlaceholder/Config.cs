using Exiled.API.Interfaces;
using System.ComponentModel;

namespace SteamIDPlaceholder
{
    public class Config : IConfig
    {
        [Description("Placeholder enabled (bool)?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Debug mode.")]
        public bool Debug { get; set; } = false;
    }
}