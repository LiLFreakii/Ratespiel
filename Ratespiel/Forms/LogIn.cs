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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            Form fRegi = new Registration();
            //
            fRegi.Show();
        }

        private void btnEinloggen_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Username = txtUsername.Text;
            user.Passwort = txtPasswort.Text;

            Form fSpiel = new Hauptfenster(user);
            this.Close();
            fSpiel.Show();
        }
    }
}
