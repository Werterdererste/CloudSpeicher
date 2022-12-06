using CloudSpeicher.Scripts;
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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            labelInfoFeld.Hide();
            labelInfoPasswort.Hide();
            labelInfoUsername.Hide();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            DatenbankAnbindung db = new DatenbankAnbindung();

         Console.WriteLine("t");

            //Alle Felder Ausgefüllt
            bool Empty = textBoxVorname.TextLength == 0 || textBoxNachname.TextLength == 0
                || textBoxUsername.TextLength == 0 || textBoxPasswort.TextLength == 0
                || textBoxPasswortwiederholen.TextLength == 0;


            if (!Empty)
            {
                // username nicht benutzt
                if (db.UsernameFree(textBoxUsername.Text))
                {
                    //Passwörter stimmen überein
                    if (textBoxPasswort.Text == textBoxPasswortwiederholen.Text)
                    {
                        //erse ebene
                        string passwortHash = Passwortverschlüsseln.GetHashString(textBoxPasswort.Text);

                        db.Acountersellen(textBoxUsername.Text,passwortHash, textBoxVorname.Text,
                            textBoxNachname.Text);

                        //fenster schlißen
                        this.Close();
                    }
                    else
                    {
                        labelInfoPasswort.Show();
                    }
                }
                else
                {
                    labelInfoUsername.Show();
                }
            }
            else
            {
                labelInfoFeld.Show();
            }
        }
    }
}
