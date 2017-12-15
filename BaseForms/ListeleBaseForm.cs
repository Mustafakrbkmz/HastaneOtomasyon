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

namespace OOPFinalHastane.WFA.BaseForms
{
    public partial class ListeleBaseForm<T> : EkleBaseForm
        where T : HastaneBase
    {
        public ListeleBaseForm()
        {
            InitializeComponent();
        }
        protected T BaseClass;
        public List<T> Listem { get; set; }
        public T SeciliNesne { get; set; }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (SeciliNesne == null) return;
            DialogResult cevap = MessageBox.Show($"{SeciliNesne.Ad} {SeciliNesne.Soyad} adlı kişiyi silmek istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Listem.Remove(SeciliNesne);
                SeciliNesne = null;
                lstListe.Items.Clear();
                Listem.ForEach(x => lstListe.Items.Add(x));
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string arama = txtAra.Text.ToLower();
            var sonuc = Arama<T>.Ara(Listem, arama);
            lstListe.Items.Clear();
            sonuc.ForEach(x => lstListe.Items.Add(x));
        }
    }
}
