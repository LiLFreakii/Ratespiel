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
            lblUsername.Text = user.Username;
            lstFrage = daFrageAntworten.ReadAll();
            nIndex = 0;
            nScore = 0;
            nUserId = user.Id;
            
        }

        private void btnNeuesSpiel_Click(object sender, EventArgs e)
        {
            spiel = new Spiel();
            txtFrage.Visible = true;
            cBoxAntwort1.Visible = true;
            cBoxAntwort2.Visible = true;
            cBoxAntwort3.Visible = true;
            cBoxAntwort4.Visible = true;
            btnAntworten.Visible = true;

            setQusetion();
            daSpiel.Create(spiel);
        }

        private void btnAntworten_Click(object sender, EventArgs e)
        {
            spielantwort = new SpielAntwort();

            int nLoesung = lstFrage[nIndex].RichtigeAntwort;
            int nGewaehlteLoesung = 0;

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
                
                daSpielAntwort.Create(spielantwort);


                nIndex++;
                nScore++;

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
            }

            if(nIndex == lstFrage.Count)
            {
                MessageBox.Show("Alle Fragen beantwortet. Spiel beendet");
                cBoxAntwort1.Visible = false;
                cBoxAntwort2.Visible = false;
                cBoxAntwort3.Visible = false;
                cBoxAntwort4.Visible = false;
                btnAntworten.Visible = false;
                txtFrage.Text = "Juhu :D! Alle Fragen richtig beantwortet. Dein Score: " + nScore;
                bDurchlauf = false;
                
                daSpiel.Create(spiel);
            }
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

        private void btnHighscore_Click(object sender, EventArgs e)
        {
            Form fHighscore = new Highscore(spiel);
            fHighscore.Show();
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}
