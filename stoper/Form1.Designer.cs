namespace stoper
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbWyswietlacz = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pilka = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pilka)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWyswietlacz
            // 
            this.lbWyswietlacz.AutoSize = true;
            this.lbWyswietlacz.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.lbWyswietlacz.Location = new System.Drawing.Point(12, 9);
            this.lbWyswietlacz.Name = "lbWyswietlacz";
            this.lbWyswietlacz.Size = new System.Drawing.Size(68, 73);
            this.lbWyswietlacz.TabIndex = 0;
            this.lbWyswietlacz.Text = "0";
            this.lbWyswietlacz.Click += new System.EventHandler(this.lbWyswietlacz_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(174, 12);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(174, 41);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 2;
            this.btStop.Text = "STOP";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pilka
            // 
            this.pilka.Image = global::stoper.Properties.Resources.pilka;
            this.pilka.Location = new System.Drawing.Point(0, 84);
            this.pilka.Name = "pilka";
            this.pilka.Size = new System.Drawing.Size(50, 50);
            this.pilka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pilka.TabIndex = 3;
            this.pilka.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 134);
            this.Controls.Add(this.pilka);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lbWyswietlacz);
            this.Name = "Form1";
            this.Text = "Stoper";
            ((System.ComponentModel.ISupportInitialize)(this.pilka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWyswietlacz;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pilka;
    }
}

