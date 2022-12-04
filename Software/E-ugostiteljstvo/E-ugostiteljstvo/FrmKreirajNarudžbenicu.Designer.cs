namespace E_ugostiteljstvo
{
    partial class FrmKreirajNarudžbenicu
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
            this.dgvNarudžbenica = new System.Windows.Forms.DataGridView();
            this.dgvNamirnice = new System.Windows.Forms.DataGridView();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnPopuni = new System.Windows.Forms.Button();
            this.btnTraži = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtTraži = new System.Windows.Forms.TextBox();
            this.btnMakni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudžbenica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNamirnice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNarudžbenica
            // 
            this.dgvNarudžbenica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudžbenica.Location = new System.Drawing.Point(63, 90);
            this.dgvNarudžbenica.Name = "dgvNarudžbenica";
            this.dgvNarudžbenica.RowHeadersWidth = 51;
            this.dgvNarudžbenica.RowTemplate.Height = 24;
            this.dgvNarudžbenica.Size = new System.Drawing.Size(374, 352);
            this.dgvNarudžbenica.TabIndex = 0;
            // 
            // dgvNamirnice
            // 
            this.dgvNamirnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNamirnice.Location = new System.Drawing.Point(541, 90);
            this.dgvNamirnice.Name = "dgvNamirnice";
            this.dgvNamirnice.RowHeadersWidth = 51;
            this.dgvNamirnice.RowTemplate.Height = 24;
            this.dgvNamirnice.Size = new System.Drawing.Size(375, 352);
            this.dgvNamirnice.TabIndex = 1;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(841, 475);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 45);
            this.btnSpremi.TabIndex = 2;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            // 
            // btnPopuni
            // 
            this.btnPopuni.Location = new System.Drawing.Point(63, 475);
            this.btnPopuni.Name = "btnPopuni";
            this.btnPopuni.Size = new System.Drawing.Size(88, 45);
            this.btnPopuni.TabIndex = 3;
            this.btnPopuni.Text = "Popuni automatski";
            this.btnPopuni.UseVisualStyleBackColor = true;
            // 
            // btnTraži
            // 
            this.btnTraži.Location = new System.Drawing.Point(711, 42);
            this.btnTraži.Name = "btnTraži";
            this.btnTraži.Size = new System.Drawing.Size(75, 23);
            this.btnTraži.TabIndex = 4;
            this.btnTraži.Text = "Traži";
            this.btnTraži.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(841, 36);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 35);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // txtTraži
            // 
            this.txtTraži.Location = new System.Drawing.Point(553, 43);
            this.txtTraži.Name = "txtTraži";
            this.txtTraži.Size = new System.Drawing.Size(137, 22);
            this.txtTraži.TabIndex = 6;
            // 
            // btnMakni
            // 
            this.btnMakni.Location = new System.Drawing.Point(63, 36);
            this.btnMakni.Name = "btnMakni";
            this.btnMakni.Size = new System.Drawing.Size(75, 35);
            this.btnMakni.TabIndex = 7;
            this.btnMakni.Text = "Makni";
            this.btnMakni.UseVisualStyleBackColor = true;
            // 
            // FrmKreirajNarudžbenicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 549);
            this.Controls.Add(this.btnMakni);
            this.Controls.Add(this.txtTraži);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnTraži);
            this.Controls.Add(this.btnPopuni);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.dgvNamirnice);
            this.Controls.Add(this.dgvNarudžbenica);
            this.Name = "FrmKreirajNarudžbenicu";
            this.Text = "FrmKreirajNarudžbenicu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudžbenica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNamirnice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNarudžbenica;
        private System.Windows.Forms.DataGridView dgvNamirnice;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnPopuni;
        private System.Windows.Forms.Button btnTraži;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtTraži;
        private System.Windows.Forms.Button btnMakni;
    }
}