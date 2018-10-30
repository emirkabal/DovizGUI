
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
        public static String CLIENT_VERSION = "v1.2-stable";
        public static Boolean PresenceStatus = false;
        public static Boolean AutoUpdate = true;
        //UPDATER
        public static String UPDATER_VERSION = null;
        public static String UPDATER_URL = null;
        public static String UPDATER_AUTHOR = null;
        public static String UPDATER_GITHUB = null;
        //UPDATER
        //DOVIZ KURLARI
        public String USD_ALIS = null;
        public String GBP_ALIS = null;
        public String EUR_ALIS = null;

        public String USD_SATIS = null;
        public String EUR_SATIS = null;
        public String GBP_SATIS = null;
        //DOVIZ KURLARI
        public DovizGUI()
        {
            InitializeComponent();
        }


        // LOOP
        private void loop_Tick(object sender, EventArgs e)
        {
            if (AutoUpdate == true)
            {
                //if (loop_bar.Value == loop_bar.Maximum) loop_bar.Value = 0;
                //loop_bar.Value += 1;
                this.update();
            }
        }

        //Güncelle - Button
        private void update_button_Click(object sender, EventArgs e)
        {
            this.update();
        }


        void update()
        {
            version_label.Text = CLIENT_VERSION;
            this.checkNetwork();
            this.checkUpdates();
            this.updateDoviz();
            if (PresenceStatus == true) Discord.PresenceUpdate();
        }


        //LOAD
        private void DovizGUI_Load(object sender, EventArgs e)
        {
            loop_bar.Visible = false;
            //loop_bar.Maximum = loop.Interval / 1000;
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

                if (USD_ALIS != null && USD_SATIS != null && EUR_ALIS != null && EUR_SATIS != null && GBP_ALIS != null && GBP_SATIS != null)
                {
                    //long usd_alis_client = long.Parse(usd_alis.Text);
                    if(float.Parse(usd_alis.Text) > float.Parse(USD_ALIS))
                    {
                        usd_label.ForeColor = System.Drawing.Color.LightGreen;
                        usd_ad.ForeColor = System.Drawing.Color.LightGreen;
                        usd_alis_text.ForeColor = System.Drawing.Color.LightGreen;
                        usd_alis.ForeColor = System.Drawing.Color.LightGreen;
                    }
                    if(float.Parse(usd_satis.Text) > float.Parse(USD_SATIS))
                    {
                        usd_label.ForeColor = System.Drawing.Color.LightGreen;
                        usd_ad.ForeColor = System.Drawing.Color.LightGreen;
                        usd_satis_text.ForeColor = System.Drawing.Color.LightGreen;
                        usd_satis.ForeColor = System.Drawing.Color.LightGreen;
                    }
                    if (float.Parse(eur_alis.Text) > float.Parse(EUR_ALIS))
                    {
                        eur_label.ForeColor = System.Drawing.Color.LightGreen;
                        eur_ad.ForeColor = System.Drawing.Color.LightGreen;
                        eur_alis_text.ForeColor = System.Drawing.Color.LightGreen;
                        eur_alis.ForeColor = System.Drawing.Color.LightGreen;
                    }
                    if (float.Parse(eur_satis.Text) > float.Parse(EUR_SATIS))
                    {
                        eur_label.ForeColor = System.Drawing.Color.LightGreen;
                        eur_ad.ForeColor = System.Drawing.Color.LightGreen;
                        eur_satis_text.ForeColor = System.Drawing.Color.LightGreen;
                        eur_satis.ForeColor = System.Drawing.Color.LightGreen;
                    }
                    if (float.Parse(gbp_alis.Text) > float.Parse(GBP_ALIS))
                    {
                        gbp_label.ForeColor = System.Drawing.Color.LightGreen;
                        gbp_ad.ForeColor = System.Drawing.Color.LightGreen;
                        gbp_alis_text.ForeColor = System.Drawing.Color.LightGreen;
                        gbp_alis.ForeColor = System.Drawing.Color.LightGreen;
                    }
                    if (float.Parse(gbp_satis.Text) > float.Parse(GBP_SATIS))
                    {
                        gbp_label.ForeColor = System.Drawing.Color.LightGreen;
                        gbp_ad.ForeColor = System.Drawing.Color.LightGreen;
                        gbp_satis_text.ForeColor = System.Drawing.Color.LightGreen;
                        gbp_satis.ForeColor = System.Drawing.Color.LightGreen;
                    }


                    if (float.Parse(usd_alis.Text) < float.Parse(USD_ALIS))
                    {
                        usd_label.ForeColor = System.Drawing.Color.Red;
                        usd_ad.ForeColor = System.Drawing.Color.Red;
                        usd_alis_text.ForeColor = System.Drawing.Color.Red;
                        usd_alis.ForeColor = System.Drawing.Color.Red;
                    }
                    if (float.Parse(usd_satis.Text) < float.Parse(USD_SATIS))
                    {
                        usd_label.ForeColor = System.Drawing.Color.Red;
                        usd_ad.ForeColor = System.Drawing.Color.Red;
                        usd_satis_text.ForeColor = System.Drawing.Color.Red;
                        usd_satis.ForeColor = System.Drawing.Color.Red;
                    }

                    if (float.Parse(eur_alis.Text) < float.Parse(EUR_ALIS))
                    {
                        eur_label.ForeColor = System.Drawing.Color.Red;
                        eur_ad.ForeColor = System.Drawing.Color.Red;
                        eur_alis_text.ForeColor = System.Drawing.Color.Red;
                        eur_alis.ForeColor = System.Drawing.Color.Red;
                    }
                    if (float.Parse(eur_satis.Text) < float.Parse(EUR_SATIS))
                    {
                        eur_label.ForeColor = System.Drawing.Color.Red;
                        eur_ad.ForeColor = System.Drawing.Color.Red;
                        eur_satis_text.ForeColor = System.Drawing.Color.Red;
                        eur_satis.ForeColor = System.Drawing.Color.Red;
                    }

                    if (float.Parse(gbp_alis.Text) < float.Parse(GBP_ALIS))
                    {
                        gbp_label.ForeColor = System.Drawing.Color.Red;
                        gbp_ad.ForeColor = System.Drawing.Color.Red;
                        gbp_alis_text.ForeColor = System.Drawing.Color.Red;
                        gbp_alis.ForeColor = System.Drawing.Color.Red;
                    }
                    if (float.Parse(gbp_satis.Text) < float.Parse(GBP_SATIS))
                    {
                        gbp_label.ForeColor = System.Drawing.Color.Red;
                        gbp_ad.ForeColor = System.Drawing.Color.Red;
                        gbp_satis_text.ForeColor = System.Drawing.Color.Red;
                        gbp_satis.ForeColor = System.Drawing.Color.Red;
                    }
                }

                USD_ALIS = usd_alis.Text;
                EUR_ALIS = eur_alis.Text;
                GBP_ALIS = gbp_alis.Text;

                USD_SATIS = usd_satis.Text;
                EUR_SATIS = eur_satis.Text;
                GBP_SATIS = gbp_satis.Text;
                



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
            try { await checkUpdater(); }
            catch (Exception) { return; }

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
                SettingsWindow settings = new SettingsWindow();
                settings.disableAutoUpdater();
                MessageBox.Show("Programın çalışabilmesi için lütfen internet bağlatınızı kontrol edin ve çalıştığından emin olun.",
                "Uyarı!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                return;
            }
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

        private void settings_button_Click(object sender, EventArgs e)
        {
            SettingsWindow settings = new SettingsWindow();
            settings.Show();
        }




    }
}
