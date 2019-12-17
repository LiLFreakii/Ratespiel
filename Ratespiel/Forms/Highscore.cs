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
    public partial class Highscore : Form
    {
        public Highscore(Spiel spiel)
        {
            InitializeComponent();
            DataAccessSpiel daSpiel = new DataAccessSpiel();
            dGVHighscore.DataSource = daSpiel.getHighscore(spiel);
        }

        private void btnSchließen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
