namespace CloudSpeicher
{
    partial class Datei_Runterladen
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
            this.buttonRunterLaden = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonLöschen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.label1.Location = new System.Drawing.Point(291, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datei Runterladen";
            // 
            // buttonRunterLaden
            // 
            this.buttonRunterLaden.Location = new System.Drawing.Point(501, 447);
            this.buttonRunterLaden.Name = "buttonRunterLaden";
            this.buttonRunterLaden.Size = new System.Drawing.Size(115, 23);
            this.buttonRunterLaden.TabIndex = 1;
            this.buttonRunterLaden.Text = "Runterladen";
            this.buttonRunterLaden.UseVisualStyleBackColor = true;
            this.buttonRunterLaden.Click += new System.EventHandler(this.buttonRunterLaden_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(155, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(510, 292);
            this.listBox1.TabIndex = 2;
            // 
            // buttonLöschen
            // 
            this.buttonLöschen.Location = new System.Drawing.Point(213, 447);
            this.buttonLöschen.Name = "buttonLöschen";
            this.buttonLöschen.Size = new System.Drawing.Size(75, 23);
            this.buttonLöschen.TabIndex = 3;
            this.buttonLöschen.Text = "Löschen";
            this.buttonLöschen.UseVisualStyleBackColor = true;
            this.buttonLöschen.Click += new System.EventHandler(this.buttonLöschen_Click);
            // 
            // Datei_Runterladen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonLöschen);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonRunterLaden);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Datei_Runterladen";
            this.Size = new System.Drawing.Size(800, 700);
            this.Load += new System.EventHandler(this.Datei_Runterladen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRunterLaden;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonLöschen;
    }
}
