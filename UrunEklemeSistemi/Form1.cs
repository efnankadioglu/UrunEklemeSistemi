using System.Diagnostics.Eventing.Reader;

namespace UrunEklemeSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            db = new UrunKategoriDb();
        }

        UrunKategoriDb db;

        void KategorileriGetir()
        {
            cmbKategori.DataSource = db.Kategoriler.ToList();
            cmbKategori.DisplayMember = "Ad";
            cmbKategori.ValueMember = "Id";
            cmbKategori.SelectedIndex = -1;
        }

        void UrunleriListele(List<Urun> liste)
        {
            lvUrunler.Items.Clear();
            foreach (var item in liste)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Id.ToString();
                lvi.SubItems.Add(item.Ad);
                lvi.SubItems.Add(item.Stok.ToString());
                lvi.SubItems.Add(item.Fiyat.ToString());
                lvi.SubItems.Add(item.Kategori.Ad);

                lvi.Tag = item.Id;

                lvUrunler.Items.Add(lvi);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KategorileriGetir();
            UrunleriListele(db.Urunler.ToList());
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun()
            {
                Ad = txtUrunAdi.Text,
                Stok = (int)nuStok.Value,
                Fiyat = nuFiyat.Value,
                KategoriId = (int)cmbKategori.SelectedValue
            };

            db.Urunler.Add(urun);
            db.SaveChanges();

            Temizle(this.Controls);

            UrunleriListele(db.Urunler.ToList());

        }

        void Temizle(Control.ControlCollection collection)
        {
            foreach (var item in collection)
            {
                if (item is TextBox) ((TextBox)item).Clear();
                else if (item is NumericUpDown) ((NumericUpDown)item).Value = 0;
                else if (item is ComboBox) ((ComboBox)item).SelectedIndex = 1;
                else if (item is GroupBox) Temizle(((GroupBox)item).Controls);

            }

        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lvUrunler.SelectedItems.Count > 0)
            {

                int id = (int)lvUrunler.SelectedItems[0].Tag;
                urun = db.Urunler.Find(id);
                db.Urunler.Remove(urun);
                db.SaveChanges();
                UrunleriListele(db.Urunler.ToList());

            }
        }

        Urun urun;

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            urun.Ad = txtUrunAdi.Text;
            urun.Fiyat = nuFiyat.Value;
            urun.Stok = (int)nuStok.Value;
            urun.KategoriId = (int)cmbKategori.SelectedValue;

            db.SaveChanges();
            Temizle(this.Controls);
            UrunleriListele(db.Urunler.ToList());
        }

        private void lvUrunler_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)lvUrunler.SelectedItems[0].Tag;
            Urun urun = db.Urunler.Find(id);
            txtUrunAdi.Text = urun.Ad;
            nuFiyat.Value = urun.Fiyat;
            nuStok.Value = urun.Stok;
            cmbKategori.SelectedValue = urun.KategoriId;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtAra.Text) && (rdKategoriAd.Checked || rdAd.Checked))
            {
                if (rdKategoriAd.Checked)
                {
                    UrunleriListele(db.Urunler.Where(a=>a.Kategori.Ad.Contains(txtAra.Text)).ToList());

                } else
                {
                    UrunleriListele(db.Urunler.Where(a => a.Ad.Contains(txtAra.Text)).ToList());
                }

            }

           else return;
        }
    }
}
