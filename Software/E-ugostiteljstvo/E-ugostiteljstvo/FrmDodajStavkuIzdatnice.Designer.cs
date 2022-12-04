namespace E_ugostiteljstvo
{
    partial class FrmDodajStavkuIzdatnice
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.cmbRokTrajanja = new System.Windows.Forms.ComboBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(80, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 270);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vrsta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rok trajanja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Količina";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(601, 101);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(149, 22);
            this.txtId.TabIndex = 6;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(601, 142);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(149, 22);
            this.txtNaziv.TabIndex = 7;
            // 
            // txtVrsta
            // 
            this.txtVrsta.Location = new System.Drawing.Point(601, 181);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(149, 22);
            this.txtVrsta.TabIndex = 8;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(601, 265);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(149, 22);
            this.txtKolicina.TabIndex = 10;
            // 
            // cmbRokTrajanja
            // 
            this.cmbRokTrajanja.FormattingEnabled = true;
            this.cmbRokTrajanja.Location = new System.Drawing.Point(601, 224);
            this.cmbRokTrajanja.Name = "cmbRokTrajanja";
            this.cmbRokTrajanja.Size = new System.Drawing.Size(149, 24);
            this.cmbRokTrajanja.TabIndex = 11;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(529, 372);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(102, 34);
            this.btnOdustani.TabIndex = 12;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(648, 372);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(102, 34);
            this.btnDodaj.TabIndex = 13;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // FrmDodajStavkuIzdatnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.cmbRokTrajanja);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtVrsta);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmDodajStavkuIzdatnice";
            this.Text = "FrmDodajStavkuIzdatnice";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.ComboBox cmbRokTrajanja;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodaj;
    }
}