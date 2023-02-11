namespace E_ugostiteljstvo
{
    partial class FrmNarudzbenice
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
            this.lblNarudzbenice = new System.Windows.Forms.Label();
            this.dgvNarudzbenice = new System.Windows.Forms.DataGridView();
            this.btnOtvori = new System.Windows.Forms.Button();
            this.cmbSortiraj = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbenice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNarudzbenice
            // 
            this.lblNarudzbenice.AutoSize = true;
            this.lblNarudzbenice.Location = new System.Drawing.Point(23, 58);
            this.lblNarudzbenice.Name = "lblNarudzbenice";
            this.lblNarudzbenice.Size = new System.Drawing.Size(94, 16);
            this.lblNarudzbenice.TabIndex = 0;
            this.lblNarudzbenice.Text = "Narudžbenice:";
            // 
            // dgvNarudzbenice
            // 
            this.dgvNarudzbenice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbenice.Location = new System.Drawing.Point(26, 95);
            this.dgvNarudzbenice.Name = "dgvNarudzbenice";
            this.dgvNarudzbenice.RowHeadersWidth = 51;
            this.dgvNarudzbenice.RowTemplate.Height = 24;
            this.dgvNarudzbenice.Size = new System.Drawing.Size(743, 243);
            this.dgvNarudzbenice.TabIndex = 1;
            // 
            // btnOtvori
            // 
            this.btnOtvori.Location = new System.Drawing.Point(667, 366);
            this.btnOtvori.Name = "btnOtvori";
            this.btnOtvori.Size = new System.Drawing.Size(102, 36);
            this.btnOtvori.TabIndex = 2;
            this.btnOtvori.Text = "Otvori";
            this.btnOtvori.UseVisualStyleBackColor = true;
            this.btnOtvori.Click += new System.EventHandler(this.btnOtvori_Click);
            // 
            // cmbSortiraj
            // 
            this.cmbSortiraj.FormattingEnabled = true;
            this.cmbSortiraj.Items.AddRange(new object[] {
            "Datumu kreiranja",
            "Broju stavki(najmanje)",
            "Broju stavki(najviše)",
            "Iznosu(najmanji)",
            "Iznosu(najviši)"});
            this.cmbSortiraj.Location = new System.Drawing.Point(562, 50);
            this.cmbSortiraj.Name = "cmbSortiraj";
            this.cmbSortiraj.Size = new System.Drawing.Size(121, 24);
            this.cmbSortiraj.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sortiraj prema";
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(694, 50);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(75, 23);
            this.btnSortiraj.TabIndex = 8;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Location = new System.Drawing.Point(26, 366);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(120, 36);
            this.btnIzvjestaj.TabIndex = 9;
            this.btnIzvjestaj.Text = "Kreiraj izvještaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // FrmNarudzbenice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSortiraj);
            this.Controls.Add(this.btnOtvori);
            this.Controls.Add(this.dgvNarudzbenice);
            this.Controls.Add(this.lblNarudzbenice);
            this.Name = "FrmNarudzbenice";
            this.Text = "FrmNarudzbenice";
            this.Load += new System.EventHandler(this.FrmNarudzbenice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbenice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNarudzbenice;
        private System.Windows.Forms.DataGridView dgvNarudzbenice;
        private System.Windows.Forms.Button btnOtvori;
        private System.Windows.Forms.ComboBox cmbSortiraj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.Button btnIzvjestaj;
    }
}