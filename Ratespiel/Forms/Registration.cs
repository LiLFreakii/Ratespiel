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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            User user = new User();
            DataAccess<User> daUser = new DataAccessUser();

            user.Username = txtUsername.Text;
            user.Passwort = txtPasswort.Text;
            user.Vorname = txtVorname.Text;
            user.Nachname = txtNachname.Text;
            user.Mail = txtMail.Text;

            try
            {
                daUser.Create(user);
                MessageBox.Show("Registrierung erfolgreich");
            }
            catch
            {
                MessageBox.Show("Registrierung fehlgeschlagen");
            }
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Wollen Sie wirklich den Vorgang abbrechen?", "Vorgang abbrechen?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Vorgang abgebrochen");
                this.Close();
            }
        }
    }
}
