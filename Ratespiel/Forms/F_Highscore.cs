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
    public partial class F_Highscore : Form
    {
        public F_Highscore(Spiel spiel)
        {
            InitializeComponent();
            DataAccessHighscore daHighscore = new DataAccessHighscore();
            dGVHighscore.DataSource = daHighscore.getHighscore(spiel.UserId);
            dGVHighscore.Columns[0].Visible = false;
            dGVHighscore.Columns[2].Visible = false;
        }

        private void btnSchließen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
