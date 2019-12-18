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
    public partial class F_Bestenliste : Form
    {
        DataAccessBestenliste daBesten;
        public F_Bestenliste()
        {
            InitializeComponent();
            daBesten = new DataAccessBestenliste();
            dGVBestenliste.DataSource = daBesten.getTopTen();
            dGVBestenliste.Columns[0].Visible = false;
            dGVBestenliste.Columns[1].HeaderText = "Spiel";
            dGVBestenliste.Columns[2].HeaderText = "User";
        }
    }
}
