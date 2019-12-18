namespace Ratespiel
{
    partial class F_HinzufügenUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.txtNachname = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtRolle = new System.Windows.Forms.TextBox();
            this.btnAbbruch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnlegen = new System.Windows.Forms.Button();
            this.btnLöschen = new System.Windows.Forms.Button();
            this.cboxUser = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 12);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(141, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPasswort
            // 
            this.txtPasswort.Location = new System.Drawing.Point(159, 12);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.Size = new System.Drawing.Size(141, 20);
            this.txtPasswort.TabIndex = 1;
            this.txtPasswort.Text = "Passwort";
            this.txtPasswort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(12, 38);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(141, 20);
            this.txtVorname.TabIndex = 2;
            this.txtVorname.Text = "Vorname";
            this.txtVorname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNachname
            // 
            this.txtNachname.Location = new System.Drawing.Point(159, 38);
            this.txtNachname.Name = "txtNachname";
            this.txtNachname.Size = new System.Drawing.Size(141, 20);
            this.txtNachname.TabIndex = 3;
            this.txtNachname.Text = "Nachname";
            this.txtNachname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(12, 64);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(141, 20);
            this.txtMail.TabIndex = 4;
            this.txtMail.Text = "Mail";
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRolle
            // 
            this.txtRolle.Location = new System.Drawing.Point(159, 64);
            this.txtRolle.Name = "txtRolle";
            this.txtRolle.Size = new System.Drawing.Size(41, 20);
            this.txtRolle.TabIndex = 5;
            this.txtRolle.Text = "Rolle";
            this.txtRolle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAbbruch
            // 
            this.btnAbbruch.Location = new System.Drawing.Point(210, 93);
            this.btnAbbruch.Name = "btnAbbruch";
            this.btnAbbruch.Size = new System.Drawing.Size(90, 23);
            this.btnAbbruch.TabIndex = 7;
            this.btnAbbruch.Text = "Abbrechen";
            this.btnAbbruch.UseVisualStyleBackColor = true;
            this.btnAbbruch.Click += new System.EventHandler(this.btnAbbruch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ratespiel.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(388, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 149);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnAnlegen
            // 
            this.btnAnlegen.Location = new System.Drawing.Point(210, 64);
            this.btnAnlegen.Name = "btnAnlegen";
            this.btnAnlegen.Size = new System.Drawing.Size(90, 23);
            this.btnAnlegen.TabIndex = 9;
            this.btnAnlegen.Text = "Anlegen";
            this.btnAnlegen.UseVisualStyleBackColor = true;
            this.btnAnlegen.Click += new System.EventHandler(this.btnAnlegen_Click);
            // 
            // btnLöschen
            // 
            this.btnLöschen.Location = new System.Drawing.Point(210, 127);
            this.btnLöschen.Name = "btnLöschen";
            this.btnLöschen.Size = new System.Drawing.Size(90, 23);
            this.btnLöschen.TabIndex = 10;
            this.btnLöschen.Text = "Löschen";
            this.btnLöschen.UseVisualStyleBackColor = true;
            // 
            // cboxUser
            // 
            this.cboxUser.FormattingEnabled = true;
            this.cboxUser.Location = new System.Drawing.Point(2, 127);
            this.cboxUser.Name = "cboxUser";
            this.cboxUser.Size = new System.Drawing.Size(198, 21);
            this.cboxUser.TabIndex = 11;
            // 
            // F_HinzufügenUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 188);
            this.Controls.Add(this.cboxUser);
            this.Controls.Add(this.btnLöschen);
            this.Controls.Add(this.btnAnlegen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAbbruch);
            this.Controls.Add(this.txtRolle);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtNachname);
            this.Controls.Add(this.txtVorname);
            this.Controls.Add(this.txtPasswort);
            this.Controls.Add(this.txtUsername);
            this.Name = "F_HinzufügenUser";
            this.Text = "F_HinzufügenUser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.TextBox txtNachname;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtRolle;
        private System.Windows.Forms.Button btnAbbruch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnlegen;
        private System.Windows.Forms.Button btnLöschen;
        private System.Windows.Forms.ComboBox cboxUser;
    }
}