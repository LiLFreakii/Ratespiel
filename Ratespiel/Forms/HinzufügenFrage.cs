using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ratespiel.Forms
{
    public partial class HinzufügenFrage : Form
    {
        public HinzufügenFrage()
        {
            InitializeComponent();
            cboxFuellen();
        }

        private void btnHinzufügenFrage_Click(object sender, EventArgs e)
        {
            DataAccessFragenAntworten daFragenAntwoten = new DataAccessFragenAntworten();
            FragenAntworten fragenAntworten = new FragenAntworten();

            fragenAntworten.Frage = txtFrage.Text;
            fragenAntworten.Antwort1 = txtAntwort1.Text;
            fragenAntworten.Antwort2 = txtAntwort2.Text;
            fragenAntworten.Antwort3 = txtAntwort3.Text;
            fragenAntworten.Antwort4 = txtAntwort4.Text;
            fragenAntworten.RichtigeAntwort = Convert.ToInt32(txtRichtigeAntwort.Text);
            fragenAntworten.Schwierigkeit = Convert.ToInt32(txtSchwierigkeit.Text); ;
            fragenAntworten.KategorieId = Convert.ToInt32(cboxKat.Text);

            try
            {
                daFragenAntwoten.Create(fragenAntworten);
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler. User konnte nicht angelegt werden");
            }
        }

        private void btnAbbrechenFrage_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vorgang abbrechen?", "Abbrechen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void cboxFuellen()
        {
            DataAccessFragenAntworten daFragenAntwoten = new DataAccessFragenAntworten();

            List<FragenAntworten> lstFragenAntworten = daFragenAntwoten.ReadAll();

            foreach (FragenAntworten fragenAntworten in lstFragenAntworten)
            {
                cboxKat.Items.Add(fragenAntworten);
            }
        }
    }
}
