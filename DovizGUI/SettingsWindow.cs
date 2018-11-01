
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DovizGUI
{
    public partial class SettingsWindow : Form
    {
        Thread th;

        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void author_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Settings.UPDATER_AUTHOR);
        }

        private void github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Settings.UPDATER_GITHUB);
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            auto_second.Value = Settings.AutoLoadSecond;
            version_label.Text = Settings.CLIENT_VERSION;
            if (Settings.AutoUpdate == true) autoUpdate_checkbox.Checked = true;
            else if (Settings.AutoUpdate == false)  autoUpdate_checkbox.Checked = false;

            if (Settings.PresenceStatus == false) richpresence.Checked = false;
            else if (Settings.PresenceStatus == true) richpresence.Checked = true;
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            if (richpresence.Checked == false) Settings.PresenceStatus = false;
            else Settings.PresenceStatus = true;

            if (autoUpdate_checkbox.Checked == false) Settings.AutoUpdate = false;
            else Settings.AutoUpdate = true;

            Settings.AutoLoadSecond = int.Parse(auto_second.Value.ToString());
            
            openMainMenu();
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            openMainMenu();
        }

        void openMainMenu()
        {
            this.Close();
            th = new Thread(dovizgui);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void dovizgui()
        {
            Application.Run(new DovizGUI());
        }

    }
}
