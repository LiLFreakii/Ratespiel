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
            this.button1 = new System.Windows.Forms.Button();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtUN = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtvn = new System.Windows.Forms.TextBox();
            this.txtnn = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtmaxi = new System.Windows.Forms.TextBox();
            this.txtcount = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Anzeigen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dGV
            // 
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Location = new System.Drawing.Point(12, 12);
            this.dGV.Name = "dGV";
            this.dGV.Size = new System.Drawing.Size(776, 214);
            this.dGV.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(653, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Löschen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(547, 251);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(166, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Aktualisieren";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtUN
            // 
            this.txtUN.Location = new System.Drawing.Point(12, 338);
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(100, 20);
            this.txtUN.TabIndex = 6;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(118, 338);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(100, 20);
            this.txtPW.TabIndex = 7;
            // 
            // txtvn
            // 
            this.txtvn.Location = new System.Drawing.Point(224, 338);
            this.txtvn.Name = "txtvn";
            this.txtvn.Size = new System.Drawing.Size(100, 20);
            this.txtvn.TabIndex = 8;
            // 
            // txtnn
            // 
            this.txtnn.Location = new System.Drawing.Point(330, 338);
            this.txtnn.Name = "txtnn";
            this.txtnn.Size = new System.Drawing.Size(100, 20);
            this.txtnn.TabIndex = 9;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(436, 338);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(100, 20);
            this.txtmail.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(547, 335);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(547, 364);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Anlegen";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(547, 405);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(152, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "MaxID";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtmaxi
            // 
            this.txtmaxi.Location = new System.Drawing.Point(436, 405);
            this.txtmaxi.Name = "txtmaxi";
            this.txtmaxi.Size = new System.Drawing.Size(100, 20);
            this.txtmaxi.TabIndex = 14;
            // 
            // txtcount
            // 
            this.txtcount.Location = new System.Drawing.Point(436, 438);
            this.txtcount.Name = "txtcount";
            this.txtcount.Size = new System.Drawing.Size(100, 20);
            this.txtcount.TabIndex = 15;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(547, 438);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(152, 23);
            this.button7.TabIndex = 16;
            this.button7.Text = "Count";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 290);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(148, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "Kat Anzeigen";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 470);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.txtmaxi);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtnn);
            this.Controls.Add(this.txtvn);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtUN);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtUN;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtvn;
        private System.Windows.Forms.TextBox txtnn;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtmaxi;
        private System.Windows.Forms.TextBox txtcount;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

