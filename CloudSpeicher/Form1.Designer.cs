﻿namespace CloudSpeicher
{
    partial class Form1
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxBenutzerName = new System.Windows.Forms.TextBox();
            this.textBoxPasswort = new System.Windows.Forms.TextBox();
            this.labelBenutzerName = new System.Windows.Forms.Label();
            this.labelPasswort = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonAcountErstellen = new System.Windows.Forms.Button();
            this.buttonPasswortvergessen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxBenutzerName
            // 
            this.textBoxBenutzerName.Location = new System.Drawing.Point(262, 106);
            this.textBoxBenutzerName.Name = "textBoxBenutzerName";
            this.textBoxBenutzerName.Size = new System.Drawing.Size(100, 22);
            this.textBoxBenutzerName.TabIndex = 0;
            this.textBoxBenutzerName.TextChanged += new System.EventHandler(this.textBoxBenutzerName_TextChanged);
            // 
            // textBoxPasswort
            // 
            this.textBoxPasswort.Location = new System.Drawing.Point(262, 187);
            this.textBoxPasswort.Name = "textBoxPasswort";
            this.textBoxPasswort.Size = new System.Drawing.Size(100, 22);
            this.textBoxPasswort.TabIndex = 1;
            this.textBoxPasswort.TextChanged += new System.EventHandler(this.textBoxPasswort_TextChanged);
            // 
            // labelBenutzerName
            // 
            this.labelBenutzerName.AutoSize = true;
            this.labelBenutzerName.Location = new System.Drawing.Point(99, 112);
            this.labelBenutzerName.Name = "labelBenutzerName";
            this.labelBenutzerName.Size = new System.Drawing.Size(99, 16);
            this.labelBenutzerName.TabIndex = 2;
            this.labelBenutzerName.Text = "Benutzer Name";
            // 
            // labelPasswort
            // 
            this.labelPasswort.AutoSize = true;
            this.labelPasswort.Location = new System.Drawing.Point(99, 193);
            this.labelPasswort.Name = "labelPasswort";
            this.labelPasswort.Size = new System.Drawing.Size(62, 16);
            this.labelPasswort.TabIndex = 3;
            this.labelPasswort.Text = "Passwort";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(262, 261);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonAcountErstellen
            // 
            this.buttonAcountErstellen.Location = new System.Drawing.Point(651, 25);
            this.buttonAcountErstellen.Name = "buttonAcountErstellen";
            this.buttonAcountErstellen.Size = new System.Drawing.Size(135, 23);
            this.buttonAcountErstellen.TabIndex = 5;
            this.buttonAcountErstellen.Text = "Acount erstellen";
            this.buttonAcountErstellen.UseVisualStyleBackColor = true;
            this.buttonAcountErstellen.Click += new System.EventHandler(this.buttonAcountErstellen_Click);
            // 
            // buttonPasswortvergessen
            // 
            this.buttonPasswortvergessen.Location = new System.Drawing.Point(420, 190);
            this.buttonPasswortvergessen.Name = "buttonPasswortvergessen";
            this.buttonPasswortvergessen.Size = new System.Drawing.Size(165, 23);
            this.buttonPasswortvergessen.TabIndex = 6;
            this.buttonPasswortvergessen.Text = "Passwort vergessen";
            this.buttonPasswortvergessen.UseVisualStyleBackColor = true;
            this.buttonPasswortvergessen.Click += new System.EventHandler(this.buttonPasswortvergessen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 456);
            this.Controls.Add(this.buttonPasswortvergessen);
            this.Controls.Add(this.buttonAcountErstellen);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelPasswort);
            this.Controls.Add(this.labelBenutzerName);
            this.Controls.Add(this.textBoxPasswort);
            this.Controls.Add(this.textBoxBenutzerName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBenutzerName;
        private System.Windows.Forms.TextBox textBoxPasswort;
        private System.Windows.Forms.Label labelBenutzerName;
        private System.Windows.Forms.Label labelPasswort;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonAcountErstellen;
        private System.Windows.Forms.Button buttonPasswortvergessen;
    }
}
