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
            try
            {
                int select = listBox1.SelectedIndex;
                DownlodeFile(dateien[select].Item1, dateien[0].Item2);  
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex);
            }
         
        }

        private void DownlodeFile(Stream stream, string name)
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
            listBox1.Items.Clear();
            foreach((Stream stream, string name) in dateien)
            {
                listBox1.Items.Add(name);
            }
        }

        private void buttonLöschen_Click(object sender, EventArgs e)
        {
            try
            {
                string selectelement = listBox1.SelectedItem.ToString();
                DatenbankAnbindung db = new DatenbankAnbindung();
                db.DeleteFile(Anmeldemaske.idBenutzer, selectelement);
                this.Datei_Runterladen_Load(sender, e);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
