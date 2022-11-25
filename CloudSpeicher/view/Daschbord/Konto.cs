using CloudSpeicher.view.Anmelden;
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
    public partial class Konto : UserControl
    {
        public Konto()
        {
            InitializeComponent();
        }

        private void Konto_Load(object sender, EventArgs e)
        {
            Console.WriteLine(Anmeldemaske.idBenutzer + "k");

            labelUserId.Text = Anmeldemaske.idBenutzer.ToString();
            DatenbankAnbindung db = new DatenbankAnbindung();

            string[] info = db.AcoutInformationen(Anmeldemaske.idBenutzer);

            labelVorname.Text = info[0];
            labelNachname.Text = info[1];
            labelBenutzername.Text = info[2];
        }
    }
}
