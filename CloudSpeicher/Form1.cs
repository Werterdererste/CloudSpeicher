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
    public partial class Form1 : Form
    {
        DatenbankAnbindung db = new DatenbankAnbindung();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxBenutzerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPasswort_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxBenutzerName.Text != "" && textBoxPasswort.Text != "")
            {
                Console.WriteLine(textBoxBenutzerName.Text + textBoxPasswort.Text);
                bool Loginerfolgreich = db.Anmelden(textBoxBenutzerName.Text, textBoxPasswort.Text);
            }
        }

        private void buttonPasswortvergessen_Click(object sender, EventArgs e)
        {

        }

        private void buttonAcountErstellen_Click(object sender, EventArgs e)
        {

        }
    }
}
