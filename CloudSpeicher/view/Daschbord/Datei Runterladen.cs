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
        List<(Stream, String)> dateien = new List<(Stream, String)>();
        public Datei_Runterladen()
        {
            InitializeComponent();
        }

        private void buttonRunterLaden_Click(object sender, EventArgs e)
        {
            int select = listBox1.SelectedIndex;
            SaveFile(dateien[select].Item1, dateien[0].Item2);           
        }

        private void SaveFile(Stream stream, string name)
        {
            int found = name.LastIndexOf(".");
            string filetype =  name.Substring(found);
            string filename = name.Substring(0, found);

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.FileName = filename;
                    saveFileDialog.Filter = "Datei type|*"+filetype;
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                        {
                                stream.Seek(0, SeekOrigin.Begin);
                                stream.CopyTo(fileStream);
                        }
                        
                    }
                }
            
        }

        private void Datei_Runterladen_Load(object sender, EventArgs e)
        {
            DatenbankAnbindung db = new DatenbankAnbindung();
            dateien = db.DownlodeFile(Anmeldemaske.idBenutzer);

            foreach((Stream stream, string name) in dateien)
            {
                listBox1.Items.Add(name);
            }
        }

        private void buttonLöschen_Click(object sender, EventArgs e)
        {

        }
    }
}
