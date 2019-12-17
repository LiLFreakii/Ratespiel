﻿using System;
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
    public partial class LogIn : Form
    {
        public LogIn()
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
            fRegi.Show();
        }

        private void btnEinloggen_Click(object sender, EventArgs e)
        {
            DataAccessUser daUser = new DataAccessUser();

            string strUsername = txtUsername.Text.ToLower();
            string strPasswort = txtPasswort.Text;

            List<User> lstUser = daUser.ReadAll();

            for (int i = 0; i < lstUser.Count; i++)
            {
                if (strUsername == lstUser[i].Username.ToLower())
                {
                    if (strPasswort == lstUser[i].Passwort)
                    {
                        MessageBox.Show("Erfolgreich eingeloggt");
                        Form fSpiel = new Hauptfenster(lstUser[i]);
                        this.Hide();
                        fSpiel.Show();
                    }
                    else
                    {
                        MessageBox.Show("Log in Fehlgeschlagen");
                    }
                }
            }

        }
    }
}
