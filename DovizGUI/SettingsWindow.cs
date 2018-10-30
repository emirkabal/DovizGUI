
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
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }


        public void disableAutoUpdater()
        {
            DovizGUI.AutoUpdate = false;
            autoUpdate_checkbox.Checked = false;
            DovizGUI.update_button.Enabled = true;
        }

        private void author_Click(object sender, EventArgs e)
        {
            DovizGUI doviz = new DovizGUI();
            System.Diagnostics.Process.Start(DovizGUI.UPDATER_AUTHOR);
        }

        private void github_Click(object sender, EventArgs e)
        {
            DovizGUI doviz = new DovizGUI();
            System.Diagnostics.Process.Start(DovizGUI.UPDATER_GITHUB);
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            version_label.Text = DovizGUI.CLIENT_VERSION;
            if (DovizGUI.AutoUpdate == true) autoUpdate_checkbox.Checked = true;
            else if (DovizGUI.AutoUpdate == false)  autoUpdate_checkbox.Checked = false;

            if (DovizGUI.PresenceStatus == false) richpresence.Checked = false;
            else if (DovizGUI.PresenceStatus == true) richpresence.Checked = true;
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            if (richpresence.Checked == false)
            {
                if (DovizGUI.PresenceStatus == true)
                {
                    DovizGUI.PresenceStatus = false;
                    Discord.PresenceDelete();
                }
            }
            else
            {
                if(DovizGUI.PresenceStatus == false)
                {
                    DovizGUI.PresenceStatus = true;
                    Discord.PresenceInstall();
                }
            }

            if (autoUpdate_checkbox.Checked == false)
            {
                DovizGUI.AutoUpdate = false;
                DovizGUI.loop.Stop();
                //DovizGUI.loop_bar.Value = 0;
                //DovizGUI.loop_bar.Visible = false;
                DovizGUI.update_button.Enabled = true;
            }
            else
            {
                DovizGUI.AutoUpdate = true;
                DovizGUI.loop.Start();
                //DovizGUI.loop_bar.Visible = true;
                DovizGUI.update_button.Enabled = false;
            }
            Close();
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
