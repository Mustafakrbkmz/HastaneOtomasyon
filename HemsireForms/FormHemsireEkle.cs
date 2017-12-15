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

namespace OOPFinalHastane.WFA.HemsireForms
{
    public partial class FormHemsireEkle : EkleBaseForm
    {
        public FormHemsireEkle()
        {
            InitializeComponent();
        }
        public List<Hemsire> Hemsireler { get; set; }
        private void FormHemsireEkle_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbBirim.Items.AddRange(Enum.GetNames(typeof(Birimler)));
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Hemsireler.Add(new Hemsire()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    TCKN = txtTCKN.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    Cinsiyeti = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString()),
                    Birimi = (Birimler)Enum.Parse(typeof(Birimler), cmbBirim.SelectedItem.ToString()),
                    Maas = nMaas.Value
                });
                MyTool.FormTemizle(this.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
