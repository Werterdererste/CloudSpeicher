using CloudSpeicher.view.Anmelden;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudSpeicher
{
    public partial class Datei_Runterladen : UserControl
    {

        public Datei_Runterladen()
        {
            InitializeComponent();
        }

        private void buttonRunterLaden_Click(object sender, EventArgs e)
        {
            DatenbankAnbindung db = new DatenbankAnbindung();
            Stream filestream = db.DownlodeFile(Anmeldemaske.idBenutzer);
            if (filestream != null)
            {
                SaveFileDialog save = new SaveFileDialog();
                
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if ((filestream = save.OpenFile()) != null)
                    {
                        filestream.Close();
                    }
                }
            }
        }
    }
}
