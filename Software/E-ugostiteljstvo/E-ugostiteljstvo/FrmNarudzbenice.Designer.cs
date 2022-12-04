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
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.cmbSortiranje = new System.Windows.Forms.ComboBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(648, 50);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 24);
            this.cmbFilter.TabIndex = 3;
            // 
            // cmbSortiranje
            // 
            this.cmbSortiranje.FormattingEnabled = true;
            this.cmbSortiranje.Location = new System.Drawing.Point(466, 50);
            this.cmbSortiranje.Name = "cmbSortiranje";
            this.cmbSortiranje.Size = new System.Drawing.Size(121, 24);
            this.cmbSortiranje.TabIndex = 4;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(290, 50);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 5;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(173, 51);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(111, 22);
            this.txtPretraga.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filter:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sortiranje:";
            // 
            // FrmNarudzbenice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.cmbSortiranje);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.btnOtvori);
            this.Controls.Add(this.dgvNarudzbenice);
            this.Controls.Add(this.lblNarudzbenice);
            this.Name = "FrmNarudzbenice";
            this.Text = "FrmNarudzbenice";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbenice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNarudzbenice;
        private System.Windows.Forms.DataGridView dgvNarudzbenice;
        private System.Windows.Forms.Button btnOtvori;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.ComboBox cmbSortiranje;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}