namespace E_ugostiteljstvo
{
    partial class FrmIzbornikRacunovodstvo
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pregled narudžbenica";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 81);
            this.button2.TabIndex = 1;
            this.button2.Text = "Namirinice kojima bliži istek roka trajanja";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 75);
            this.button3.TabIndex = 2;
            this.button3.Text = "Statistika iskorištenosti namirnica";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmIzbornikRacunovodstvo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 410);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrmIzbornikRacunovodstvo";
            this.Text = "FrmIzbornikRacunovodstvo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}