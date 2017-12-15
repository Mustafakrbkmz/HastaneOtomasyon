namespace OOPFinalHastane.WFA.RandevuForms
{
    partial class FormRandevuEkle
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtTCKN = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbRandevu = new System.Windows.Forms.GroupBox();
            this.btnRandevuKaydet = new System.Windows.Forms.Button();
            this.flp1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbRandevu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtAra);
            this.splitContainer1.Panel1.Controls.Add(this.lstListe);
            this.splitContainer1.Panel1.Controls.Add(this.cmbCinsiyet);
            this.splitContainer1.Panel1.Controls.Add(this.dtpDogumTarihi);
            this.splitContainer1.Panel1.Controls.Add(this.txtTCKN);
            this.splitContainer1.Panel1.Controls.Add(this.txtSoyad);
            this.splitContainer1.Panel1.Controls.Add(this.txtAd);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbRandevu);
            this.splitContainer1.Size = new System.Drawing.Size(1143, 463);
            this.splitContainer1.SplitterDistance = 606;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 12);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(220, 22);
            this.txtAra.TabIndex = 44;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.ItemHeight = 14;
            this.lstListe.Location = new System.Drawing.Point(12, 41);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(220, 256);
            this.lstListe.TabIndex = 45;
            this.lstListe.SelectedIndexChanged += new System.EventHandler(this.lstListe_SelectedIndexChanged);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Enabled = false;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(333, 140);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(178, 22);
            this.cmbCinsiyet.TabIndex = 42;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Enabled = false;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(333, 111);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(178, 22);
            this.dtpDogumTarihi.TabIndex = 41;
            // 
            // txtTCKN
            // 
            this.txtTCKN.Enabled = false;
            this.txtTCKN.Location = new System.Drawing.Point(333, 82);
            this.txtTCKN.Name = "txtTCKN";
            this.txtTCKN.Size = new System.Drawing.Size(178, 22);
            this.txtTCKN.TabIndex = 40;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Enabled = false;
            this.txtSoyad.Location = new System.Drawing.Point(333, 53);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(178, 22);
            this.txtSoyad.TabIndex = 39;
            // 
            // txtAd
            // 
            this.txtAd.Enabled = false;
            this.txtAd.Location = new System.Drawing.Point(333, 24);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(178, 22);
            this.txtAd.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 14);
            this.label5.TabIndex = 34;
            this.label5.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 14);
            this.label4.TabIndex = 35;
            this.label4.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 14);
            this.label3.TabIndex = 36;
            this.label3.Text = "TCKN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 37;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 14);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ad";
            // 
            // gbRandevu
            // 
            this.gbRandevu.Controls.Add(this.btnRandevuKaydet);
            this.gbRandevu.Controls.Add(this.flp1);
            this.gbRandevu.Controls.Add(this.cmbDoktor);
            this.gbRandevu.Controls.Add(this.label8);
            this.gbRandevu.Controls.Add(this.cmbBirim);
            this.gbRandevu.Controls.Add(this.label7);
            this.gbRandevu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRandevu.Location = new System.Drawing.Point(0, 0);
            this.gbRandevu.Name = "gbRandevu";
            this.gbRandevu.Size = new System.Drawing.Size(533, 463);
            this.gbRandevu.TabIndex = 1;
            this.gbRandevu.TabStop = false;
            this.gbRandevu.Text = "Hastane Randevu";
            // 
            // btnRandevuKaydet
            // 
            this.btnRandevuKaydet.Location = new System.Drawing.Point(68, 328);
            this.btnRandevuKaydet.Name = "btnRandevuKaydet";
            this.btnRandevuKaydet.Size = new System.Drawing.Size(125, 39);
            this.btnRandevuKaydet.TabIndex = 20;
            this.btnRandevuKaydet.Text = "Randevu Kaydet";
            this.btnRandevuKaydet.UseVisualStyleBackColor = true;
            this.btnRandevuKaydet.Click += new System.EventHandler(this.btnRandevuKaydet_Click);
            // 
            // flp1
            // 
            this.flp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp1.Location = new System.Drawing.Point(68, 54);
            this.flp1.Name = "flp1";
            this.flp1.Padding = new System.Windows.Forms.Padding(5);
            this.flp1.Size = new System.Drawing.Size(412, 268);
            this.flp1.TabIndex = 19;
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(315, 22);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(165, 22);
            this.cmbDoktor.TabIndex = 15;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 14);
            this.label8.TabIndex = 17;
            this.label8.Text = "Doktor";
            // 
            // cmbBirim
            // 
            this.cmbBirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Location = new System.Drawing.Point(68, 22);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(165, 22);
            this.cmbBirim.TabIndex = 16;
            this.cmbBirim.SelectedIndexChanged += new System.EventHandler(this.cmbBirim_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 14);
            this.label7.TabIndex = 18;
            this.label7.Text = "Birim";
            // 
            // FormRandevuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 463);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormRandevuEkle";
            this.Text = "FormRandevuEkle";
            this.Load += new System.EventHandler(this.FormRandevuEkle_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbRandevu.ResumeLayout(false);
            this.gbRandevu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TextBox txtAra;
        public System.Windows.Forms.ListBox lstListe;
        protected internal System.Windows.Forms.ComboBox cmbCinsiyet;
        protected internal System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        protected internal System.Windows.Forms.TextBox txtTCKN;
        protected internal System.Windows.Forms.TextBox txtSoyad;
        protected internal System.Windows.Forms.TextBox txtAd;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbRandevu;
        private System.Windows.Forms.Button btnRandevuKaydet;
        private System.Windows.Forms.FlowLayoutPanel flp1;
        private System.Windows.Forms.ComboBox cmbDoktor;
        protected internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBirim;
        protected internal System.Windows.Forms.Label label7;
    }
}