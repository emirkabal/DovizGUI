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
                Details = "USD => " + DovizGUI.usd_satis.Text,
                State = "EUR => " + DovizGUI.eur_satis.Text,
                Assets = new Assets()
                {
                    LargeImageKey = "ekonomi",
                    LargeImageText = "GBP => " + DovizGUI.gbp_satis.Text,
                    SmallImageKey = "dolar",
                    SmallImageText = "DövizGUI " + DovizGUI.CLIENT_VERSION
                }
            });
        }

        public static void PresenceInstall()
        {
            client = new DiscordRpcClient("505721093106040832");
            client.Initialize();
            PresenceUpdate();
        }

        public static void PresenceDelete()
        {
            client.ClearPresence();
            client.Dispose();
        }



    }

}
