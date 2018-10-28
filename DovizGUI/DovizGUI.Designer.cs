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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DovizGUI));
            this.richpresence = new System.Windows.Forms.CheckBox();
            this.usd_label = new System.Windows.Forms.Label();
            this.usd_alis = new System.Windows.Forms.Label();
            this.loop = new System.Windows.Forms.Timer(this.components);
            this.usd_alis_text = new System.Windows.Forms.Label();
            this.usd_satis_text = new System.Windows.Forms.Label();
            this.usd_satis = new System.Windows.Forms.Label();
            this.eur_satis = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eur_alis = new System.Windows.Forms.Label();
            this.eur_label = new System.Windows.Forms.Label();
            this.gbp_satis = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbp_alis = new System.Windows.Forms.Label();
            this.gbp_label = new System.Windows.Forms.Label();
            this.eur_ad = new System.Windows.Forms.Label();
            this.usd_ad = new System.Windows.Forms.Label();
            this.gbp_ad = new System.Windows.Forms.Label();
            this.autoUpdate_checkbox = new System.Windows.Forms.CheckBox();
            this.update_button = new System.Windows.Forms.Button();
            this.github = new System.Windows.Forms.Button();
            this.author = new System.Windows.Forms.Button();
            this.version_label = new System.Windows.Forms.Label();
            this.updater_button = new System.Windows.Forms.Button();
            this.update_label = new System.Windows.Forms.Label();
            this.update_version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richpresence
            // 
            this.richpresence.AutoSize = true;
            this.richpresence.Location = new System.Drawing.Point(12, 359);
            this.richpresence.Name = "richpresence";
            this.richpresence.Size = new System.Drawing.Size(135, 17);
            this.richpresence.TabIndex = 0;
            this.richpresence.Text = "Discord Rich Presence";
            this.richpresence.UseVisualStyleBackColor = true;
            this.richpresence.CheckedChanged += new System.EventHandler(this.richpresence_CheckedChanged);
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
            // loop
            // 
            this.loop.Enabled = true;
            this.loop.Interval = 5000;
            this.loop.Tick += new System.EventHandler(this.loop_Tick);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(253, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Satış";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(135, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Alış";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(253, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Satış";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(135, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Alış";
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
            // autoUpdate_checkbox
            // 
            this.autoUpdate_checkbox.AutoSize = true;
            this.autoUpdate_checkbox.Checked = true;
            this.autoUpdate_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoUpdate_checkbox.Location = new System.Drawing.Point(12, 342);
            this.autoUpdate_checkbox.Name = "autoUpdate_checkbox";
            this.autoUpdate_checkbox.Size = new System.Drawing.Size(127, 17);
            this.autoUpdate_checkbox.TabIndex = 25;
            this.autoUpdate_checkbox.Text = "Otomatik Güncelleme";
            this.autoUpdate_checkbox.UseVisualStyleBackColor = true;
            this.autoUpdate_checkbox.CheckedChanged += new System.EventHandler(this.autoUpdate_checkbox_CheckedChanged);
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
            // github
            // 
            this.github.Location = new System.Drawing.Point(402, 359);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(53, 22);
            this.github.TabIndex = 27;
            this.github.Text = "GitHub";
            this.github.UseVisualStyleBackColor = true;
            this.github.Click += new System.EventHandler(this.github_Click);
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(343, 359);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(53, 22);
            this.author.TabIndex = 28;
            this.author.Text = "Yapımcı";
            this.author.UseVisualStyleBackColor = true;
            this.author.Click += new System.EventHandler(this.author_Click);
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.Location = new System.Drawing.Point(2, 375);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(41, 13);
            this.version_label.TabIndex = 29;
            this.version_label.Text = "version";
            // 
            // updater_button
            // 
            this.updater_button.Enabled = false;
            this.updater_button.Location = new System.Drawing.Point(343, 327);
            this.updater_button.Name = "updater_button";
            this.updater_button.Size = new System.Drawing.Size(112, 29);
            this.updater_button.TabIndex = 30;
            this.updater_button.Text = "Arayüzü Güncelle";
            this.updater_button.UseVisualStyleBackColor = true;
            this.updater_button.Click += new System.EventHandler(this.updater_button_Click);
            // 
            // update_label
            // 
            this.update_label.AutoSize = true;
            this.update_label.ForeColor = System.Drawing.Color.Lime;
            this.update_label.Location = new System.Drawing.Point(342, 311);
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
            this.update_version.Location = new System.Drawing.Point(402, 311);
            this.update_version.Name = "update_version";
            this.update_version.Size = new System.Drawing.Size(22, 13);
            this.update_version.TabIndex = 31;
            this.update_version.Text = "1.0";
            this.update_version.Visible = false;
            // 
            // DovizGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(462, 388);
            this.Controls.Add(this.update_version);
            this.Controls.Add(this.update_label);
            this.Controls.Add(this.updater_button);
            this.Controls.Add(this.version_label);
            this.Controls.Add(this.author);
            this.Controls.Add(this.github);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.autoUpdate_checkbox);
            this.Controls.Add(this.gbp_ad);
            this.Controls.Add(this.usd_ad);
            this.Controls.Add(this.eur_ad);
            this.Controls.Add(this.gbp_satis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbp_alis);
            this.Controls.Add(this.gbp_label);
            this.Controls.Add(this.eur_satis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eur_alis);
            this.Controls.Add(this.eur_label);
            this.Controls.Add(this.usd_satis);
            this.Controls.Add(this.usd_satis_text);
            this.Controls.Add(this.usd_alis_text);
            this.Controls.Add(this.usd_alis);
            this.Controls.Add(this.usd_label);
            this.Controls.Add(this.richpresence);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DovizGUI";
            this.Text = "DövizGUI";
            this.Load += new System.EventHandler(this.DovizGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox richpresence;
        private System.Windows.Forms.Label usd_label;
        private System.Windows.Forms.Label usd_alis;
        private System.Windows.Forms.Timer loop;
        private System.Windows.Forms.Label usd_alis_text;
        private System.Windows.Forms.Label usd_satis_text;
        private System.Windows.Forms.Label usd_satis;
        private System.Windows.Forms.Label eur_satis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label eur_alis;
        private System.Windows.Forms.Label eur_label;
        private System.Windows.Forms.Label gbp_satis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label gbp_alis;
        private System.Windows.Forms.Label gbp_label;
        private System.Windows.Forms.Label eur_ad;
        private System.Windows.Forms.Label usd_ad;
        private System.Windows.Forms.Label gbp_ad;
        private System.Windows.Forms.CheckBox autoUpdate_checkbox;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button github;
        private System.Windows.Forms.Button author;
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.Button updater_button;
        private System.Windows.Forms.Label update_label;
        private System.Windows.Forms.Label update_version;
    }
}

