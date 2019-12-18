using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ratespiel
{
    public partial class F_HinzufügenFrage : Form
    {
        DataAccessFragenAntworten daFrageAntworten;
        FragenAntworten fragenAntworten;
        public F_HinzufügenFrage()
        {
            InitializeComponent();
            daFrageAntworten = new DataAccessFragenAntworten();
            fragenAntworten = new FragenAntworten();
            cboxFuellen();
        }

        private void btnHinzufügenFrage_Click(object sender, EventArgs e)
        {
            fragenAntworten.Frage = txtFrage.Text;
            fragenAntworten.Antwort1 = txtAntwort1.Text;
            fragenAntworten.Antwort2 = txtAntwort2.Text;
            fragenAntworten.Antwort3 = txtAntwort3.Text;
            fragenAntworten.Antwort4 = txtAntwort4.Text;
            fragenAntworten.Schwierigkeit = Convert.ToInt32(txtSchwierigkeit);
            fragenAntworten.RichtigeAntwort = Convert.ToInt32(txtRichtigeAntwort);
            fragenAntworten.KategorieId = Convert.ToInt32(cboxKat.Text);

            daFrageAntworten.Create(fragenAntworten);
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vorgang abbrechen?", "Abbrechen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        public void cboxFuellen()
        {
            DataAccessKategorie daKategorie = new DataAccessKategorie();
            List<Kategorie> lstKategorie = daKategorie.ReadAll();

            foreach (Kategorie kategorie in lstKategorie)
            {
                cboxKat.Items.Add(kategorie);
            }
        }
    }
}
