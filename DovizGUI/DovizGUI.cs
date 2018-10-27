
using DiscordRPC;
using DiscordRPC.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DovizGUI
{
    public partial class DovizGUI : Form
    {
        public DiscordRpcClient client;
        public static Boolean PresenceStatus = true;

        public DovizGUI()
        {
            InitializeComponent();
        }


        // LOOP
        private void loop_Tick(object sender, EventArgs e)
        {
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

        private void DovizGUI_Load(object sender, EventArgs e)
        {
            this.PresenceInstall();
        }


        void PresenceUpdate()
        {
            client.SetPresence(new RichPresence()
            {
                Details = "Döviz Project",
                State = "Doviz alpha",
                Assets = new Assets()
                {
                    LargeImageKey = "ekonomi",
                    LargeImageText = "Ekonomi",
                    SmallImageKey = "dolar"
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
    }
}
