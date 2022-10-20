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
            this.buttonDateiRunterladen = new System.Windows.Forms.Button();
            this.buttonDateiHochladen = new System.Windows.Forms.Button();
            this.buttonKonto = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelLeiste = new System.Windows.Forms.Panel();
            this.datei_Runterladen1 = new CloudSpeicher.Datei_Runterladen();
            this.konto1 = new CloudSpeicher.Konto();
            this.dateiHochladen1 = new CloudSpeicher.DateiHochladen();
            this.panelMenü.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenü
            // 
            this.panelMenü.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.panelMenü.Controls.Add(this.buttonDateiRunterladen);
            this.panelMenü.Controls.Add(this.buttonDateiHochladen);
            this.panelMenü.Controls.Add(this.buttonKonto);
            this.panelMenü.Controls.Add(this.panelTop);
            this.panelMenü.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenü.Location = new System.Drawing.Point(0, 0);
            this.panelMenü.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.panelMenü.Name = "panelMenü";
            this.panelMenü.Size = new System.Drawing.Size(220, 786);
            this.panelMenü.TabIndex = 0;
            // 
            // buttonDateiRunterladen
            // 
            this.buttonDateiRunterladen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(168)))), ((int)(((byte)(248)))));
            this.buttonDateiRunterladen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDateiRunterladen.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDateiRunterladen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDateiRunterladen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDateiRunterladen.Location = new System.Drawing.Point(0, 148);
            this.buttonDateiRunterladen.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.buttonDateiRunterladen.Name = "buttonDateiRunterladen";
            this.buttonDateiRunterladen.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonDateiRunterladen.Size = new System.Drawing.Size(220, 49);
            this.buttonDateiRunterladen.TabIndex = 3;
            this.buttonDateiRunterladen.Text = "Datei Runterladen";
            this.buttonDateiRunterladen.UseVisualStyleBackColor = false;
            this.buttonDateiRunterladen.Click += new System.EventHandler(this.buttonDateiRunterladen_Click);
            // 
            // buttonDateiHochladen
            // 
            this.buttonDateiHochladen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(168)))), ((int)(((byte)(248)))));
            this.buttonDateiHochladen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDateiHochladen.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDateiHochladen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDateiHochladen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDateiHochladen.Location = new System.Drawing.Point(0, 99);
            this.buttonDateiHochladen.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.buttonDateiHochladen.Name = "buttonDateiHochladen";
            this.buttonDateiHochladen.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonDateiHochladen.Size = new System.Drawing.Size(220, 49);
            this.buttonDateiHochladen.TabIndex = 2;
            this.buttonDateiHochladen.Text = "Datei Hochladen";
            this.buttonDateiHochladen.UseVisualStyleBackColor = false;
            this.buttonDateiHochladen.Click += new System.EventHandler(this.buttonDateiHochladen_Click);
            // 
            // buttonKonto
            // 
            this.buttonKonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(168)))), ((int)(((byte)(248)))));
            this.buttonKonto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonKonto.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonKonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKonto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKonto.Location = new System.Drawing.Point(0, 50);
            this.buttonKonto.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.buttonKonto.Name = "buttonKonto";
            this.buttonKonto.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonKonto.Size = new System.Drawing.Size(220, 49);
            this.buttonKonto.TabIndex = 1;
            this.buttonKonto.Text = "Konto";
            this.buttonKonto.UseVisualStyleBackColor = false;
            this.buttonKonto.Click += new System.EventHandler(this.buttonKonto_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(220, 50);
            this.panelTop.TabIndex = 1;
            // 
            // panelLeiste
            // 
            this.panelLeiste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(248)))));
            this.panelLeiste.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeiste.Location = new System.Drawing.Point(220, 0);
            this.panelLeiste.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.panelLeiste.Name = "panelLeiste";
            this.panelLeiste.Size = new System.Drawing.Size(804, 50);
            this.panelLeiste.TabIndex = 1;
            // 
            // datei_Runterladen1
            // 
            this.datei_Runterladen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.datei_Runterladen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datei_Runterladen1.Location = new System.Drawing.Point(220, 50);
            this.datei_Runterladen1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.datei_Runterladen1.Name = "datei_Runterladen1";
            this.datei_Runterladen1.Size = new System.Drawing.Size(804, 736);
            this.datei_Runterladen1.TabIndex = 4;
            // 
            // konto1
            // 
            this.konto1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.konto1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.konto1.Location = new System.Drawing.Point(220, 50);
            this.konto1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.konto1.Name = "konto1";
            this.konto1.Size = new System.Drawing.Size(804, 736);
            this.konto1.TabIndex = 3;
            // 
            // dateiHochladen1
            // 
            this.dateiHochladen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.dateiHochladen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateiHochladen1.Location = new System.Drawing.Point(220, 50);
            this.dateiHochladen1.Margin = new System.Windows.Forms.Padding(5);
            this.dateiHochladen1.Name = "dateiHochladen1";
            this.dateiHochladen1.Size = new System.Drawing.Size(804, 736);
            this.dateiHochladen1.TabIndex = 2;
            this.dateiHochladen1.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1024, 786);
            this.Controls.Add(this.datei_Runterladen1);
            this.Controls.Add(this.konto1);
            this.Controls.Add(this.dateiHochladen1);
            this.Controls.Add(this.panelLeiste);
            this.Controls.Add(this.panelMenü);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
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
        private Konto konto1;
        private Datei_Runterladen datei_Runterladen1;
    }
}