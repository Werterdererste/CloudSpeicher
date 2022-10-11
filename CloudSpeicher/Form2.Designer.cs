namespace CloudSpeicher
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAcounterstellen = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPasswort = new System.Windows.Forms.TextBox();
            this.textBoxBenutzername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.buttonAcounterstellen);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.textBoxPasswort);
            this.panel1.Controls.Add(this.textBoxBenutzername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(200, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 350);
            this.panel1.TabIndex = 0;
            // 
            // buttonAcounterstellen
            // 
            this.buttonAcounterstellen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAcounterstellen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAcounterstellen.ForeColor = System.Drawing.Color.Navy;
            this.buttonAcounterstellen.Location = new System.Drawing.Point(150, 270);
            this.buttonAcounterstellen.Name = "buttonAcounterstellen";
            this.buttonAcounterstellen.Size = new System.Drawing.Size(100, 40);
            this.buttonAcounterstellen.TabIndex = 4;
            this.buttonAcounterstellen.Text = "Acount erstellen";
            this.buttonAcounterstellen.UseVisualStyleBackColor = true;
            this.buttonAcounterstellen.Click += new System.EventHandler(this.buttonAcounterstellen_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonLogin.Location = new System.Drawing.Point(150, 200);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 40);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPasswort
            // 
            this.textBoxPasswort.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBoxPasswort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPasswort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswort.Location = new System.Drawing.Point(100, 130);
            this.textBoxPasswort.Name = "textBoxPasswort";
            this.textBoxPasswort.Size = new System.Drawing.Size(200, 27);
            this.textBoxPasswort.TabIndex = 2;
            // 
            // textBoxBenutzername
            // 
            this.textBoxBenutzername.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBoxBenutzername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBenutzername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxBenutzername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBenutzername.Location = new System.Drawing.Point(100, 70);
            this.textBoxBenutzername.Name = "textBoxBenutzername";
            this.textBoxBenutzername.Size = new System.Drawing.Size(200, 27);
            this.textBoxBenutzername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anmelden";
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.RightToLeftLayout = true;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBenutzername;
        private System.Windows.Forms.TextBox textBoxPasswort;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonAcounterstellen;
    }
}