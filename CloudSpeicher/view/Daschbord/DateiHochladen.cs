using CloudSpeicher.view.Anmelden;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudSpeicher
{
    public partial class DateiHochladen : UserControl
    {
        List<Stream> streams = new List<Stream>();

        public DateiHochladen()
        {
            InitializeComponent();
        }

        private void DateiHochladen_Load(object sender, EventArgs e)
        {

        }

        private void buttonHinzufügen_Click(object sender, EventArgs e)
        {
            // file auswählen
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Title = "Hochladen";
                openFileDialog.InitialDirectory = @"C:\";

                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (string file in openFileDialog.FileNames)
                    {
                        listBox1.Items.Add(file);
                        streams.Add(openFileDialog.OpenFile());
                    }
                }
            }
        }

        private void buttonAuswahlLöschen_Click(object sender, EventArgs e)
        {
            int selectet = listBox1.SelectedIndex;
            if (selectet >= 0)
            {
                streams.RemoveAt(selectet);
                listBox1.Items.RemoveAt(selectet);
            }
           
        }

        private void buttonAlleLöschen_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            streams.Clear();
        }

        private void buttonHochladen_Click(object sender, EventArgs e)
        {
            ////file in db abspeichern
            DatenbankAnbindung db = new DatenbankAnbindung();
            for (int i = 0; i < streams.Count; i++)
            {
                db.UplodeFile(Anmeldemaske.idBenutzer, streams[i]);
            }
            listBox1.Items.Clear();
            streams.Clear();
        }
    }
}
