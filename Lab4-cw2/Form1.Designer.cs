namespace Lab4_cw2
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
            this.clock1 = new Lab4_cw2.Clock();
            this.clock2 = new Lab4_cw2.Clock();
            this.SuspendLayout();
            // 
            // clock1
            // 
            this.clock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clock1.IsDigital = true;
            this.clock1.Location = new System.Drawing.Point(224, 26);
            this.clock1.Name = "clock1";
            this.clock1.Size = new System.Drawing.Size(293, 87);
            this.clock1.TabIndex = 0;
            this.clock1.Text = "clock1";
            // 
            // clock2
            // 
            this.clock2.IsDigital = false;
            this.clock2.Location = new System.Drawing.Point(224, 119);
            this.clock2.Name = "clock2";
            this.clock2.Size = new System.Drawing.Size(289, 289);
            this.clock2.TabIndex = 1;
            this.clock2.Text = "clock2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clock2);
            this.Controls.Add(this.clock1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Clock clock1;
        private Clock clock2;
    }
}

