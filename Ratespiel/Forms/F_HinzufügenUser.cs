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
    public partial class F_HinzufügenUser : Form
    {
        public F_HinzufügenUser()
        {
            InitializeComponent();
            cboxFuellen();
        }
        

        private void btnAbbruch_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vorgang abbrechen?", "Abbrechen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAnlegen_Click(object sender, EventArgs e)
        {
            DataAccessUser daUser = new DataAccessUser();
            User user = new User();

            user.Username = txtUsername.Text;
            user.Passwort = txtPasswort.Text;
            user.Vorname = txtVorname.Text;
            user.Nachname = txtNachname.Text;
            user.Mail = txtMail.Text;
            user.Rolle = txtRolle.Text;

            try
            {
                daUser.Create(user);
            }catch(Exception)
            {
                MessageBox.Show("Fehler. User konnte nicht angelegt werden");
            }
            
        }

        public void cboxFuellen()
        {
            DataAccessUser daUser = new DataAccessUser();

            List<User> lstUser =  daUser.ReadAll();

            foreach (User user in lstUser)
            {
                cboxUser.Items.Add(user);
            }
        }
    }
}
