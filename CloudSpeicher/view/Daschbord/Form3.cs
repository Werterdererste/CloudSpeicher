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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonKonto_Click(object sender, EventArgs e)
        {
            dateiHochladen1.Hide();
            datei_Runterladen1.Hide();

            konto1.Show();
        }

        private void buttonDateiHochladen_Click(object sender, EventArgs e)
        {
            datei_Runterladen1.Hide();
            konto1.Hide();

            dateiHochladen1.Show();
        }

        private void buttonDateiRunterladen_Click(object sender, EventArgs e)
        {
            dateiHochladen1.Hide();
            konto1.Hide();

            datei_Runterladen1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dateiHochladen1.Hide();
            datei_Runterladen1.Hide();
            konto1.Hide();
        }
    }
}
