using Exiled.API.Interfaces;
using System.ComponentModel;

namespace SteamIDPlaceholder
{
    public class Translation : ITranslation
    {
        [Description("STEAMID64 is hidden (DNT enabled).")]
        public string Steamid64Hidden { get; set; } = "Hidden";

        [Description("No player found.")]
        public string NoPlayerFound { get; set; } = "No player found";
    }
}