namespace E_ugostiteljstvo
{
    partial class MainForm
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
            this.btnSkeniraj = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(81, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 186);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSkeniraj
            // 
            this.btnSkeniraj.Location = new System.Drawing.Point(163, 258);
            this.btnSkeniraj.Name = "btnSkeniraj";
            this.btnSkeniraj.Size = new System.Drawing.Size(75, 23);
            this.btnSkeniraj.TabIndex = 1;
            this.btnSkeniraj.Text = "Skeniraj";
            this.btnSkeniraj.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(163, 418);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(82, 28);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Location = new System.Drawing.Point(146, 495);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(116, 30);
            this.btnRegistracija.TabIndex = 3;
            this.btnRegistracija.Text = "Registracija";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ili";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "e-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "lozinka:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 334);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(106, 381);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(196, 22);
            this.txtLozinka.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 562);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSkeniraj);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSkeniraj;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLozinka;
    }
}

