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
using System.Threading;

namespace DovizGUI
{
    public partial class DovizGUI : Form
    {

        Thread th;

        //DOVIZ KURLARI
        public DovizGUI()
        {
            InitializeComponent();
        }


        // LOOP
        private void loop_Tick(object sender, EventArgs e)
        {
            if (Settings.AutoUpdate == true)
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


        async void update()
        {
            version_label.Text = Settings.CLIENT_VERSION;
            this.checkNetwork();
            this.checkUpdates();
            await this.updateDoviz();
            if(Settings.PresenceStatus == true) Discord.PresenceUpdate();
        }


        //LOAD
        private void DovizGUI_Load(object sender, EventArgs e)
        {
            checkLoad();
            loop_bar.Visible = false;
            this.update();
        }


        //DOVİZ UPDATE
        async Task updateDoviz()
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

                if (Settings.USD_ALIS != null && Settings.USD_SATIS != null && Settings.EUR_ALIS != null && Settings.EUR_SATIS != null && Settings.GBP_ALIS != null && Settings.GBP_SATIS != null)
                {
                    //long usd_alis_client = long.Parse(usd_alis.Text);
                    if(float.Parse(usd_alis.Text) > float.Parse(Settings.USD_ALIS))
                    {
                        usd_label.ForeColor = System.Drawing.Color.LightGreen;
                        usd_ad.ForeColor = System.Drawing.Color.LightGreen;
                        usd_alis_text.ForeColor = System.Drawing.Color.LightGreen;
                        usd_alis.ForeColor = System.Drawing.Color.LightGreen;
                    }
                    if(float.Parse(usd_satis.Text) > float.Parse(Settings.USD_SATIS))
                    {
                        usd_label.ForeColor = System.Drawing.Color.LightGreen;
                        usd_ad.ForeColor = System.Drawing.Color.LightGreen;
                        usd_satis_text.ForeColor = System.Drawing.Color.LightGreen;
                        usd_satis.ForeColor = System.Drawing.Color.LightGreen;
                    }
                    if (float.Parse(eur_alis.Text) > float.Parse(Settings.EUR_ALIS))
                    {
                        eur_label.ForeColor = System.Drawing.Color.LightGreen;
                        eur_ad.ForeColor = System.Drawing.Color.LightGreen;
                        eur_alis_text.ForeColor = System.Drawing.Color.LightGreen;
                        eur_alis.ForeColor = System.Drawing.Color.LightGreen;
                    }
                    if (float.Parse(eur_satis.Text) > float.Parse(Settings.EUR_SATIS))
                    {
                        eur_label.ForeColor = System.Drawing.Color.LightGreen;
                        eur_ad.ForeColor = System.Drawing.Color.LightGreen;
                        eur_satis_text.ForeColor = System.Drawing.Color.LightGreen;
                        eur_satis.ForeColor = System.Drawing.Color.LightGreen;
                    }
                    if (float.Parse(gbp_alis.Text) > float.Parse(Settings.GBP_ALIS))
                    {
                        gbp_label.ForeColor = System.Drawing.Color.LightGreen;
                        gbp_ad.ForeColor = System.Drawing.Color.LightGreen;
                        gbp_alis_text.ForeColor = System.Drawing.Color.LightGreen;
                        gbp_alis.ForeColor = System.Drawing.Color.LightGreen;
                    }
                    if (float.Parse(gbp_satis.Text) > float.Parse(Settings.GBP_SATIS))
                    {
                        gbp_label.ForeColor = System.Drawing.Color.LightGreen;
                        gbp_ad.ForeColor = System.Drawing.Color.LightGreen;
                        gbp_satis_text.ForeColor = System.Drawing.Color.LightGreen;
                        gbp_satis.ForeColor = System.Drawing.Color.LightGreen;
                    }


                    if (float.Parse(usd_alis.Text) < float.Parse(Settings.USD_ALIS))
                    {
                        usd_label.ForeColor = System.Drawing.Color.Red;
                        usd_ad.ForeColor = System.Drawing.Color.Red;
                        usd_alis_text.ForeColor = System.Drawing.Color.Red;
                        usd_alis.ForeColor = System.Drawing.Color.Red;
                    }
                    if (float.Parse(usd_satis.Text) < float.Parse(Settings.USD_SATIS))
                    {
                        usd_label.ForeColor = System.Drawing.Color.Red;
                        usd_ad.ForeColor = System.Drawing.Color.Red;
                        usd_satis_text.ForeColor = System.Drawing.Color.Red;
                        usd_satis.ForeColor = System.Drawing.Color.Red;
                    }

                    if (float.Parse(eur_alis.Text) < float.Parse(Settings.EUR_ALIS))
                    {
                        eur_label.ForeColor = System.Drawing.Color.Red;
                        eur_ad.ForeColor = System.Drawing.Color.Red;
                        eur_alis_text.ForeColor = System.Drawing.Color.Red;
                        eur_alis.ForeColor = System.Drawing.Color.Red;
                    }
                    if (float.Parse(eur_satis.Text) < float.Parse(Settings.EUR_SATIS))
                    {
                        eur_label.ForeColor = System.Drawing.Color.Red;
                        eur_ad.ForeColor = System.Drawing.Color.Red;
                        eur_satis_text.ForeColor = System.Drawing.Color.Red;
                        eur_satis.ForeColor = System.Drawing.Color.Red;
                    }

                    if (float.Parse(gbp_alis.Text) < float.Parse(Settings.GBP_ALIS))
                    {
                        gbp_label.ForeColor = System.Drawing.Color.Red;
                        gbp_ad.ForeColor = System.Drawing.Color.Red;
                        gbp_alis_text.ForeColor = System.Drawing.Color.Red;
                        gbp_alis.ForeColor = System.Drawing.Color.Red;
                    }
                    if (float.Parse(gbp_satis.Text) < float.Parse(Settings.GBP_SATIS))
                    {
                        gbp_label.ForeColor = System.Drawing.Color.Red;
                        gbp_ad.ForeColor = System.Drawing.Color.Red;
                        gbp_satis_text.ForeColor = System.Drawing.Color.Red;
                        gbp_satis.ForeColor = System.Drawing.Color.Red;
                    }
                }

                Settings.USD_ALIS = usd_alis.Text;
                Settings.EUR_ALIS = eur_alis.Text;
                Settings.GBP_ALIS = gbp_alis.Text;

                Settings.USD_SATIS = usd_satis.Text;
                Settings.EUR_SATIS = eur_satis.Text;
                Settings.GBP_SATIS = gbp_satis.Text;
                



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
                Settings.UPDATER_VERSION = json["version"];
                Settings.UPDATER_URL = json["url"];
                Settings.UPDATER_AUTHOR = json.links["author"];
                Settings.UPDATER_GITHUB = json.links["github"];
            }
        }
        async void checkUpdates()
        {
            try { await checkUpdater(); }
            catch (Exception) { return; }

            if(Settings.UPDATER_VERSION != Settings.CLIENT_VERSION)
            {
                update_version.Text = Settings.UPDATER_VERSION;
                update_label.Visible = true;
                update_version.Visible = true;
                updater_button.Enabled = true;
            }
        }

        void disableAutoUpdater()
        {
            Settings.AutoUpdate = false;
            loop.Stop();
            update_button.Enabled = true;
        }

        //İNTERNET KONTROL
        void checkNetwork()
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                SettingsWindow settings = new SettingsWindow();
                disableAutoUpdater();
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
            System.Diagnostics.Process.Start(Settings.UPDATER_AUTHOR);
        }
        private void github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Settings.UPDATER_GITHUB);
        }

        private void updater_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Settings.UPDATER_URL);
        }


        private void opensettings()
        {
            Application.Run(new SettingsWindow());
        }

        void checkLoad()
        {
            if (Settings.AutoUpdate == true)
            {
                loop.Start();
                update_button.Enabled = false;
            }
            else
            {
                loop.Stop();
                update_button.Enabled = true;
            }

            if(Settings.PresenceStatus == false) Discord.PresenceDelete();
            else Discord.PresenceInstall();




        }

        private void settings_button_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opensettings);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
