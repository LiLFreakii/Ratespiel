namespace Ratespiel
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEinloggen = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnBeenden = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 12);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "Username";
            // 
            // txtPasswort
            // 
            this.txtPasswort.Location = new System.Drawing.Point(122, 12);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.Size = new System.Drawing.Size(100, 20);
            this.txtPasswort.TabIndex = 3;
            this.txtPasswort.Text = "Passwort";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 188);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnEinloggen
            // 
            this.btnEinloggen.Location = new System.Drawing.Point(12, 256);
            this.btnEinloggen.Name = "btnEinloggen";
            this.btnEinloggen.Size = new System.Drawing.Size(100, 23);
            this.btnEinloggen.TabIndex = 5;
            this.btnEinloggen.Text = "Einloggen";
            this.btnEinloggen.UseVisualStyleBackColor = true;
            this.btnEinloggen.Click += new System.EventHandler(this.btnEinloggen_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(118, 256);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(104, 23);
            this.btnRegistration.TabIndex = 6;
            this.btnRegistration.Text = "Registrieren";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnBeenden
            // 
            this.btnBeenden.Location = new System.Drawing.Point(228, 256);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(110, 23);
            this.btnBeenden.TabIndex = 7;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 291);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnEinloggen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPasswort);
            this.Controls.Add(this.txtUsername);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEinloggen;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnBeenden;
    }
}

