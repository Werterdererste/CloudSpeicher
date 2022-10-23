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
    public partial class DateiHochladen : UserControl
    {

        public DateiHochladen()
        {
            InitializeComponent();
        }

        private void DateiHochladen_Load(object sender, EventArgs e)
        {

        }

        private void buttonFileUploard_Click(object sender, EventArgs e)
        {
            // file auswählen
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Hochladen";
                openFileDialog.InitialDirectory = @"C:\";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //file in db abspeichern
                    DatenbankAnbindung db = new DatenbankAnbindung();
                    db.UplodeFile("Admin", openFileDialog.OpenFile());
                }
            }            
        }
    }
}
