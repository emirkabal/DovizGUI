
using DiscordRPC;
using DiscordRPC.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DovizGUI
{
    public partial class DovizGUI : Form
    {
        public DiscordRpcClient client;
        public static String CLIENT_VERSION = "v1.1-stable";
        public static Boolean PresenceStatus = false;
        public static Boolean PresenceInstalled = false;
        public static Boolean AutoUpdate = true;
        //UPDATER
        public static String UPDATER_VERSION = null;
        public static String UPDATER_URL = null;
        public static String UPDATER_AUTHOR = null;
        public static String UPDATER_GITHUB = null;
        //UPDATER
        public DovizGUI()
        {
            InitializeComponent();
        }


        // LOOP
        private void loop_Tick(object sender, EventArgs e)
        {
            if(AutoUpdate == true) this.update();
        }

        //Güncelle - Button
        private void update_button_Click(object sender, EventArgs e)
        {
            this.update();
        }

        //Discord Rich Presence - Check Box
        private void richpresence_CheckedChanged(object sender, EventArgs e)
        {
            if(richpresence.Checked == false)
            {
                PresenceStatus = false;
            }else
            {
                if (PresenceInstalled == false)
                {
                    PresenceInstalled = true;
                    this.PresenceInstall();
                }
                PresenceStatus = true;
            }
        }
        //Otomatik Güncelleme - Check Box
        private void autoUpdate_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if(autoUpdate_checkbox.Checked == false)
            {
                AutoUpdate = false;
                update_button.Enabled = true;
            }
            else
            {
                AutoUpdate = true;
                update_button.Enabled = false;
            }
        }

        void update()
        {
            version_label.Text = CLIENT_VERSION;
            this.checkNetwork();
            this.checkUpdates();
            this.updateDoviz();
            if (PresenceInstalled == false) return;
            if (PresenceStatus == true) this.PresenceUpdate();
            else this.removePresence();
        }


        //LOAD
        private void DovizGUI_Load(object sender, EventArgs e)
        {
            this.update();
        }


        //DOVİZ UPDATE
        async void updateDoviz()
        {
            using (var httpClient = new HttpClient())
            {
                var str = await httpClient.GetStringAsync("https://api.doviz.com/list/C");
                dynamic json = JObject.Parse(str);

                usd_label.Text = json.value[0].key;
                eur_label.Text = json.value[1].key;
                gbp_label.Text = json.value[2].key;

                usd_ad.Text = json.value[0].adi;
                eur_ad.Text = json.value[1].adi;
                gbp_ad.Text = json.value[2].adi;

                usd_alis.Text = json.value[0].alis;
                eur_alis.Text = json.value[1].alis;
                gbp_alis.Text = json.value[2].alis;

                eur_satis.Text = json.value[1].satis;
                gbp_satis.Text = json.value[2].satis;
                usd_satis.Text = json.value[0].satis;



                //System.Diagnostics.Debug.WriteLine(json);
            }
        }
        //UPDATER
        async Task checkUpdater()
        {
            using (var httpClient = new HttpClient())
            {
                var str = await httpClient.GetStringAsync("http://api.emirkabal.xyz/dovizgui/updater.json");
                dynamic json = JObject.Parse(str);
                UPDATER_VERSION = json["version"];
                UPDATER_URL = json["url"];
                UPDATER_AUTHOR = json.links["author"];
                UPDATER_GITHUB = json.links["github"];
            }
        }
        async void checkUpdates()
        {
            await checkUpdater();
            if(UPDATER_VERSION != CLIENT_VERSION)
            {
                update_version.Text = UPDATER_VERSION;
                update_label.Visible = true;
                update_version.Visible = true;
                updater_button.Enabled = true;
            }
        }

        //İNTERNET KONTROL
        void checkNetwork()
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                this.disableAutoUpdater();
                MessageBox.Show("Programın çalışabilmesi için lütfen internet bağlatınızı kontrol edin ve çalıştığından emin olun.",
                "Uyarı.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                return;
            }
        }

        //disable auto update
        void disableAutoUpdater()
        {
            AutoUpdate = false;
            autoUpdate_checkbox.Checked = false;
            update_button.Enabled = true;
        }

        //DİSCORD
        void PresenceUpdate()
        {
            client.SetPresence(new RichPresence()
            {
                Details = "USD => "+usd_alis.Text,
                State = "EUR => "+eur_alis.Text,
                Assets = new Assets()
                {
                    LargeImageKey = "ekonomi",
                    LargeImageText = "GBP => "+gbp_alis.Text,
                    SmallImageKey = "dolar",
                    SmallImageText = "DövizGUI "+CLIENT_VERSION
                }
            });
        }

        void PresenceInstall()
        {
            client = new DiscordRpcClient("505721093106040832");
            client.Initialize();
        }
  
        void removePresence()
        {
            client.ClearPresence();
            client.Initialize();
        }


        //Gereksiz
        private void author_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(UPDATER_AUTHOR);
        }
        private void github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(UPDATER_GITHUB);
        }

        private void updater_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(UPDATER_URL);
        }
    }
}
