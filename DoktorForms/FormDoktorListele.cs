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

namespace OOPFinalHastane.WFA.DoktorForms
{
    public partial class FormDoktorListele : FormDoktorListeleIntermediate
    {
        public FormDoktorListele()
        {
            InitializeComponent();
        }
        public List<Hemsire> TumHemsireler { get; set; }
        public List<Hemsire> DoktorunHemsireleri { get; set; } = new List<Hemsire>();
        private void FormDoktorListele_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbBirim.Items.AddRange(Enum.GetNames(typeof(Birimler))); ;
            cmbUnvan.Items.AddRange(Enum.GetNames(typeof(Unvanlar)));
            Listem.OrderBy(x => x.Ad).ToList().ForEach(x => lstListe.Items.Add(x));
        }

        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null) return;
            SeciliNesne = lstListe.SelectedItem as Doktor;

            txtAd.Text = SeciliNesne.Ad;
            txtSoyad.Text = SeciliNesne.Soyad;
            txtTCKN.Text = SeciliNesne.TCKN;
            dtpDogumTarihi.Value = SeciliNesne.DogumTarihi;
            cmbCinsiyet.SelectedIndex = (int)SeciliNesne.Cinsiyeti;
            cmbBirim.SelectedIndex = (int)SeciliNesne.Birim;
            cmbUnvan.SelectedIndex = (int)SeciliNesne.Unvan;
            nMaas.Value = SeciliNesne.Maas;

            DoktorunHemsireleri = SeciliNesne.Hemsireler;
            clstHemsireler.Items.Clear();
            DoktorunHemsireleri.ForEach(x =>
                clstHemsireler.Items.Add(x)
            );
            for (int i = 0; i < clstHemsireler.Items.Count; i++)
            {
                clstHemsireler.SetItemChecked(i, true);
            }
            TumHemsireler.Where(
                    x => x.Birimi == SeciliNesne.Birim && x.AtandiMi == false
                )
                .ToList().ForEach(
                    y => clstHemsireler.Items.Add(y)
                );
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
            SeciliNesne.Unvan = (Unvanlar)Enum.Parse(typeof(Unvanlar), cmbUnvan.SelectedItem.ToString());
            DoktorunHemsireleri = new List<Hemsire>();
            for (int i = 0; i < clstHemsireler.Items.Count; i++)
            {
                if (clstHemsireler.GetItemCheckState(i) == CheckState.Checked)
                {
                    Hemsire seciliHemsire = clstHemsireler.Items[i] as Hemsire;
                    seciliHemsire.AtandiMi = true;
                    DoktorunHemsireleri.Add(seciliHemsire);
                }else if(clstHemsireler.GetItemCheckState(i) == CheckState.Unchecked)
                {
                    Hemsire secilmemisHemsire = clstHemsireler.Items[i] as Hemsire;
                    TumHemsireler.Where(x => x.ID == secilmemisHemsire.ID).FirstOrDefault().AtandiMi = false;
                }
            }
            SeciliNesne.Hemsireler = DoktorunHemsireleri;
            lstListe.Items.Clear();
            Listem.ForEach(x => lstListe.Items.Add(x));
        }
    }
}
