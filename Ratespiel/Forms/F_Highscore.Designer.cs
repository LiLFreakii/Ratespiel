namespace Ratespiel
{
    partial class F_Highscore
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
            this.dGVHighscore = new System.Windows.Forms.DataGridView();
            this.btnSchließen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHighscore)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVHighscore
            // 
            this.dGVHighscore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVHighscore.Location = new System.Drawing.Point(12, 12);
            this.dGVHighscore.Name = "dGVHighscore";
            this.dGVHighscore.Size = new System.Drawing.Size(397, 266);
            this.dGVHighscore.TabIndex = 0;
            // 
            // btnSchließen
            // 
            this.btnSchließen.Location = new System.Drawing.Point(283, 310);
            this.btnSchließen.Name = "btnSchließen";
            this.btnSchließen.Size = new System.Drawing.Size(126, 23);
            this.btnSchließen.TabIndex = 1;
            this.btnSchließen.Text = "Schließen";
            this.btnSchließen.UseVisualStyleBackColor = true;
            this.btnSchließen.Click += new System.EventHandler(this.btnSchließen_Click);
            // 
            // Highscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 345);
            this.Controls.Add(this.btnSchließen);
            this.Controls.Add(this.dGVHighscore);
            this.Name = "Highscore";
            this.Text = "Highscore";
            ((System.ComponentModel.ISupportInitialize)(this.dGVHighscore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVHighscore;
        private System.Windows.Forms.Button btnSchließen;
    }
}