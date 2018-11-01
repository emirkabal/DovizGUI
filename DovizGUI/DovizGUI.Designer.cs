namespace DovizGUI
{
    partial class DovizGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void PublicComponent()
        {
            usd_satis = new System.Windows.Forms.Label();
            loop = new System.Windows.Forms.Timer();
            eur_satis = new System.Windows.Forms.Label();
            update_button = new System.Windows.Forms.Button();
            gbp_satis = new System.Windows.Forms.Label();
            loop_bar = new System.Windows.Forms.ProgressBar();


            loop.Enabled = true;
            loop.Interval = 500;
            loop.Tick += new System.EventHandler(this.loop_Tick);


            usd_satis.AutoSize = true;
            usd_satis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            usd_satis.Location = new System.Drawing.Point(240, 66);
            usd_satis.Name = "usd_satis";
            usd_satis.Size = new System.Drawing.Size(90, 29);
            usd_satis.TabIndex = 11;
            usd_satis.Text = "0.0000";
            eur_satis.AutoSize = true;
            eur_satis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            eur_satis.Location = new System.Drawing.Point(240, 181);
            eur_satis.Name = "eur_satis";
            eur_satis.Size = new System.Drawing.Size(90, 29);
            eur_satis.TabIndex = 16;
            eur_satis.Text = "0.0000";
            gbp_satis.AutoSize = true;
            gbp_satis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            gbp_satis.Location = new System.Drawing.Point(240, 285);
            gbp_satis.Name = "gbp_satis";
            gbp_satis.Size = new System.Drawing.Size(90, 29);
            gbp_satis.TabIndex = 21;
            gbp_satis.Text = "0.0000";
            update_button.Enabled = false;
            update_button.Location = new System.Drawing.Point(168, 327);
            update_button.Name = "update_button";
            update_button.Size = new System.Drawing.Size(116, 32);
            update_button.TabIndex = 26;
            update_button.Text = "Güncelle";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += new System.EventHandler(this.update_button_Click);
            loop_bar.Location = new System.Drawing.Point(168, 359);
            loop_bar.Maximum = 5;
            loop_bar.Name = "loop_bar";
            loop_bar.Size = new System.Drawing.Size(116, 22);
            loop_bar.TabIndex = 32;
            this.Controls.Add(loop_bar);
            this.Controls.Add(update_button);
            this.Controls.Add(usd_satis);
            this.Controls.Add(gbp_satis);
            this.Controls.Add(eur_satis);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DovizGUI));
            this.usd_satis = new System.Windows.Forms.Label();
            this.loop = new System.Windows.Forms.Timer(this.components);
            this.eur_satis = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.gbp_satis = new System.Windows.Forms.Label();
            this.loop_bar = new System.Windows.Forms.ProgressBar();
            this.usd_label = new System.Windows.Forms.Label();
            this.usd_alis = new System.Windows.Forms.Label();
            this.usd_alis_text = new System.Windows.Forms.Label();
            this.usd_satis_text = new System.Windows.Forms.Label();
            this.eur_satis_text = new System.Windows.Forms.Label();
            this.eur_alis_text = new System.Windows.Forms.Label();
            this.eur_alis = new System.Windows.Forms.Label();
            this.eur_label = new System.Windows.Forms.Label();
            this.gbp_satis_text = new System.Windows.Forms.Label();
            this.gbp_alis_text = new System.Windows.Forms.Label();
            this.gbp_alis = new System.Windows.Forms.Label();
            this.gbp_label = new System.Windows.Forms.Label();
            this.eur_ad = new System.Windows.Forms.Label();
            this.usd_ad = new System.Windows.Forms.Label();
            this.gbp_ad = new System.Windows.Forms.Label();
            this.version_label = new System.Windows.Forms.Label();
            this.updater_button = new System.Windows.Forms.Button();
            this.update_label = new System.Windows.Forms.Label();
            this.update_version = new System.Windows.Forms.Label();
            this.settings_button = new System.Windows.Forms.Button();
            this.onsecond = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // usd_satis
            // 
            this.usd_satis.AutoSize = true;
            this.usd_satis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usd_satis.Location = new System.Drawing.Point(240, 66);
            this.usd_satis.Name = "usd_satis";
            this.usd_satis.Size = new System.Drawing.Size(90, 29);
            this.usd_satis.TabIndex = 11;
            this.usd_satis.Text = "0.0000";
            // 
            // loop
            // 
            this.loop.Enabled = true;
            this.loop.Interval = 3000;
            this.loop.Tick += new System.EventHandler(this.loop_Tick);
            // 
            // eur_satis
            // 
            this.eur_satis.AutoSize = true;
            this.eur_satis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eur_satis.Location = new System.Drawing.Point(240, 181);
            this.eur_satis.Name = "eur_satis";
            this.eur_satis.Size = new System.Drawing.Size(90, 29);
            this.eur_satis.TabIndex = 16;
            this.eur_satis.Text = "0.0000";
            // 
            // update_button
            // 
            this.update_button.Enabled = false;
            this.update_button.Location = new System.Drawing.Point(168, 327);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(116, 32);
            this.update_button.TabIndex = 26;
            this.update_button.Text = "Güncelle";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // gbp_satis
            // 
            this.gbp_satis.AutoSize = true;
            this.gbp_satis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbp_satis.Location = new System.Drawing.Point(240, 285);
            this.gbp_satis.Name = "gbp_satis";
            this.gbp_satis.Size = new System.Drawing.Size(90, 29);
            this.gbp_satis.TabIndex = 21;
            this.gbp_satis.Text = "0.0000";
            // 
            // loop_bar
            // 
            this.loop_bar.Location = new System.Drawing.Point(168, 359);
            this.loop_bar.Maximum = 5;
            this.loop_bar.Name = "loop_bar";
            this.loop_bar.Size = new System.Drawing.Size(116, 22);
            this.loop_bar.TabIndex = 32;
            // 
            // usd_label
            // 
            this.usd_label.AutoSize = true;
            this.usd_label.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usd_label.Location = new System.Drawing.Point(188, 2);
            this.usd_label.Name = "usd_label";
            this.usd_label.Size = new System.Drawing.Size(72, 32);
            this.usd_label.TabIndex = 2;
            this.usd_label.Text = "USD";
            // 
            // usd_alis
            // 
            this.usd_alis.AutoSize = true;
            this.usd_alis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usd_alis.Location = new System.Drawing.Point(114, 66);
            this.usd_alis.Name = "usd_alis";
            this.usd_alis.Size = new System.Drawing.Size(90, 29);
            this.usd_alis.TabIndex = 5;
            this.usd_alis.Text = "0.0000";
            // 
            // usd_alis_text
            // 
            this.usd_alis_text.AutoSize = true;
            this.usd_alis_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usd_alis_text.Location = new System.Drawing.Point(135, 41);
            this.usd_alis_text.Name = "usd_alis_text";
            this.usd_alis_text.Size = new System.Drawing.Size(47, 25);
            this.usd_alis_text.TabIndex = 9;
            this.usd_alis_text.Text = "Alış";
            // 
            // usd_satis_text
            // 
            this.usd_satis_text.AutoSize = true;
            this.usd_satis_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usd_satis_text.Location = new System.Drawing.Point(253, 41);
            this.usd_satis_text.Name = "usd_satis_text";
            this.usd_satis_text.Size = new System.Drawing.Size(60, 25);
            this.usd_satis_text.TabIndex = 10;
            this.usd_satis_text.Text = "Satış";
            // 
            // eur_satis_text
            // 
            this.eur_satis_text.AutoSize = true;
            this.eur_satis_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eur_satis_text.Location = new System.Drawing.Point(253, 156);
            this.eur_satis_text.Name = "eur_satis_text";
            this.eur_satis_text.Size = new System.Drawing.Size(60, 25);
            this.eur_satis_text.TabIndex = 15;
            this.eur_satis_text.Text = "Satış";
            // 
            // eur_alis_text
            // 
            this.eur_alis_text.AutoSize = true;
            this.eur_alis_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eur_alis_text.Location = new System.Drawing.Point(135, 156);
            this.eur_alis_text.Name = "eur_alis_text";
            this.eur_alis_text.Size = new System.Drawing.Size(47, 25);
            this.eur_alis_text.TabIndex = 14;
            this.eur_alis_text.Text = "Alış";
            // 
            // eur_alis
            // 
            this.eur_alis.AutoSize = true;
            this.eur_alis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eur_alis.Location = new System.Drawing.Point(114, 181);
            this.eur_alis.Name = "eur_alis";
            this.eur_alis.Size = new System.Drawing.Size(90, 29);
            this.eur_alis.TabIndex = 13;
            this.eur_alis.Text = "0.0000";
            // 
            // eur_label
            // 
            this.eur_label.AutoSize = true;
            this.eur_label.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eur_label.Location = new System.Drawing.Point(188, 108);
            this.eur_label.Name = "eur_label";
            this.eur_label.Size = new System.Drawing.Size(72, 32);
            this.eur_label.TabIndex = 12;
            this.eur_label.Text = "EUR";
            // 
            // gbp_satis_text
            // 
            this.gbp_satis_text.AutoSize = true;
            this.gbp_satis_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbp_satis_text.Location = new System.Drawing.Point(253, 260);
            this.gbp_satis_text.Name = "gbp_satis_text";
            this.gbp_satis_text.Size = new System.Drawing.Size(60, 25);
            this.gbp_satis_text.TabIndex = 20;
            this.gbp_satis_text.Text = "Satış";
            // 
            // gbp_alis_text
            // 
            this.gbp_alis_text.AutoSize = true;
            this.gbp_alis_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbp_alis_text.Location = new System.Drawing.Point(135, 260);
            this.gbp_alis_text.Name = "gbp_alis_text";
            this.gbp_alis_text.Size = new System.Drawing.Size(47, 25);
            this.gbp_alis_text.TabIndex = 19;
            this.gbp_alis_text.Text = "Alış";
            // 
            // gbp_alis
            // 
            this.gbp_alis.AutoSize = true;
            this.gbp_alis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbp_alis.Location = new System.Drawing.Point(114, 285);
            this.gbp_alis.Name = "gbp_alis";
            this.gbp_alis.Size = new System.Drawing.Size(90, 29);
            this.gbp_alis.TabIndex = 18;
            this.gbp_alis.Text = "0.0000";
            // 
            // gbp_label
            // 
            this.gbp_label.AutoSize = true;
            this.gbp_label.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbp_label.Location = new System.Drawing.Point(188, 219);
            this.gbp_label.Name = "gbp_label";
            this.gbp_label.Size = new System.Drawing.Size(71, 32);
            this.gbp_label.TabIndex = 17;
            this.gbp_label.Text = "GBP";
            // 
            // eur_ad
            // 
            this.eur_ad.AutoSize = true;
            this.eur_ad.Location = new System.Drawing.Point(206, 140);
            this.eur_ad.Name = "eur_ad";
            this.eur_ad.Size = new System.Drawing.Size(33, 13);
            this.eur_ad.TabIndex = 22;
            this.eur_ad.Text = "None";
            this.eur_ad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // usd_ad
            // 
            this.usd_ad.AutoSize = true;
            this.usd_ad.Location = new System.Drawing.Point(183, 28);
            this.usd_ad.Name = "usd_ad";
            this.usd_ad.Size = new System.Drawing.Size(33, 13);
            this.usd_ad.TabIndex = 23;
            this.usd_ad.Text = "None";
            this.usd_ad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbp_ad
            // 
            this.gbp_ad.AutoSize = true;
            this.gbp_ad.Location = new System.Drawing.Point(187, 251);
            this.gbp_ad.Name = "gbp_ad";
            this.gbp_ad.Size = new System.Drawing.Size(33, 13);
            this.gbp_ad.TabIndex = 24;
            this.gbp_ad.Text = "None";
            this.gbp_ad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.Location = new System.Drawing.Point(3, 373);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(41, 13);
            this.version_label.TabIndex = 29;
            this.version_label.Text = "version";
            // 
            // updater_button
            // 
            this.updater_button.Enabled = false;
            this.updater_button.Location = new System.Drawing.Point(348, 332);
            this.updater_button.Name = "updater_button";
            this.updater_button.Size = new System.Drawing.Size(113, 27);
            this.updater_button.TabIndex = 30;
            this.updater_button.Text = "Arayüzü Güncelle";
            this.updater_button.UseVisualStyleBackColor = true;
            this.updater_button.Click += new System.EventHandler(this.updater_button_Click);
            // 
            // update_label
            // 
            this.update_label.AutoSize = true;
            this.update_label.ForeColor = System.Drawing.Color.Lime;
            this.update_label.Location = new System.Drawing.Point(347, 316);
            this.update_label.Name = "update_label";
            this.update_label.Size = new System.Drawing.Size(64, 13);
            this.update_label.TabIndex = 10;
            this.update_label.Text = "Yeni Sürüm:";
            this.update_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.update_label.Visible = false;
            // 
            // update_version
            // 
            this.update_version.AutoSize = true;
            this.update_version.ForeColor = System.Drawing.Color.Lime;
            this.update_version.Location = new System.Drawing.Point(407, 316);
            this.update_version.Name = "update_version";
            this.update_version.Size = new System.Drawing.Size(22, 13);
            this.update_version.TabIndex = 31;
            this.update_version.Text = "1.0";
            this.update_version.Visible = false;
            // 
            // settings_button
            // 
            this.settings_button.Location = new System.Drawing.Point(348, 359);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(113, 27);
            this.settings_button.TabIndex = 33;
            this.settings_button.Text = "Ayarlar";
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click_1);
            // 
            // onsecond
            // 
            this.onsecond.Enabled = true;
            this.onsecond.Interval = 1000;
            this.onsecond.Tick += new System.EventHandler(this.onsecond_Tick);
            // 
            // DovizGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(462, 388);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.loop_bar);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.usd_satis);
            this.Controls.Add(this.gbp_satis);
            this.Controls.Add(this.eur_satis);
            this.Controls.Add(this.update_version);
            this.Controls.Add(this.update_label);
            this.Controls.Add(this.updater_button);
            this.Controls.Add(this.version_label);
            this.Controls.Add(this.gbp_ad);
            this.Controls.Add(this.usd_ad);
            this.Controls.Add(this.eur_ad);
            this.Controls.Add(this.gbp_satis_text);
            this.Controls.Add(this.gbp_alis_text);
            this.Controls.Add(this.gbp_alis);
            this.Controls.Add(this.gbp_label);
            this.Controls.Add(this.eur_satis_text);
            this.Controls.Add(this.eur_alis_text);
            this.Controls.Add(this.eur_alis);
            this.Controls.Add(this.eur_label);
            this.Controls.Add(this.usd_satis_text);
            this.Controls.Add(this.usd_alis_text);
            this.Controls.Add(this.usd_alis);
            this.Controls.Add(this.usd_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DovizGUI";
            this.Text = "DövizGUI";
            this.Load += new System.EventHandler(this.DovizGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label usd_label;
        private System.Windows.Forms.Label usd_alis;
        private System.Windows.Forms.Label usd_alis_text;
        private System.Windows.Forms.Label usd_satis_text;
        private System.Windows.Forms.Label eur_satis_text;
        private System.Windows.Forms.Label eur_alis_text;
        private System.Windows.Forms.Label eur_alis;
        private System.Windows.Forms.Label eur_label;
        private System.Windows.Forms.Label gbp_satis_text;
        private System.Windows.Forms.Label gbp_alis_text;
        private System.Windows.Forms.Label gbp_alis;
        private System.Windows.Forms.Label gbp_label;
        private System.Windows.Forms.Label eur_ad;
        private System.Windows.Forms.Label usd_ad;
        private System.Windows.Forms.Label gbp_ad;
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.Button updater_button;
        private System.Windows.Forms.Label update_label;
        private System.Windows.Forms.Label update_version;
        private System.Windows.Forms.Label gbp_satis;
        public System.Windows.Forms.ProgressBar loop_bar;
        private System.Windows.Forms.Label eur_satis;
        private System.Windows.Forms.Label usd_satis;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Timer loop;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Timer onsecond;
    }
}

