using CloudSpeicher.Scripts;
using CloudSpeicher.view.Anmelden;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
            var filestream = db.DownlodeFile(Anmeldemaske.idBenutzer);

            //var test = StreamToByte.streamtoByte(filestream[0]);
            //Console.WriteLine(test.Length + " test");

            if (filestream != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                        {
                                filestream[0].Seek(0, SeekOrigin.Begin);
                                filestream[0].CopyTo(stream);
                        }
                        
                    }
                }
            }
        }
    }
}
