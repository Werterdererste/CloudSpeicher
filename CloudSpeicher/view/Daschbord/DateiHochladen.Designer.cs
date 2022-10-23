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
            this.buttonFileUploard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.label1.Location = new System.Drawing.Point(177, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datei Hochladen";
            // 
            // buttonFileUploard
            // 
            this.buttonFileUploard.Location = new System.Drawing.Point(206, 142);
            this.buttonFileUploard.Name = "buttonFileUploard";
            this.buttonFileUploard.Size = new System.Drawing.Size(131, 23);
            this.buttonFileUploard.TabIndex = 2;
            this.buttonFileUploard.Text = "Datei Auswahl";
            this.buttonFileUploard.UseVisualStyleBackColor = true;
            this.buttonFileUploard.Click += new System.EventHandler(this.buttonFileUploard_Click);
            // 
            // DateiHochladen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonFileUploard);
            this.Controls.Add(this.label1);
            this.Name = "DateiHochladen";
            this.Size = new System.Drawing.Size(600, 569);
            this.Load += new System.EventHandler(this.DateiHochladen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFileUploard;
    }
}
