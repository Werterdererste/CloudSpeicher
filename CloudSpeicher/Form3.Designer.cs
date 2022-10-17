namespace CloudSpeicher
{
    partial class Form3
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
            this.panelMenü = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonKonto = new System.Windows.Forms.Button();
            this.buttonDateiHochladen = new System.Windows.Forms.Button();
            this.buttonDateiRunterladen = new System.Windows.Forms.Button();
            this.panelLeiste = new System.Windows.Forms.Panel();
            this.dateiHochladen1 = new CloudSpeicher.DateiHochladen();
            this.panelMenü.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenü
            // 
            this.panelMenü.BackColor = System.Drawing.Color.Silver;
            this.panelMenü.Controls.Add(this.buttonDateiRunterladen);
            this.panelMenü.Controls.Add(this.buttonDateiHochladen);
            this.panelMenü.Controls.Add(this.buttonKonto);
            this.panelMenü.Controls.Add(this.panelTop);
            this.panelMenü.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenü.Location = new System.Drawing.Point(0, 0);
            this.panelMenü.Name = "panelMenü";
            this.panelMenü.Size = new System.Drawing.Size(220, 450);
            this.panelMenü.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Gray;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(220, 100);
            this.panelTop.TabIndex = 1;
            // 
            // buttonKonto
            // 
            this.buttonKonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonKonto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonKonto.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonKonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKonto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKonto.Location = new System.Drawing.Point(0, 100);
            this.buttonKonto.Name = "buttonKonto";
            this.buttonKonto.Padding = new System.Windows.Forms.Padding(5);
            this.buttonKonto.Size = new System.Drawing.Size(220, 40);
            this.buttonKonto.TabIndex = 1;
            this.buttonKonto.Text = "Konto";
            this.buttonKonto.UseVisualStyleBackColor = false;
            this.buttonKonto.Click += new System.EventHandler(this.buttonKonto_Click);
            // 
            // buttonDateiHochladen
            // 
            this.buttonDateiHochladen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDateiHochladen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDateiHochladen.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDateiHochladen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDateiHochladen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDateiHochladen.Location = new System.Drawing.Point(0, 140);
            this.buttonDateiHochladen.Name = "buttonDateiHochladen";
            this.buttonDateiHochladen.Padding = new System.Windows.Forms.Padding(5);
            this.buttonDateiHochladen.Size = new System.Drawing.Size(220, 40);
            this.buttonDateiHochladen.TabIndex = 2;
            this.buttonDateiHochladen.Text = "Datei Hochladen";
            this.buttonDateiHochladen.UseVisualStyleBackColor = false;
            this.buttonDateiHochladen.Click += new System.EventHandler(this.buttonDateiHochladen_Click);
            // 
            // buttonDateiRunterladen
            // 
            this.buttonDateiRunterladen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDateiRunterladen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDateiRunterladen.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDateiRunterladen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDateiRunterladen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDateiRunterladen.Location = new System.Drawing.Point(0, 180);
            this.buttonDateiRunterladen.Name = "buttonDateiRunterladen";
            this.buttonDateiRunterladen.Padding = new System.Windows.Forms.Padding(5);
            this.buttonDateiRunterladen.Size = new System.Drawing.Size(220, 40);
            this.buttonDateiRunterladen.TabIndex = 3;
            this.buttonDateiRunterladen.Text = "Datei Runterladen";
            this.buttonDateiRunterladen.UseVisualStyleBackColor = false;
            this.buttonDateiRunterladen.Click += new System.EventHandler(this.buttonDateiRunterladen_Click);
            // 
            // panelLeiste
            // 
            this.panelLeiste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelLeiste.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeiste.Location = new System.Drawing.Point(220, 0);
            this.panelLeiste.Name = "panelLeiste";
            this.panelLeiste.Size = new System.Drawing.Size(580, 50);
            this.panelLeiste.TabIndex = 1;
            // 
            // dateiHochladen1
            // 
            this.dateiHochladen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateiHochladen1.Location = new System.Drawing.Point(220, 50);
            this.dateiHochladen1.Name = "dateiHochladen1";
            this.dateiHochladen1.Size = new System.Drawing.Size(580, 400);
            this.dateiHochladen1.TabIndex = 2;
            this.dateiHochladen1.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateiHochladen1);
            this.Controls.Add(this.panelLeiste);
            this.Controls.Add(this.panelMenü);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panelMenü.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenü;
        private System.Windows.Forms.Button buttonDateiRunterladen;
        private System.Windows.Forms.Button buttonDateiHochladen;
        private System.Windows.Forms.Button buttonKonto;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeiste;
        private DateiHochladen dateiHochladen1;
    }
}