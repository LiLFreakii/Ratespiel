using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ratespiel
{
    public partial class Hauptfenster : Form
    {
        DataAccessFragenAntworten daFrageAntworten = new DataAccessFragenAntworten();
        DataAccessSpiel daSpiel = new DataAccessSpiel();
        DataAccessSpielAntwort daSpielAntwort = new DataAccessSpielAntwort();
        SpielAntwort spielantwort = null;
        List<FragenAntworten> lstFrage = null;
        int nIndex;
        int nScore;
        Spiel spiel;
        int nUserId;
        bool bDurchlauf = true;

        public Hauptfenster(User user)
        {
            InitializeComponent();
            lblUsername.Text = user.Username;
            txtFrage.Visible = false;
            cBoxAntwort1.Visible = false;
            cBoxAntwort2.Visible = false;
            cBoxAntwort3.Visible = false;
            cBoxAntwort4.Visible = false;
            btnAntworten.Visible = false;
            btnFrageHinzufügen.Visible = false;
            btnUserHinzufügen.Visible = false;
            lblUsername.Text = user.Username;
            lblScore.Text = "";
            
            nUserId = user.Id;
            spiel = new Spiel();

            spiel.UserId = nUserId;
            spiel.Score = nScore;
            spiel.Datum = System.DateTime.Today;

            cboxFuellen();

            if (user.Rolle == "A") 
            {
                btnFrageHinzufügen.Visible = true;
                btnUserHinzufügen.Visible = true;
            }
        }

        private void btnNeuesSpiel_Click(object sender, EventArgs e)
        {
            spiel.SpielNr = daSpielAntwort.getSpielnr();
            DataAccessKategorie daKategorie = new DataAccessKategorie();
            nIndex = 0;
            nScore = 0;
            string strKategorie = cboxKat.Text;
            int nId = daKategorie.getKatId(strKategorie);
            lstFrage = daFrageAntworten.getQuestion(nId);
            txtFrage.Visible = true;
            cBoxAntwort1.Visible = true;
            cBoxAntwort2.Visible = true;
            cBoxAntwort3.Visible = true;
            cBoxAntwort4.Visible = true;
            btnAntworten.Visible = true;
            setQusetion();
        }

        private void btnAntworten_Click(object sender, EventArgs e)
        {
            spielantwort = new SpielAntwort();

            int nLoesung = lstFrage[nIndex].RichtigeAntwort;
            int nGewaehlteLoesung = 0;
            bDurchlauf = true;

            if (cBoxAntwort1.Checked)
            {
                nGewaehlteLoesung = 1;
            }
            else if (cBoxAntwort2.Checked)
            {
                nGewaehlteLoesung = 2;
            }
            else if (cBoxAntwort3.Checked)
            {
                nGewaehlteLoesung = 3;

            }
            else if (cBoxAntwort4.Checked)
            {
                nGewaehlteLoesung = 4;

            }

            if (nGewaehlteLoesung == nLoesung && bDurchlauf == true)
            {
                MessageBox.Show("Antwort richtig");
                spielantwort.Fuaid = lstFrage[nIndex].Id;
                spielantwort.GepruefteAntwort = 1;
                spielantwort.Spielnr = spiel.SpielNr;
                daSpielAntwort.Create(spielantwort);


                nIndex++;
                nScore++;

                lblScore.Text = "Score: " + nScore.ToString();
                if (nIndex < lstFrage.Count)
                {
                    setQusetion();
                }
                
            } else
            {
                MessageBox.Show("Falsche Antwort. Game Over");
                cBoxAntwort1.Visible = false;
                cBoxAntwort2.Visible = false;
                cBoxAntwort3.Visible = false;
                cBoxAntwort4.Visible = false;
                btnAntworten.Visible = false;
                txtFrage.Text = "Game Over :(. Dein Score: " + nScore;
                bDurchlauf = false;
                lblScore.Text = "Score: " + nScore.ToString();
                
                spiel.UserId = nUserId;
                spiel.Score = nScore;
                spiel.Datum = System.DateTime.Today;
                daSpiel.Create(spiel);

                nIndex = 0;
                nScore = 0;
                lstFrage.Clear();
            }

            if(nIndex == lstFrage.Count && bDurchlauf == true)
            {
                lblScore.Text = "Score: " + nScore.ToString();
                MessageBox.Show("Alle Fragen beantwortet. Spiel beendet");
                cBoxAntwort1.Visible = false;
                cBoxAntwort2.Visible = false;
                cBoxAntwort3.Visible = false;
                cBoxAntwort4.Visible = false;
                btnAntworten.Visible = false;
                txtFrage.Text = "Juhu :D! Alle Fragen richtig beantwortet. Dein Score: " + nScore;
                
                lstFrage.Clear();
                
                spiel.UserId = nUserId;
                spiel.Score = nScore;
                spiel.Datum = System.DateTime.Today;
                daSpiel.Create(spiel);
                bDurchlauf = false;
                nIndex = 0;
                nScore = 0;
            }
        }

        private void btnHighscore_Click(object sender, EventArgs e)
        {
            Form fHighscore = new F_Highscore(spiel);
            fHighscore.Show();
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBestenliste_Click(object sender, EventArgs e)
        {
            Form fBestenliste = new F_Bestenliste();
            fBestenliste.Show();
        }

        private void setQusetion()
        {
            cBoxAntwort1.Checked = false;
            cBoxAntwort2.Checked = false;
            cBoxAntwort3.Checked = false;
            cBoxAntwort4.Checked = false;

            txtFrage.Text = lstFrage[nIndex].Frage;
            cBoxAntwort1.Text = lstFrage[nIndex].Antwort1;
            cBoxAntwort2.Text = lstFrage[nIndex].Antwort2;
            cBoxAntwort3.Text = lstFrage[nIndex].Antwort3;
            cBoxAntwort4.Text = lstFrage[nIndex].Antwort4;
        }

        private void btnUserHinzufügen_Click(object sender, EventArgs e)
        {
            Form fRegi = new F_HinzufügenUser();
            fRegi.Show();
        }

        private void btnFrageHinzufügen_Click(object sender, EventArgs e)
        {
            Form fFrageHinzufügen = new F_HinzufügenFrage();
            fFrageHinzufügen.Show();
        }
        public void cboxFuellen()
        {
            DataAccessKategorie daKat = new DataAccessKategorie();

            List<Kategorie> lstKat = daKat.ReadAll();

            foreach (Kategorie kategorie in lstKat)
            {
                cboxKat.Items.Add(kategorie);
            }
        }
    }
}
