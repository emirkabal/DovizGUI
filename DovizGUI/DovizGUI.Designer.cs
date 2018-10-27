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
            this.richpresence = new System.Windows.Forms.CheckBox();
            this.usdText = new System.Windows.Forms.Label();
            this.eurText = new System.Windows.Forms.Label();
            this.gbpText = new System.Windows.Forms.Label();
            this.usd = new System.Windows.Forms.Label();
            this.eur = new System.Windows.Forms.Label();
            this.gbp = new System.Windows.Forms.Label();
            this.loop = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // richpresence
            // 
            this.richpresence.AutoSize = true;
            this.richpresence.Checked = true;
            this.richpresence.CheckState = System.Windows.Forms.CheckState.Checked;
            this.richpresence.Location = new System.Drawing.Point(4, 255);
            this.richpresence.Name = "richpresence";
            this.richpresence.Size = new System.Drawing.Size(135, 17);
            this.richpresence.TabIndex = 0;
            this.richpresence.Text = "Discord Rich Presence";
            this.richpresence.UseVisualStyleBackColor = true;
            this.richpresence.CheckedChanged += new System.EventHandler(this.richpresence_CheckedChanged);
            // 
            // usdText
            // 
            this.usdText.AutoSize = true;
            this.usdText.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usdText.Location = new System.Drawing.Point(56, 42);
            this.usdText.Name = "usdText";
            this.usdText.Size = new System.Drawing.Size(80, 32);
            this.usdText.TabIndex = 2;
            this.usdText.Text = "USD:";
            // 
            // eurText
            // 
            this.eurText.AutoSize = true;
            this.eurText.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eurText.Location = new System.Drawing.Point(56, 98);
            this.eurText.Name = "eurText";
            this.eurText.Size = new System.Drawing.Size(80, 32);
            this.eurText.TabIndex = 3;
            this.eurText.Text = "EUR:";
            // 
            // gbpText
            // 
            this.gbpText.AutoSize = true;
            this.gbpText.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbpText.Location = new System.Drawing.Point(56, 156);
            this.gbpText.Name = "gbpText";
            this.gbpText.Size = new System.Drawing.Size(79, 32);
            this.gbpText.TabIndex = 4;
            this.gbpText.Text = "GBP:";
            // 
            // usd
            // 
            this.usd.AutoSize = true;
            this.usd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usd.Location = new System.Drawing.Point(142, 46);
            this.usd.Name = "usd";
            this.usd.Size = new System.Drawing.Size(27, 29);
            this.usd.TabIndex = 5;
            this.usd.Text = "0";
            // 
            // eur
            // 
            this.eur.AutoSize = true;
            this.eur.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eur.Location = new System.Drawing.Point(141, 100);
            this.eur.Name = "eur";
            this.eur.Size = new System.Drawing.Size(27, 29);
            this.eur.TabIndex = 6;
            this.eur.Text = "0";
            // 
            // gbp
            // 
            this.gbp.AutoSize = true;
            this.gbp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbp.Location = new System.Drawing.Point(142, 156);
            this.gbp.Name = "gbp";
            this.gbp.Size = new System.Drawing.Size(27, 29);
            this.gbp.TabIndex = 7;
            this.gbp.Text = "0";
            // 
            // loop
            // 
            this.loop.Enabled = true;
            this.loop.Tick += new System.EventHandler(this.loop_Tick);
            // 
            // DovizGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(462, 273);
            this.Controls.Add(this.gbp);
            this.Controls.Add(this.eur);
            this.Controls.Add(this.usd);
            this.Controls.Add(this.gbpText);
            this.Controls.Add(this.eurText);
            this.Controls.Add(this.usdText);
            this.Controls.Add(this.richpresence);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DovizGUI";
            this.Text = "DövizGUI";
            this.Load += new System.EventHandler(this.DovizGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox richpresence;
        private System.Windows.Forms.Label usdText;
        private System.Windows.Forms.Label eurText;
        private System.Windows.Forms.Label gbpText;
        private System.Windows.Forms.Label usd;
        private System.Windows.Forms.Label eur;
        private System.Windows.Forms.Label gbp;
        private System.Windows.Forms.Timer loop;
    }
}

