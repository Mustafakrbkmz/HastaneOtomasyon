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

namespace OOPFinalHastane.WFA.RandevuForms
{
    public partial class FormRandevuEkle : BaseForm
    {
        public FormRandevuEkle()
        {
            InitializeComponent();
        }
        public Context MyContext { get; set; }
        public Hasta SeciliHasta { get; set; }
        public Doktor SeciliDoktor { get; set; }
        public Birimler SeciliBirim { get; set; }
        public List<string> Saatler { get; set; } = MyTool.SaatleriGetir();
        public Button SeciliButon { get; set; }
        Color seciliRenk = Color.DarkCyan;
        Color secilmemisRenk = Color.DarkGoldenrod;
        Color doluRenk = Color.DimGray;
        private void FormRandevuEkle_Load(object sender, EventArgs e)
        {
            cmbBirim.Items.AddRange(Enum.GetNames(typeof(Birimler)));
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            gbRandevu.Visible = false;

            MyContext.Hastalar.ForEach(x => lstListe.Items.Add(x));
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            lstListe.Items.Clear();
            Arama<Hasta>.Ara(MyContext.Hastalar, txtAra.Text.ToLower())
                .ForEach(x => lstListe.Items.Add(x));
        }

        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedIndex == -1)
            {
                SeciliHasta = null;
                gbRandevu.Visible = false;
                return;
            }
            SeciliHasta = lstListe.SelectedItem as Hasta;

            txtAd.Text = SeciliHasta.Ad;
            txtSoyad.Text = SeciliHasta.Soyad;
            txtTCKN.Text = SeciliHasta.TCKN;
            dtpDogumTarihi.Value = SeciliHasta.DogumTarihi;
            cmbCinsiyet.SelectedIndex = (int)SeciliHasta.Cinsiyeti;

            gbRandevu.Visible = true;
        }

        private void cmbBirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SeciliBirim = (Birimler)Enum.Parse(typeof(Birimler), cmbBirim.SelectedItem.ToString());

            MyContext.Doktorlar.Where(x => x.Birim == SeciliBirim)
                .OrderBy(y => y.Ad).ToList()
                .ForEach(z => cmbDoktor.Items.Add(z));
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDoktor.SelectedItem == null)
            {
                SeciliDoktor = null;
                flp1.Visible = false;
                return;
            }
            SeciliDoktor = cmbDoktor.SelectedItem as Doktor;
            flp1.Visible = true;
            ButonDoldur();
            SeciliButon = null;

            List<Randevu> doktorunRandevulari = MyContext.Randevular.
                Where(x => x.Doktor.ID == SeciliDoktor.ID).ToList();
            if (doktorunRandevulari.Count > 0)
            {
                foreach (var item in doktorunRandevulari)
                {
                    ButonKapat(Saatler[item.SiraNumarasi]);
                }
            }
        }
        void ButonKapat(string text)
        {
            foreach (Button item in flp1.Controls)
            {
                if (item.Text == text && item.Enabled == true)
                {
                    item.Enabled = false;
                    item.BackColor = doluRenk;
                }
            }
        }
        void ButonDoldur()
        {
            flp1.Controls.Clear();
            for (int i = 0; i < Saatler.Count; i++)
            {
                Button saatButton = new Button()
                {
                    BackColor = secilmemisRenk,
                    Name = "btnSaat_" + i,
                    Text = Saatler[i],
                    Size = new Size(92, 45),
                    ForeColor = Color.White
                };
                saatButton.Click += SaatButton_Click;
                flp1.Controls.Add(saatButton);
            }
        }

        private void SaatButton_Click(object sender, EventArgs e)
        {
            SeciliButon = sender as Button;
            foreach (Button item in flp1.Controls)
            {
                if (item.Name == SeciliButon.Name)
                    SeciliButon.BackColor = seciliRenk;
                else if (item.Enabled)
                    item.BackColor = secilmemisRenk;
            }
        }

        private void btnRandevuKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (SeciliButon == null)
                    throw new Exception("Önce randevu saatini seçiniz");
                List<Randevu> hastaninRandevulari = MyContext.Randevular.
                    Where(x => x.Hasta.ID == SeciliHasta.ID).ToList();
                foreach (var item in hastaninRandevulari)
                {
                    if (item.SiraNumarasi == Saatler.IndexOf(SeciliButon.Text))
                        throw new Exception($"Hastanın {SeciliButon.Text} saatinde {item.Doktor} doktorunda randevusu bulunuyor");
                    else if(item.Birim==SeciliBirim)
                        throw new Exception($"Hastanın {Saatler[item.SiraNumarasi]} saatinde {SeciliBirim} biriminde başka bir randevusu bulunmaktadır.");
                }
                MyContext.Randevular.Add(new Randevu()
                {
                    Birim = SeciliBirim,
                    Doktor = SeciliDoktor,
                    Hasta = SeciliHasta,
                    SiraNumarasi = Saatler.IndexOf(SeciliButon.Text)
                });
                MessageBox.Show($"{SeciliHasta} {SeciliButon.Text} saatinde {SeciliDoktor} doktordan randevu alma işlemi başarılı", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lstListe.SelectedIndex = -1;
                cmbDoktor.SelectedIndex = -1;
                cmbBirim.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
