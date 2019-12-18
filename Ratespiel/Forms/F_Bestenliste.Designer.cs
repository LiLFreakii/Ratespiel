namespace Ratespiel
{
    partial class F_Bestenliste
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
            this.dGVBestenliste = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBestenliste)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVBestenliste
            // 
            this.dGVBestenliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBestenliste.Location = new System.Drawing.Point(12, 12);
            this.dGVBestenliste.Name = "dGVBestenliste";
            this.dGVBestenliste.Size = new System.Drawing.Size(776, 334);
            this.dGVBestenliste.TabIndex = 0;
            // 
            // Bestenliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGVBestenliste);
            this.Name = "Bestenliste";
            this.Text = "Bestenliste";
            ((System.ComponentModel.ISupportInitialize)(this.dGVBestenliste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVBestenliste;
    }
}