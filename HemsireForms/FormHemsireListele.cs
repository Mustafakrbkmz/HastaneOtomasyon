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

namespace OOPFinalHastane.WFA.HemsireForms
{
    public partial class FormHemsireListele : FormHemsireListeleIntermediate
    {
        public FormHemsireListele()
        {
            InitializeComponent();
        }

        private void FormHemsireListele_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbBirim.Items.AddRange(Enum.GetNames(typeof(Birimler)));
            Listem.ForEach(x => lstListe.Items.Add(x));
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (SeciliNesne == null) return;

            SeciliNesne.Ad = txtAd.Text;
            SeciliNesne.Soyad = txtSoyad.Text;
            SeciliNesne.TCKN = txtTCKN.Text;
            SeciliNesne.DogumTarihi = dtpDogumTarihi.Value;
            SeciliNesne.Cinsiyeti = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString());
            SeciliNesne.Maas = nMaas.Value;
            SeciliNesne.Birimi = (Birimler)Enum.Parse(typeof(Birimler), cmbBirim.SelectedItem.ToString());
            lstListe.Items.Clear();
            Listem.ForEach(x => lstListe.Items.Add(x));
        }

        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null) return;
            SeciliNesne = lstListe.SelectedItem as Hemsire;

            txtAd.Text = SeciliNesne.Ad;
            txtSoyad.Text = SeciliNesne.Soyad;
            txtTCKN.Text = SeciliNesne.TCKN;
            dtpDogumTarihi.Value = SeciliNesne.DogumTarihi;
            cmbCinsiyet.SelectedIndex = (int)SeciliNesne.Cinsiyeti;
            cmbBirim.SelectedIndex = (int)SeciliNesne.Birimi;
            nMaas.Value = SeciliNesne.Maas;
        }
    }
}
