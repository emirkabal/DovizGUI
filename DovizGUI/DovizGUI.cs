
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
        public static String version = "1.0-stable";
        public static Boolean PresenceStatus = true;
        public static Boolean AutoUpdate = true;

        public DovizGUI()
        {
            InitializeComponent();
        }


        // LOOP
        private void loop_Tick(object sender, EventArgs e)
        {
            if(AutoUpdate == true)
            {
                this.updateDoviz();
                if (PresenceStatus == true)
                {
                    this.PresenceUpdate();
                }
                else
                {
                    this.removePresence();
                }
            }
        }

        //Güncelle - Button
        private void update_button_Click(object sender, EventArgs e)
        {
            this.updateDoviz();
            if (PresenceStatus == true)
            {
                this.PresenceUpdate();
            }
            else
            {
                this.removePresence();
            }
        }

        //Discord Rich Presence - Check Box
        private void richpresence_CheckedChanged(object sender, EventArgs e)
        {
            if(richpresence.Checked == false)
            {
                PresenceStatus = false;
            }else
            {
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

        private void DovizGUI_Load(object sender, EventArgs e)
        {
            version_label.Text = "v" + version;
            this.PresenceInstall();
            this.PresenceUpdate();
            this.updateDoviz();
        }

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
                    SmallImageText = "DövizGUI v"+version
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
            System.Diagnostics.Process.Start("https://emirkabal.xyz");
        }

        private void github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/emirkabal/DovizGUI/releases/");
        }
    }
}
