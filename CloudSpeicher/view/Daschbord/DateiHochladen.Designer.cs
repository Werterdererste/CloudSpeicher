namespace CloudSpeicher
{
    partial class DateiHochladen
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonHinzufügen = new System.Windows.Forms.Button();
            this.buttonAuswahlLöschen = new System.Windows.Forms.Button();
            this.buttonHochladen = new System.Windows.Forms.Button();
            this.buttonAlleLöschen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datei Hochladen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(133, 62);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(532, 356);
            this.listBox1.TabIndex = 3;
            // 
            // buttonHinzufügen
            // 
            this.buttonHinzufügen.Location = new System.Drawing.Point(133, 431);
            this.buttonHinzufügen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonHinzufügen.Name = "buttonHinzufügen";
            this.buttonHinzufügen.Size = new System.Drawing.Size(100, 28);
            this.buttonHinzufügen.TabIndex = 4;
            this.buttonHinzufügen.Text = "Hinzufügen";
            this.buttonHinzufügen.UseVisualStyleBackColor = true;
            this.buttonHinzufügen.Click += new System.EventHandler(this.buttonHinzufügen_Click);
            // 
            // buttonAuswahlLöschen
            // 
            this.buttonAuswahlLöschen.Location = new System.Drawing.Point(267, 431);
            this.buttonAuswahlLöschen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAuswahlLöschen.Name = "buttonAuswahlLöschen";
            this.buttonAuswahlLöschen.Size = new System.Drawing.Size(133, 28);
            this.buttonAuswahlLöschen.TabIndex = 5;
            this.buttonAuswahlLöschen.Text = "Auswahl Löschen";
            this.buttonAuswahlLöschen.UseVisualStyleBackColor = true;
            this.buttonAuswahlLöschen.Click += new System.EventHandler(this.buttonAuswahlLöschen_Click);
            // 
            // buttonHochladen
            // 
            this.buttonHochladen.Location = new System.Drawing.Point(567, 431);
            this.buttonHochladen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonHochladen.Name = "buttonHochladen";
            this.buttonHochladen.Size = new System.Drawing.Size(100, 28);
            this.buttonHochladen.TabIndex = 6;
            this.buttonHochladen.Text = "Hochladen";
            this.buttonHochladen.UseVisualStyleBackColor = true;
            this.buttonHochladen.Click += new System.EventHandler(this.buttonHochladen_Click);
            // 
            // buttonAlleLöschen
            // 
            this.buttonAlleLöschen.Location = new System.Drawing.Point(433, 431);
            this.buttonAlleLöschen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAlleLöschen.Name = "buttonAlleLöschen";
            this.buttonAlleLöschen.Size = new System.Drawing.Size(100, 28);
            this.buttonAlleLöschen.TabIndex = 7;
            this.buttonAlleLöschen.Text = "Alle löschen";
            this.buttonAlleLöschen.UseVisualStyleBackColor = true;
            this.buttonAlleLöschen.Click += new System.EventHandler(this.buttonAlleLöschen_Click);
            // 
            // DateiHochladen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonAlleLöschen);
            this.Controls.Add(this.buttonHochladen);
            this.Controls.Add(this.buttonAuswahlLöschen);
            this.Controls.Add(this.buttonHinzufügen);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DateiHochladen";
            this.Size = new System.Drawing.Size(800, 700);
            this.Load += new System.EventHandler(this.DateiHochladen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonHinzufügen;
        private System.Windows.Forms.Button buttonAuswahlLöschen;
        private System.Windows.Forms.Button buttonHochladen;
        private System.Windows.Forms.Button buttonAlleLöschen;
    }
}
