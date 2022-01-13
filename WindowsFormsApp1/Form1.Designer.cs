
namespace WindowsFormsApp1
{
    partial class Form1
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

