namespace OOPFinalHastane.WFA.HastaForms
{
    partial class FormHastaListele
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
            this.SuspendLayout();
            // 
            // lstListe
            // 
            this.lstListe.SelectedIndexChanged += new System.EventHandler(this.lstListe_SelectedIndexChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FormHastaListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 280);
            this.Name = "FormHastaListele";
            this.Text = "FormHastaListele";
            this.Load += new System.EventHandler(this.FormHastaListele_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}