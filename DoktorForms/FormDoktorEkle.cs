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

namespace OOPFinalHastane.WFA.DoktorForms
{
    public partial class FormDoktorEkle : EkleBaseForm
    {
        public FormDoktorEkle()
        {
            InitializeComponent();
        }
        public List<Doktor> Doktorlar { get; set; }
        public List<Hemsire> TumHemsireler { get; set; }
        public List<Hemsire> DoktorunHemsireleri { get; set; } = new List<Hemsire>();
        public Birimler SeciliBirim { get; set; }
        private void FormDoktorEkle_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbBirim.Items.AddRange(Enum.GetNames(typeof(Birimler)));
            cmbUnvan.Items.AddRange(Enum.GetNames(typeof(Unvanlar)));
        }

        private void cmbBirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBirim.SelectedIndex == -1) return;
            clstHemsireler.Items.Clear();
            SeciliBirim = (Birimler)Enum.Parse(typeof(Birimler), cmbBirim.SelectedItem.ToString());
            var hemsireler = TumHemsireler.Where(x => x.Birimi == SeciliBirim && x.AtandiMi == false).ToList();
            hemsireler.ForEach(x => clstHemsireler.Items.Add(x));
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Doktor eklenecekDoktor = new Doktor()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    TCKN = txtTCKN.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    Cinsiyeti = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString()),
                    Birim = (Birimler)Enum.Parse(typeof(Birimler), cmbBirim.SelectedItem.ToString()),
                    Maas = nMaas.Value,
                    Unvan = (Unvanlar)Enum.Parse(typeof(Unvanlar), cmbUnvan.SelectedItem.ToString())
                };
                DoktorunHemsireleri = new List<Hemsire>();
                if (clstHemsireler.CheckedItems.Count > 0)
                {
                    foreach (var item in clstHemsireler.CheckedItems)
                    {
                        DoktorunHemsireleri.Add(item as Hemsire);
                    }
                }
                DoktorunHemsireleri.ForEach(x => x.AtandiMi = true);
                eklenecekDoktor.Hemsireler = DoktorunHemsireleri;
                Doktorlar.Add(eklenecekDoktor);
                MyTool.FormTemizle(this.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
