using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunEklemeSistemi
{
    public partial class KategoriEkle : Form
    {
        public KategoriEkle()
        {
            InitializeComponent();
            db= new UrunKategoriDb();
        }

        UrunKategoriDb db;

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            Kategori kategori = new Kategori()
            {
                Ad = txtAd.Text,
                Aciklama = txtAciklama.Text

            };

            db.Kategoriler.Add(kategori);
            db.SaveChanges();

            txtAd.Text = "";
            txtAciklama.Text = "";



        }
    }
}
