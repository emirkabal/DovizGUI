namespace DovizGUI
{
    partial class SettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.richpresence = new System.Windows.Forms.CheckBox();
            this.autoUpdate_checkbox = new System.Windows.Forms.CheckBox();
            this.version_label = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Button();
            this.github = new System.Windows.Forms.Button();
            this.kaydet = new System.Windows.Forms.Button();
            this.iptal = new System.Windows.Forms.Button();
            this.auto_second = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.auto_second)).BeginInit();
            this.SuspendLayout();
            // 
            // richpresence
            // 
            this.richpresence.AutoSize = true;
            this.richpresence.Location = new System.Drawing.Point(43, 35);
            this.richpresence.Name = "richpresence";
            this.richpresence.Size = new System.Drawing.Size(135, 17);
            this.richpresence.TabIndex = 1;
            this.richpresence.Text = "Discord Rich Presence";
            this.richpresence.UseVisualStyleBackColor = true;
            // 
            // autoUpdate_checkbox
            // 
            this.autoUpdate_checkbox.AutoSize = true;
            this.autoUpdate_checkbox.Checked = true;
            this.autoUpdate_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoUpdate_checkbox.Location = new System.Drawing.Point(43, 12);
            this.autoUpdate_checkbox.Name = "autoUpdate_checkbox";
            this.autoUpdate_checkbox.Size = new System.Drawing.Size(127, 17);
            this.autoUpdate_checkbox.TabIndex = 26;
            this.autoUpdate_checkbox.Text = "Otomatik Güncelleme";
            this.autoUpdate_checkbox.UseVisualStyleBackColor = true;
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.Location = new System.Drawing.Point(3, 135);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(41, 13);
            this.version_label.TabIndex = 30;
            this.version_label.Text = "version";
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(12, 58);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(206, 22);
            this.author.TabIndex = 32;
            this.author.Text = "Yapımcı";
            this.author.UseVisualStyleBackColor = true;
            this.author.Click += new System.EventHandler(this.author_Click);
            // 
            // github
            // 
            this.github.Location = new System.Drawing.Point(12, 81);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(206, 24);
            this.github.TabIndex = 31;
            this.github.Text = "GitHub";
            this.github.UseVisualStyleBackColor = true;
            this.github.Click += new System.EventHandler(this.github_Click);
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(12, 111);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(95, 23);
            this.kaydet.TabIndex = 33;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // iptal
            // 
            this.iptal.Location = new System.Drawing.Point(123, 111);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(95, 23);
            this.iptal.TabIndex = 35;
            this.iptal.Text = "İptal";
            this.iptal.UseVisualStyleBackColor = true;
            this.iptal.Click += new System.EventHandler(this.iptal_Click);
            // 
            // auto_second
            // 
            this.auto_second.Location = new System.Drawing.Point(168, 11);
            this.auto_second.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.auto_second.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.auto_second.Name = "auto_second";
            this.auto_second.Size = new System.Drawing.Size(38, 20);
            this.auto_second.TabIndex = 37;
            this.auto_second.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 152);
            this.Controls.Add(this.auto_second);
            this.Controls.Add(this.iptal);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.author);
            this.Controls.Add(this.github);
            this.Controls.Add(this.version_label);
            this.Controls.Add(this.autoUpdate_checkbox);
            this.Controls.Add(this.richpresence);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsWindow";
            this.Text = "DövizGUI - Ayarlar";
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.auto_second)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox richpresence;
        private System.Windows.Forms.CheckBox autoUpdate_checkbox;
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.Button author;
        private System.Windows.Forms.Button github;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Button iptal;
        private System.Windows.Forms.NumericUpDown auto_second;
    }
}