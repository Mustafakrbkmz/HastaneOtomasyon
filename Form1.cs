using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPFinalHastane.Entity;
using OOPFinalHastane.WFA.BaseForms;
using OOPFinalHastane.WFA.DoktorForms;
using OOPFinalHastane.WFA.HastaForms;
using OOPFinalHastane.WFA.HemsireForms;
using OOPFinalHastane.WFA.RandevuForms;

namespace OOPFinalHastane.WFA
{
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Context MyContext { get; set; } = new Context();
        FormHastaEkle frmHastaEkle;
        private void hastaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmHastaEkle == null || frmHastaEkle.IsDisposed)
                frmHastaEkle = new FormHastaEkle();
            frmHastaEkle.MdiParent = this;
            frmHastaEkle.Text = "Hasta Ekleme Formu";
            frmHastaEkle.Hastalar = MyContext.Hastalar;
            frmHastaEkle.Show();
        }
        FormHastaListele frmHastaListele;
        private void hastaListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmHastaListele == null || frmHastaListele.IsDisposed)
                frmHastaListele = new FormHastaListele();
            frmHastaListele.MdiParent = this;
            frmHastaListele.Text = "Hasta Listeleme Formu";
            frmHastaListele.Listem = MyContext.Hastalar;
            frmHastaListele.Show();
        }

        private void dışarıAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MyTool.Json<Context>(MyContext, new SaveFileDialog());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void içeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Context gelenData = new Context();
            try
            {
                MyTool.Json<Context>(ref gelenData, new OpenFileDialog());
                MyContext = gelenData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        FormHemsireEkle frmHemsireEkle;
        private void hemsireEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmHemsireEkle == null || frmHemsireEkle.IsDisposed)
                frmHemsireEkle = new FormHemsireEkle();
            frmHemsireEkle.MdiParent = this;
            frmHemsireEkle.Text = "Hemşire Ekleme Formu";
            frmHemsireEkle.Hemsireler = MyContext.Hemsireler;
            frmHemsireEkle.Show();
        }
        FormHemsireListele frmHemsireListele;
        private void hemsireListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmHemsireListele == null || frmHemsireListele.IsDisposed)
                frmHemsireListele = new FormHemsireListele();
            frmHemsireListele.MdiParent = this;
            frmHemsireListele.Text = "Hemşire Listeleme Formu";
            frmHemsireListele.Listem = MyContext.Hemsireler;
            frmHemsireListele.Show();
        }
        FormDoktorEkle frmDoktorEkle;
        private void doktorEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDoktorEkle == null || frmDoktorEkle.IsDisposed)
                frmDoktorEkle = new FormDoktorEkle();
            frmDoktorEkle.MdiParent = this;
            frmDoktorEkle.Text = "Doktor Ekleme Formu";
            frmDoktorEkle.Doktorlar = MyContext.Doktorlar;
            frmDoktorEkle.TumHemsireler = MyContext.Hemsireler;
            frmDoktorEkle.Show();
        }
        FormDoktorListele frmDoktorListele;
        private void doktorListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDoktorListele == null || frmDoktorListele.IsDisposed)
                frmDoktorListele = new FormDoktorListele();
            frmDoktorListele.MdiParent = this;
            frmDoktorListele.Text = "Doktor Listeleme Formu";
            frmDoktorListele.Listem = MyContext.Doktorlar;
            frmDoktorListele.TumHemsireler = MyContext.Hemsireler;
            frmDoktorListele.Show();
        }
        FormRandevuEkle frmRandevuEkle;
        private void randevuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRandevuEkle == null || frmRandevuEkle.IsDisposed)
                frmRandevuEkle = new FormRandevuEkle();
            frmRandevuEkle.MdiParent = this;
            frmRandevuEkle.Text = "Randevu Ekleme Formu";
            frmRandevuEkle.MyContext = MyContext;
            frmRandevuEkle.Show();
        }
    }
}
