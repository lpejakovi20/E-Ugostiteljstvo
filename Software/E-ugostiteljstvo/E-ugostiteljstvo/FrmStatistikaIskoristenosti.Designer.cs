namespace E_ugostiteljstvo
{
    partial class FrmStatistikaIskoristenosti
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNamirniceIstekaoRok = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSveukupnaVrijednost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMjesec = new System.Windows.Forms.ComboBox();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.dgvIskoristenostNamirnica = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNamirniceIstekaoRok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIskoristenostNamirnica)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namirnice kojima je istekao rok trajanja:";
            // 
            // dgvNamirniceIstekaoRok
            // 
            this.dgvNamirniceIstekaoRok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNamirniceIstekaoRok.Location = new System.Drawing.Point(31, 70);
            this.dgvNamirniceIstekaoRok.Name = "dgvNamirniceIstekaoRok";
            this.dgvNamirniceIstekaoRok.RowHeadersWidth = 51;
            this.dgvNamirniceIstekaoRok.RowTemplate.Height = 24;
            this.dgvNamirniceIstekaoRok.Size = new System.Drawing.Size(724, 269);
            this.dgvNamirniceIstekaoRok.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sveukupna vrijednost neiskorištenih namirnica:";
            // 
            // txtSveukupnaVrijednost
            // 
            this.txtSveukupnaVrijednost.Location = new System.Drawing.Point(334, 368);
            this.txtSveukupnaVrijednost.Name = "txtSveukupnaVrijednost";
            this.txtSveukupnaVrijednost.Size = new System.Drawing.Size(115, 22);
            this.txtSveukupnaVrijednost.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Iskorištenost namirnica:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mjesec:";
            // 
            // cmbMjesec
            // 
            this.cmbMjesec.FormattingEnabled = true;
            this.cmbMjesec.Location = new System.Drawing.Point(464, 480);
            this.cmbMjesec.Name = "cmbMjesec";
            this.cmbMjesec.Size = new System.Drawing.Size(121, 24);
            this.cmbMjesec.TabIndex = 6;
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(601, 480);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(93, 24);
            this.btnFiltriraj.TabIndex = 7;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            // 
            // dgvIskoristenostNamirnica
            // 
            this.dgvIskoristenostNamirnica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIskoristenostNamirnica.Location = new System.Drawing.Point(34, 519);
            this.dgvIskoristenostNamirnica.Name = "dgvIskoristenostNamirnica";
            this.dgvIskoristenostNamirnica.RowHeadersWidth = 51;
            this.dgvIskoristenostNamirnica.RowTemplate.Height = 24;
            this.dgvIskoristenostNamirnica.Size = new System.Drawing.Size(721, 291);
            this.dgvIskoristenostNamirnica.TabIndex = 8;
            // 
            // FrmStatistikaIskoristenosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 822);
            this.Controls.Add(this.dgvIskoristenostNamirnica);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.cmbMjesec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSveukupnaVrijednost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvNamirniceIstekaoRok);
            this.Controls.Add(this.label1);
            this.Name = "FrmStatistikaIskoristenosti";
            this.Text = "FrmStatistikaIskoristenosti";
            this.Load += new System.EventHandler(this.FrmStatistikaIskoristenosti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNamirniceIstekaoRok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIskoristenostNamirnica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNamirniceIstekaoRok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSveukupnaVrijednost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMjesec;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.DataGridView dgvIskoristenostNamirnica;
    }
}