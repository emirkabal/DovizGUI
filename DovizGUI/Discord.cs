using DiscordRPC;

namespace DovizGUI
{
    public class Discord
    {
        
        public static DiscordRpcClient client;

        public static void PresenceUpdate()
        {
            client.SetPresence(new RichPresence()
            {
                Details = "USD => " + Settings.USD_SATIS,
                State = "EUR => " + Settings.EUR_SATIS,
                Assets = new Assets()
                {
                    LargeImageKey = "ekonomi",
                    LargeImageText = "GBP => " + Settings.GBP_SATIS,
                    SmallImageKey = "dolar",
                    SmallImageText = "DövizGUI " + Settings.CLIENT_VERSION
                }
            });
        }

        public static void PresenceInstall()
        {
            client = new DiscordRpcClient("505721093106040832");
            client.Initialize();
        }

        public static void PresenceDelete()
        {
            if (client == null || client.CurrentPresence == null) return;
            client.ClearPresence();
            client.Dispose();
        }



    }

}
