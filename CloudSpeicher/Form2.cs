using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudSpeicher
{
    public partial class Form2 : Form
    {
        DatenbankAnbindung db = new DatenbankAnbindung();
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxBenutzername.Text != "" && textBoxPasswort.Text != "")
            {
                Console.WriteLine(textBoxBenutzername.Text + textBoxPasswort.Text);
                bool Loginerfolgreich = db.Anmelden(textBoxBenutzername.Text, textBoxPasswort.Text);

                if (Loginerfolgreich)
                {
                    string[] user = db.AcoutInformationen(textBoxBenutzername.Text);
                    Console.WriteLine(user[0]);
                    Console.WriteLine(user[1]);
                }
            }
        }

        private void buttonAcounterstellen_Click(object sender, EventArgs e)
        {

        }
    }
}
