using System;
using Exiled.API.Features;
using CustomHint.API;

namespace SteamIDPlaceholder
{
    public class SteamIDPlaceholder : Plugin<Config, Translation>
    {
        public override string Name => "SteamIDPlaceholder";
        public override string Author => "Narin";
        public override Version Version => new Version(1, 2, 0);
        public override Version RequiredExiledVersion => new Version(9, 0, 0);

        public override void OnEnabled()
        {
            PlaceholderManager.RegisterPlayerPlaceholder("{steamid64}", GetSteamID64Placeholder);
            Log.Debug("Placeholder {steamid64} registered successfully.");

            base.OnEnabled();
        }

        private string GetSteamID64Placeholder(Player player)
        {
            if (player == null)
                return Translation.NoPlayerFound;

            return player.DoNotTrack ? Translation.Steamid64Hidden : $"{player.UserId.Split('@')[0]}@steam";
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
        }
    }
}