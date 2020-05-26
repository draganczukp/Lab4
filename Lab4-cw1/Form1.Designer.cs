namespace Lab4_cw1
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
            this.lights3 = new Lab4_cw1.Lights();
            this.lights1 = new Lab4_cw1.Lights();
            this.SuspendLayout();
            // 
            // lights3
            // 
            this.lights3.Color1 = System.Drawing.Color.Green;
            this.lights3.Color2 = System.Drawing.Color.Yellow;
            this.lights3.Color3 = System.Drawing.Color.Red;
            this.lights3.Enabled1 = true;
            this.lights3.Enabled2 = true;
            this.lights3.Enabled3 = true;
            this.lights3.Location = new System.Drawing.Point(155, 69);
            this.lights3.Name = "lights3";
            this.lights3.Size = new System.Drawing.Size(89, 267);
            this.lights3.TabIndex = 3;
            this.lights3.Text = "lights3";
            // 
            // lights1
            // 
            this.lights1.Color1 = System.Drawing.Color.Green;
            this.lights1.Color2 = System.Drawing.Color.Yellow;
            this.lights1.Color3 = System.Drawing.Color.Red;
            this.lights1.Enabled1 = true;
            this.lights1.Enabled2 = true;
            this.lights1.Enabled3 = true;
            this.lights1.Location = new System.Drawing.Point(365, 69);
            this.lights1.Name = "lights1";
            this.lights1.Size = new System.Drawing.Size(56, 168);
            this.lights1.TabIndex = 3;
            this.lights1.Text = "lights3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lights1);
            this.Controls.Add(this.lights3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Lights lights3;
        private Lights lights1;
    }
}

