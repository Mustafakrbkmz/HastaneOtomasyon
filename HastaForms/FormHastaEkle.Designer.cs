namespace OOPFinalHastane.WFA.HastaForms
{
    partial class FormHastaEkle
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
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Size = new System.Drawing.Size(178, 22);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FormHastaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 208);
            this.Name = "FormHastaEkle";
            this.Text = "FormHastaEkle";
            this.Load += new System.EventHandler(this.FormHastaEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}