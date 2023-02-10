namespace E_ugostiteljstvo
{
    partial class FrmStavkeIzdatnice
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
            this.dgvStavkeIzdatnice = new System.Windows.Forms.DataGridView();
            this.btnIspis = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUkloni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeIzdatnice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stavke izdatnice:";
            // 
            // dgvStavkeIzdatnice
            // 
            this.dgvStavkeIzdatnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeIzdatnice.Location = new System.Drawing.Point(52, 80);
            this.dgvStavkeIzdatnice.Name = "dgvStavkeIzdatnice";
            this.dgvStavkeIzdatnice.RowHeadersWidth = 51;
            this.dgvStavkeIzdatnice.RowTemplate.Height = 24;
            this.dgvStavkeIzdatnice.Size = new System.Drawing.Size(687, 268);
            this.dgvStavkeIzdatnice.TabIndex = 1;
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(52, 384);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(136, 37);
            this.btnIspis.TabIndex = 2;
            this.btnIspis.Text = "Ispiši Dokument";
            this.btnIspis.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(475, 384);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(127, 37);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj Namirnicu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(618, 384);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(121, 37);
            this.btnUkloni.TabIndex = 4;
            this.btnUkloni.Text = "Ukloni Namirnicu";
            this.btnUkloni.UseVisualStyleBackColor = true;
            // 
            // FrmStavkeIzdatnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.dgvStavkeIzdatnice);
            this.Controls.Add(this.label1);
            this.Name = "FrmStavkeIzdatnice";
            this.Text = "FrmStavkeIzdatnice";
            this.Load += new System.EventHandler(this.FrmStavkeIzdatnice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeIzdatnice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStavkeIzdatnice;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUkloni;
    }
}