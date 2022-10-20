using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudSpeicher.view.Anmelden
{
    public partial class Anmeldemaske : Form
    {
        public Anmeldemaske()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            /////////////passwort Hashen

            DatenbankAnbindung db = new DatenbankAnbindung();
            bool erfolgreich = db.Anmelden(textBoxBenutzername.Text, textBoxPasswort.Text);
            if (erfolgreich)
            {
                //öffne Dashbord
                Form dashdashboard = new Form3();
                dashdashboard.Show();

                this.Hide();
            }
            else
            {
                //anzeigen Passwort Falsch
                labelFalsch.Show();
            }
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            //öffne fenster Create Account
            Form createaccount = new CreateAccount();
            createaccount.Show();
        }

        private void Anmeldemaske_Load(object sender, EventArgs e)
        {
            labelFalsch.Hide();
        }

        private void linkLabelVergessen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //öffne passwortvergessen
        }
    }
}
