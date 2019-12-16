namespace Ratespiel
{
    partial class Hauptfenster
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
            this.txtFrage = new System.Windows.Forms.TextBox();
            this.btnNeuesSpiel = new System.Windows.Forms.Button();
            this.btnHighscore = new System.Windows.Forms.Button();
            this.btnBestenliste = new System.Windows.Forms.Button();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.cBoxAntwort1 = new System.Windows.Forms.CheckBox();
            this.cBoxAntwort2 = new System.Windows.Forms.CheckBox();
            this.cBoxAntwort3 = new System.Windows.Forms.CheckBox();
            this.cBoxAntwort4 = new System.Windows.Forms.CheckBox();
            this.btnAntworten = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFrage
            // 
            this.txtFrage.Location = new System.Drawing.Point(262, 36);
            this.txtFrage.Multiline = true;
            this.txtFrage.Name = "txtFrage";
            this.txtFrage.Size = new System.Drawing.Size(577, 85);
            this.txtFrage.TabIndex = 0;
            // 
            // btnNeuesSpiel
            // 
            this.btnNeuesSpiel.Location = new System.Drawing.Point(12, 12);
            this.btnNeuesSpiel.Name = "btnNeuesSpiel";
            this.btnNeuesSpiel.Size = new System.Drawing.Size(191, 23);
            this.btnNeuesSpiel.TabIndex = 1;
            this.btnNeuesSpiel.Text = "Neues Spiel";
            this.btnNeuesSpiel.UseVisualStyleBackColor = true;
            this.btnNeuesSpiel.Click += new System.EventHandler(this.btnNeuesSpiel_Click);
            // 
            // btnHighscore
            // 
            this.btnHighscore.Location = new System.Drawing.Point(12, 41);
            this.btnHighscore.Name = "btnHighscore";
            this.btnHighscore.Size = new System.Drawing.Size(191, 23);
            this.btnHighscore.TabIndex = 4;
            this.btnHighscore.Text = "Highscore";
            this.btnHighscore.UseVisualStyleBackColor = true;
            // 
            // btnBestenliste
            // 
            this.btnBestenliste.Location = new System.Drawing.Point(12, 70);
            this.btnBestenliste.Name = "btnBestenliste";
            this.btnBestenliste.Size = new System.Drawing.Size(191, 23);
            this.btnBestenliste.TabIndex = 5;
            this.btnBestenliste.Text = "Bestenliste";
            this.btnBestenliste.UseVisualStyleBackColor = true;
            // 
            // btnBeenden
            // 
            this.btnBeenden.Location = new System.Drawing.Point(12, 101);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(191, 23);
            this.btnBeenden.TabIndex = 6;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(829, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(10, 13);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = " ";
            // 
            // cBoxAntwort1
            // 
            this.cBoxAntwort1.AutoSize = true;
            this.cBoxAntwort1.Location = new System.Drawing.Point(262, 139);
            this.cBoxAntwort1.Name = "cBoxAntwort1";
            this.cBoxAntwort1.Size = new System.Drawing.Size(15, 14);
            this.cBoxAntwort1.TabIndex = 8;
            this.cBoxAntwort1.UseVisualStyleBackColor = true;
            // 
            // cBoxAntwort2
            // 
            this.cBoxAntwort2.AutoSize = true;
            this.cBoxAntwort2.Location = new System.Drawing.Point(584, 139);
            this.cBoxAntwort2.Name = "cBoxAntwort2";
            this.cBoxAntwort2.Size = new System.Drawing.Size(15, 14);
            this.cBoxAntwort2.TabIndex = 9;
            this.cBoxAntwort2.UseVisualStyleBackColor = true;
            // 
            // cBoxAntwort3
            // 
            this.cBoxAntwort3.AutoSize = true;
            this.cBoxAntwort3.Location = new System.Drawing.Point(262, 214);
            this.cBoxAntwort3.Name = "cBoxAntwort3";
            this.cBoxAntwort3.Size = new System.Drawing.Size(15, 14);
            this.cBoxAntwort3.TabIndex = 10;
            this.cBoxAntwort3.UseVisualStyleBackColor = true;
            // 
            // cBoxAntwort4
            // 
            this.cBoxAntwort4.AutoSize = true;
            this.cBoxAntwort4.Location = new System.Drawing.Point(584, 214);
            this.cBoxAntwort4.Name = "cBoxAntwort4";
            this.cBoxAntwort4.Size = new System.Drawing.Size(15, 14);
            this.cBoxAntwort4.TabIndex = 11;
            this.cBoxAntwort4.UseVisualStyleBackColor = true;
            // 
            // btnAntworten
            // 
            this.btnAntworten.Location = new System.Drawing.Point(262, 269);
            this.btnAntworten.Name = "btnAntworten";
            this.btnAntworten.Size = new System.Drawing.Size(191, 23);
            this.btnAntworten.TabIndex = 12;
            this.btnAntworten.Text = "Antworten";
            this.btnAntworten.UseVisualStyleBackColor = true;
            this.btnAntworten.Click += new System.EventHandler(this.btnAntworten_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(259, 17);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 13);
            this.lblScore.TabIndex = 13;
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 343);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnAntworten);
            this.Controls.Add(this.cBoxAntwort4);
            this.Controls.Add(this.cBoxAntwort3);
            this.Controls.Add(this.cBoxAntwort2);
            this.Controls.Add(this.cBoxAntwort1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.btnBestenliste);
            this.Controls.Add(this.btnHighscore);
            this.Controls.Add(this.btnNeuesSpiel);
            this.Controls.Add(this.txtFrage);
            this.Name = "Hauptfenster";
            this.Text = "Hauptfenster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFrage;
        private System.Windows.Forms.Button btnNeuesSpiel;
        private System.Windows.Forms.Button btnHighscore;
        private System.Windows.Forms.Button btnBestenliste;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.CheckBox cBoxAntwort1;
        private System.Windows.Forms.CheckBox cBoxAntwort2;
        private System.Windows.Forms.CheckBox cBoxAntwort3;
        private System.Windows.Forms.CheckBox cBoxAntwort4;
        private System.Windows.Forms.Button btnAntworten;
        private System.Windows.Forms.Label lblScore;
    }
}