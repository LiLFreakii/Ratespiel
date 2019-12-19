namespace Ratespiel
{
    partial class F_HinzufügenFrage
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
            this.txtAntwort1 = new System.Windows.Forms.TextBox();
            this.txtAntwort2 = new System.Windows.Forms.TextBox();
            this.txtAntwort3 = new System.Windows.Forms.TextBox();
            this.txtAntwort4 = new System.Windows.Forms.TextBox();
            this.txtRichtigeAntwort = new System.Windows.Forms.TextBox();
            this.txtSchwierigkeit = new System.Windows.Forms.TextBox();
            this.btnHinzufügenFrage = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboxKat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFrage
            // 
            this.txtFrage.Location = new System.Drawing.Point(12, 12);
            this.txtFrage.Name = "txtFrage";
            this.txtFrage.Size = new System.Drawing.Size(120, 20);
            this.txtFrage.TabIndex = 0;
            this.txtFrage.Text = "Frage";
            this.txtFrage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAntwort1
            // 
            this.txtAntwort1.Location = new System.Drawing.Point(138, 12);
            this.txtAntwort1.Name = "txtAntwort1";
            this.txtAntwort1.Size = new System.Drawing.Size(120, 20);
            this.txtAntwort1.TabIndex = 1;
            this.txtAntwort1.Text = "Antwort1";
            this.txtAntwort1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAntwort2
            // 
            this.txtAntwort2.Location = new System.Drawing.Point(264, 12);
            this.txtAntwort2.Name = "txtAntwort2";
            this.txtAntwort2.Size = new System.Drawing.Size(120, 20);
            this.txtAntwort2.TabIndex = 2;
            this.txtAntwort2.Text = "Antwort2";
            this.txtAntwort2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAntwort3
            // 
            this.txtAntwort3.Location = new System.Drawing.Point(390, 12);
            this.txtAntwort3.Name = "txtAntwort3";
            this.txtAntwort3.Size = new System.Drawing.Size(120, 20);
            this.txtAntwort3.TabIndex = 3;
            this.txtAntwort3.Text = "Antwort3";
            this.txtAntwort3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAntwort4
            // 
            this.txtAntwort4.Location = new System.Drawing.Point(12, 38);
            this.txtAntwort4.Name = "txtAntwort4";
            this.txtAntwort4.Size = new System.Drawing.Size(120, 20);
            this.txtAntwort4.TabIndex = 4;
            this.txtAntwort4.Text = "Antwort4";
            this.txtAntwort4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRichtigeAntwort
            // 
            this.txtRichtigeAntwort.Location = new System.Drawing.Point(138, 38);
            this.txtRichtigeAntwort.Name = "txtRichtigeAntwort";
            this.txtRichtigeAntwort.Size = new System.Drawing.Size(120, 20);
            this.txtRichtigeAntwort.TabIndex = 5;
            this.txtRichtigeAntwort.Text = "Richtige Antwort";
            this.txtRichtigeAntwort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSchwierigkeit
            // 
            this.txtSchwierigkeit.Location = new System.Drawing.Point(264, 38);
            this.txtSchwierigkeit.Name = "txtSchwierigkeit";
            this.txtSchwierigkeit.Size = new System.Drawing.Size(120, 20);
            this.txtSchwierigkeit.TabIndex = 6;
            this.txtSchwierigkeit.Text = "Schwierigkeit";
            this.txtSchwierigkeit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnHinzufügenFrage
            // 
            this.btnHinzufügenFrage.Location = new System.Drawing.Point(635, 9);
            this.btnHinzufügenFrage.Name = "btnHinzufügenFrage";
            this.btnHinzufügenFrage.Size = new System.Drawing.Size(153, 23);
            this.btnHinzufügenFrage.TabIndex = 8;
            this.btnHinzufügenFrage.Text = "Frage hinzufügen";
            this.btnHinzufügenFrage.UseVisualStyleBackColor = true;
            this.btnHinzufügenFrage.Click += new System.EventHandler(this.btnHinzufügenFrage_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Location = new System.Drawing.Point(635, 35);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(153, 23);
            this.btnAbbrechen.TabIndex = 9;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ratespiel.Properties.Resources.HinzufügenFrage;
            this.pictureBox1.Location = new System.Drawing.Point(12, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 312);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // cboxKat
            // 
            this.cboxKat.FormattingEnabled = true;
            this.cboxKat.Location = new System.Drawing.Point(390, 38);
            this.cboxKat.Name = "cboxKat";
            this.cboxKat.Size = new System.Drawing.Size(121, 21);
            this.cboxKat.TabIndex = 11;
            this.cboxKat.Text = "0";
            // 
            // F_HinzufügenFrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.cboxKat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnHinzufügenFrage);
            this.Controls.Add(this.txtSchwierigkeit);
            this.Controls.Add(this.txtRichtigeAntwort);
            this.Controls.Add(this.txtAntwort4);
            this.Controls.Add(this.txtAntwort3);
            this.Controls.Add(this.txtAntwort2);
            this.Controls.Add(this.txtAntwort1);
            this.Controls.Add(this.txtFrage);
            this.Name = "F_HinzufügenFrage";
            this.Text = "F_HinzufügenFrage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFrage;
        private System.Windows.Forms.TextBox txtAntwort1;
        private System.Windows.Forms.TextBox txtAntwort2;
        private System.Windows.Forms.TextBox txtAntwort3;
        private System.Windows.Forms.TextBox txtAntwort4;
        private System.Windows.Forms.TextBox txtRichtigeAntwort;
        private System.Windows.Forms.TextBox txtSchwierigkeit;
        private System.Windows.Forms.Button btnHinzufügenFrage;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboxKat;
    }
}