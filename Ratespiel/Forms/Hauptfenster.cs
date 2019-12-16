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
    public partial class Hauptfenster : Form
    {
        public Hauptfenster(User user)
        {
            InitializeComponent();
            lblUsername.Text = user.Username;
            txtFrage.Visible = false;
            cBoxAntwort1.Visible = false;
            cBoxAntwort2.Visible = false;
            cBoxAntwort3.Visible = false;
            cBoxAntwort4.Visible = false;
        }

        private void btnNeuesSpiel_Click(object sender, EventArgs e)
        {
            bool bSpiel = true;
            int nScore = 0;
            Spiel spiel = new Spiel();
            DataAccess<FragenAntworten> daFrageAntworten = new DataAccessFragenAntworten();
            List<Frage> lstFrage = daSpiel.ReadAll();

            txtFrage.Visible = true;
            cBoxAntwort1.Visible = true;
            cBoxAntwort2.Visible = true;
            cBoxAntwort3.Visible = true;
            cBoxAntwort4.Visible = true;

            while (bSpiel == true)
            {
                txtFrage.Text = 
            }
            
        }
    }
}
