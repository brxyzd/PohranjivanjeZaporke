
namespace PohranjivanjeZaporke
{
    partial class GlavnaForma
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
            this.labelZadatak = new System.Windows.Forms.Label();
            this.buttonZadatak = new System.Windows.Forms.Button();
            this.labelZaporka = new System.Windows.Forms.Label();
            this.textBoxZaporka = new System.Windows.Forms.TextBox();
            this.buttonSpremi = new System.Windows.Forms.Button();
            this.buttonProvjeri = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelBravo = new System.Windows.Forms.Label();
            this.labelPogreska = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelZadatak
            // 
            this.labelZadatak.AutoSize = true;
            this.labelZadatak.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZadatak.Location = new System.Drawing.Point(39, 27);
            this.labelZadatak.Name = "labelZadatak";
            this.labelZadatak.Size = new System.Drawing.Size(474, 36);
            this.labelZadatak.TabIndex = 0;
            this.labelZadatak.Text = "Zadatak - Pohranjivanje zaporke";
            // 
            // buttonZadatak
            // 
            this.buttonZadatak.Location = new System.Drawing.Point(45, 82);
            this.buttonZadatak.Name = "buttonZadatak";
            this.buttonZadatak.Size = new System.Drawing.Size(122, 28);
            this.buttonZadatak.TabIndex = 1;
            this.buttonZadatak.Text = "Prikaži zadatak";
            this.buttonZadatak.UseVisualStyleBackColor = true;
            this.buttonZadatak.Click += new System.EventHandler(this.buttonZadatak_Click);
            // 
            // labelZaporka
            // 
            this.labelZaporka.AutoSize = true;
            this.labelZaporka.Location = new System.Drawing.Point(45, 174);
            this.labelZaporka.Name = "labelZaporka";
            this.labelZaporka.Size = new System.Drawing.Size(78, 13);
            this.labelZaporka.TabIndex = 2;
            this.labelZaporka.Text = "Unesi zaporku:";
            // 
            // textBoxZaporka
            // 
            this.textBoxZaporka.Location = new System.Drawing.Point(129, 171);
            this.textBoxZaporka.Name = "textBoxZaporka";
            this.textBoxZaporka.Size = new System.Drawing.Size(100, 20);
            this.textBoxZaporka.TabIndex = 3;
            this.textBoxZaporka.UseSystemPasswordChar = true;
            // 
            // buttonSpremi
            // 
            this.buttonSpremi.Location = new System.Drawing.Point(48, 214);
            this.buttonSpremi.Name = "buttonSpremi";
            this.buttonSpremi.Size = new System.Drawing.Size(75, 23);
            this.buttonSpremi.TabIndex = 4;
            this.buttonSpremi.Text = "Spremi";
            this.buttonSpremi.UseVisualStyleBackColor = true;
            this.buttonSpremi.Click += new System.EventHandler(this.buttonSpremi_Click);
            // 
            // buttonProvjeri
            // 
            this.buttonProvjeri.Location = new System.Drawing.Point(154, 214);
            this.buttonProvjeri.Name = "buttonProvjeri";
            this.buttonProvjeri.Size = new System.Drawing.Size(75, 23);
            this.buttonProvjeri.TabIndex = 5;
            this.buttonProvjeri.Text = "Provjeri";
            this.buttonProvjeri.UseVisualStyleBackColor = true;
            this.buttonProvjeri.Visible = false;
            this.buttonProvjeri.Click += new System.EventHandler(this.buttonProvjeri_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(438, 340);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelBravo
            // 
            this.labelBravo.AutoSize = true;
            this.labelBravo.Location = new System.Drawing.Point(245, 173);
            this.labelBravo.Name = "labelBravo";
            this.labelBravo.Size = new System.Drawing.Size(38, 13);
            this.labelBravo.TabIndex = 7;
            this.labelBravo.Text = "Bravo!";
            this.labelBravo.Visible = false;
            // 
            // labelPogreska
            // 
            this.labelPogreska.AutoSize = true;
            this.labelPogreska.Location = new System.Drawing.Point(245, 174);
            this.labelPogreska.Name = "labelPogreska";
            this.labelPogreska.Size = new System.Drawing.Size(55, 13);
            this.labelPogreska.TabIndex = 8;
            this.labelPogreska.Text = "Pogreška!";
            this.labelPogreska.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 397);
            this.Controls.Add(this.labelPogreska);
            this.Controls.Add(this.labelBravo);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonProvjeri);
            this.Controls.Add(this.buttonSpremi);
            this.Controls.Add(this.textBoxZaporka);
            this.Controls.Add(this.labelZaporka);
            this.Controls.Add(this.buttonZadatak);
            this.Controls.Add(this.labelZadatak);
            this.Name = "Form1";
            this.Text = "Seminarski rad - Antonio Brkic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZadatak;
        private System.Windows.Forms.Button buttonZadatak;
        private System.Windows.Forms.Label labelZaporka;
        private System.Windows.Forms.TextBox textBoxZaporka;
        private System.Windows.Forms.Button buttonSpremi;
        private System.Windows.Forms.Button buttonProvjeri;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelBravo;
        private System.Windows.Forms.Label labelPogreska;
    }
}

